using OnlineShop.ViewModel;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

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
                TxtClient.Text = _existing.Client;
                TxtAmount.Text = _existing.Amount.ToString();
                foreach (ComboBoxItem item in CbStatus.Items)
                {
                    if (item.Content.ToString() == _existing.Status)
                        CbStatus.SelectedItem = item;
                }
            }
            else
            {
                CbStatus.SelectedIndex = 0;
            }
        }

        private void OnSaveClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtClient.Text)) return;

            string status = (CbStatus.SelectedItem as ComboBoxItem).Content.ToString();
            decimal.TryParse(TxtAmount.Text, out decimal amount);

            if (_existing != null)
            {
                _existing.Client = TxtClient.Text;
                _existing.Status = status;
                _existing.Amount = amount;
            }
            else
            {
                int newId = _vm.Orders.Count > 0 ? _vm.Orders.Max(x => x.Id) + 1 : 1;
                _vm.Orders.Add(new Order { Id = newId, Client = TxtClient.Text, Status = status, Amount = amount });
            }

            DialogResult = true;
            Close();
        }

        private void OnCancelClick(object sender, RoutedEventArgs e) => Close();
    }
}
