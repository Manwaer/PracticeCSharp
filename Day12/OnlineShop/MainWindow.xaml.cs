using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OnlineShop
{
    public partial class MainWindow : Window
    {
        public List<Order> AllOrders { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            AllOrders = new List<Order>
            {
                new Order { Id = 1, Client = "Иван Иванов", Status = "Новый", Amount = 15400 },
                new Order { Id = 2, Client = "ООО 'Вектор'", Status = "Оплачен", Amount = 45000 },
                new Order { Id = 3, Client = "Анна Смирнова", Status = "Доставлен", Amount = 2300 },
                new Order { Id = 4, Client = "Петр Петров", Status = "Новый", Amount = 8900 }
            };

            OrdersGrid.ItemsSource = AllOrders;
        }

        private void StatusFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OrdersGrid == null) return;

            var selectedItem = (ComboBoxItem)StatusFilter.SelectedItem;
            string status = selectedItem.Content.ToString();

            if (status == "Все")
                OrdersGrid.ItemsSource = AllOrders;
            else
                OrdersGrid.ItemsSource = AllOrders.Where(x => x.Status == status).ToList();
        }
    }

    public class Order
    {
        public int Id { get; set; }
        public string Client { get; set; }
        public string Status { get; set; }
        public decimal Amount { get; set; }
    }
}
