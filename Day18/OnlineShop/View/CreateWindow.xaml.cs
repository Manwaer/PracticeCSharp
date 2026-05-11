using OnlineShop.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace OnlineShop
{
    public partial class CreateWindow : Window
    {
        private readonly Order _existing;

        public Order ResultOrder { get; private set; }

        public CreateWindow(MainWindowViewModel vm, Order existing = null)
        {
            InitializeComponent();
            _existing = existing;

            if (_existing != null)
            {
                TxtClient.Text = _existing.Client;
                TxtAmount.Text = _existing.Amount.ToString();
                TxtDetails.Text = _existing.Details;

                foreach (ComboBoxItem item in CbStatus.Items)
                {
                    if (item.Content?.ToString() == _existing.Status)
                    {
                        CbStatus.SelectedItem = item;
                        break;
                    }
                }
            }

            if (CbStatus.SelectedItem == null)
                CbStatus.SelectedIndex = 0;
        }

        private void OnSaveClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtClient.Text))
            {
                MessageBox.Show("Введите имя клиента");
                return;
            }

            if (CbStatus.SelectedItem is not ComboBoxItem selectedItem)
            {
                MessageBox.Show("Выберите статус");
                return;
            }

            string status = selectedItem.Content.ToString();
            decimal.TryParse(TxtAmount.Text, out decimal amount);

            if (_existing != null)
            {
                _existing.Client = TxtClient.Text;
                _existing.Status = status;
                _existing.Amount = amount;
                _existing.Details = TxtDetails.Text;

                ResultOrder = _existing;
            }
            else
            {
                ResultOrder = new Order
                {
                    Client = TxtClient.Text,
                    Status = status,
                    Amount = amount,
                    Details = TxtDetails.Text
                };
            }

            DialogResult = true;
            Close();
        }

        private void OnCancelClick(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}