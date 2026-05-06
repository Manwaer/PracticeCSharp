using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using OnlineShop.Services;

namespace OnlineShop.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Order> Orders { get; set; }
        public ICollectionView OrdersView { get; set; }

        private bool _isBusy;
        public bool IsBusy { get => _isBusy; set { _isBusy = value; OnPropertyChanged(nameof(IsBusy)); } }

        private Order _selectedOrder;
        public Order SelectedOrder { get => _selectedOrder; set { _selectedOrder = value; OnPropertyChanged(nameof(SelectedOrder)); } }

        private string _selectedStatusFilter = "Все";
        public string SelectedStatusFilter { get => _selectedStatusFilter; set { _selectedStatusFilter = value; OnPropertyChanged(nameof(SelectedStatusFilter)); OrdersView.Refresh(); } }

        private string _chatLog;
        public string ChatLog { get => _chatLog; set { _chatLog = value; OnPropertyChanged(nameof(ChatLog)); } }

        public ICommand AddOrderCommand { get; }
        public ICommand EditOrderCommand { get; }
        public ICommand DeleteOrderCommand { get; }

        private readonly ChatService _chatService;

        public MainWindowViewModel()
        {
            // Загрузка данных из JSON
            Orders = new ObservableCollection<Order>(StoreService.Load());
            OrdersView = CollectionViewSource.GetDefaultView(Orders);
            OrdersView.Filter = obj =>
            {
                if (SelectedStatusFilter == "Все") return true;
                return (obj as Order)?.Status == SelectedStatusFilter;
            };

            // Инициализация чата (Named Pipes Server)
            _chatService = new ChatService();
            _chatService.OnMessageReceived += (msg) =>
            {
                Application.Current.Dispatcher.Invoke(() => ChatLog += $"[{DateTime.Now:HH:mm}] {msg}\n");
            };
            _chatService.StartListening();

            // Команда добавления
            AddOrderCommand = new RelayCommand(async obj =>
            {
                var win = new CreateWindow(this);
                if (win.ShowDialog() == true)
                {
                    IsBusy = true;
                    await Task.Delay(3000); // Имитация обработки
                    StoreService.Save(Orders); // Сохранение в JSON
                    StoreService.SendMmfNotify("OrderCreated"); // Уведомление через MMF
                    IsBusy = false;
                }
            });

            // Команда редактирования
            EditOrderCommand = new RelayCommand(obj =>
            {
                var win = new CreateWindow(this, SelectedOrder);
                if (win.ShowDialog() == true)
                {
                    StoreService.Save(Orders);
                    OrdersView.Refresh();
                }
            }, o => SelectedOrder != null);

            // Команда удаления
            DeleteOrderCommand = new RelayCommand(obj =>
            {
                if (MessageBox.Show("Удалить заказ?", "Вопрос", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    Orders.Remove(SelectedOrder);
                    StoreService.Save(Orders);
                }
            }, o => SelectedOrder != null);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string n) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(n));
    }

    // Вспомогательный класс для команд
    public class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;
        public event EventHandler CanExecuteChanged { add => CommandManager.RequerySuggested += value; remove => CommandManager.RequerySuggested -= value; }
        public RelayCommand(Action<object> e, Func<object, bool> c = null) { _execute = e; _canExecute = c; }
        public bool CanExecute(object p) => _canExecute == null || _canExecute(p);
        public void Execute(object p) => _execute(p);
    }
}
