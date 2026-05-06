using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace OnlineShop.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Order> Orders { get; set; } = new ObservableCollection<Order>();
        public ICollectionView OrdersView { get; set; }

        private Order _selectedOrder;
        public Order SelectedOrder
        {
            get => _selectedOrder;
            set { _selectedOrder = value; OnPropertyChanged(nameof(SelectedOrder)); }
        }

        private string _selectedStatusFilter = "Все";
        public string SelectedStatusFilter
        {
            get => _selectedStatusFilter;
            set { _selectedStatusFilter = value; OnPropertyChanged(nameof(SelectedStatusFilter)); OrdersView.Refresh(); }
        }

        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set { _isBusy = value; OnPropertyChanged(nameof(IsBusy)); }
        }

        public ICommand AddOrderCommand { get; }
        public ICommand EditOrderCommand { get; }
        public ICommand DeleteOrderCommand { get; }

        public MainWindowViewModel()
        {
            OrdersView = CollectionViewSource.GetDefaultView(Orders);
            OrdersView.Filter = obj =>
            {
                if (SelectedStatusFilter == "Все") return true;
                return (obj as Order)?.Status == SelectedStatusFilter;
            };

            AddOrderCommand = new RelayCommand(async obj =>
            {
                var win = new CreateWindow(this);
                if (win.ShowDialog() == true)
                {
                    IsBusy = true;
                    await Task.Delay(3000);
                    IsBusy = false;
                }
            });

            EditOrderCommand = new RelayCommand(obj =>
            {
                var win = new CreateWindow(this, SelectedOrder);
                win.ShowDialog();
                OrdersView.Refresh();
            }, obj => SelectedOrder != null);

            DeleteOrderCommand = new RelayCommand(obj =>
            {
                if (MessageBox.Show("Удалить выбранный заказ?", "Вопрос", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    Orders.Remove(SelectedOrder);
            }, obj => SelectedOrder != null);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    public class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;
        public event EventHandler CanExecuteChanged { add => CommandManager.RequerySuggested += value; remove => CommandManager.RequerySuggested -= value; }
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null) { _execute = execute; _canExecute = canExecute; }
        public bool CanExecute(object parameter) => _canExecute == null || _canExecute(parameter);
        public void Execute(object parameter) => _execute(parameter);
    }
}
