using OnlineShop.ViewModel;
using System;
using System.Linq;
using System.Windows;

namespace OnlineShop
{
    public partial class CreateWindow : Window
    {
        private MainWindowViewModel _vm;
        private Order _existing;
        
        public CreateWindow(MainWindowViewModel vm, Order existing = null)
        {
            InitializeComponent();
            _vm = vm;
            _existing = existing;

            if (_existing != null)
            {
                Title = "Редактирование заказа";
                TxtClient.Text = _existing.Client;
                TxtAmount.Text = _existing.Amount.ToString();

                foreach (System.Windows.Controls.ComboBoxItem item in CbStatus.Items)
                {
                    if (item.Content.ToString() == _existing.Status)
                        CbStatus.SelectedItem = item;
                }
            }
            else
            {
                Title = "Новый заказ";
                CbStatus.SelectedIndex = 0;
            }
        }

        private void OnSaveClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtClient.Text))
                {
                    MessageBox.Show("Введите имя клиента!");
                    return;
                }

                string client = TxtClient.Text;
                string status = (CbStatus.SelectedItem as System.Windows.Controls.ComboBoxItem).Content.ToString();

                if (!decimal.TryParse(TxtAmount.Text, out decimal amount))
                {
                    MessageBox.Show("Введите корректную сумму!");
                    return;
                }

                if (_existing != null)
                {
                    _existing.Client = client;
                    _existing.Status = status;
                    _existing.Amount = amount;
                }
                else
                {
                    int newId = _vm.Orders.Count > 0 ? _vm.Orders.Max(x => x.Id) + 1 : 1;
                    _vm.Orders.Add(new Order { Id = newId, Client = client, Status = status, Amount = amount });
                }

                DialogResult = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void OnCancelClick(object sender, RoutedEventArgs e) => Close();
    }
}
