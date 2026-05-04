using System;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows;

namespace OnlineShop
{
    public partial class CreateWindow : Window
    {
        private MainWindow _main;
        private Order _existing;

        public CreateWindow(MainWindow main, Order existing = null)
        {
            InitializeComponent();
            _main = main;
            _existing = existing;

            if (_existing != null)
            {
                TxtClient.Text = _existing.Client;
                TxtAmount.Text = _existing.Amount.ToString();
                foreach (System.Windows.Controls.ComboBoxItem item in CbStatus.Items)
                {
                    if (item.Content.ToString() == _existing.Status) CbStatus.SelectedItem = item;
                }
            }
            else
            {
                CbStatus.SelectedIndex = 0;
            }
        }

        private void OnSaveClick(object sender, RoutedEventArgs e)
        {
            try
            {
                string client = TxtClient.Text;
                string status = (CbStatus.SelectedItem as System.Windows.Controls.ComboBoxItem).Content.ToString();
                decimal amount = decimal.Parse(TxtAmount.Text);

                if (_existing != null)
                {
                    _existing.Client = client;
                    _existing.Status = status;
                    _existing.Amount = amount;
                }
                else
                {
                    int newId = _main.Orders.Count > 0 ? _main.Orders.Max(x => x.Id) + 1 : 1;
                    _main.Orders.Add(new Order { Id = newId, Client = client, Status = status, Amount = amount });
                }
                Close();
            }
            catch
            {
                MessageBox.Show("Ошибка! Проверьте сумму (число).");
            }
        }
    }
}
