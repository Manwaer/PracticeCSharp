using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace OnlineShop
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Order> Orders { get; set; } = new ObservableCollection<Order>();
        public ICommand AddOrderCommand { get; }
        public ICommand EditOrderCommand { get; }
        public ICommand DeleteOrderCommand { get; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            OrdersGrid.ItemsSource = Orders;

            AddOrderCommand = new RelayCommand(obj => {
                var win = new CreateWindow(this);
                win.ShowDialog();
            });

            EditOrderCommand = new RelayCommand(obj => {
                var selected = OrdersGrid.SelectedItem as Order;
                var win = new CreateWindow(this, selected);
                win.ShowDialog();
                OrdersGrid.Items.Refresh();
            }, obj => OrdersGrid.SelectedItem != null);

            DeleteOrderCommand = new RelayCommand(obj => {
                if (MessageBox.Show("Удалить выбранный заказ?", "Вопрос", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    Orders.Remove(OrdersGrid.SelectedItem as Order);
                }
            }, obj => OrdersGrid.SelectedItem != null);
        }

        private void OnFilterChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OrdersGrid == null) return;
            string status = (StatusFilter.SelectedItem as ComboBoxItem).Content.ToString();
            if (status == "Все") OrdersGrid.ItemsSource = Orders;
            else OrdersGrid.ItemsSource = Orders.Where(x => x.Status == status).ToList();
        }

        private void OnExitClick(object sender, RoutedEventArgs e) => Close();
    }
}
