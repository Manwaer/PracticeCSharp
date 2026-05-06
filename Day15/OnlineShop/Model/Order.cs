using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace OnlineShop
{
    public class Order : INotifyPropertyChanged
    {
        private int _id;
        private string _client;
        private string _status;
        private decimal _amount;

        public int Id
        {
            get => _id;
            set { _id = value; OnPropertyChanged(); }
        }

        public string Client
        {
            get => _client;
            set { _client = value; OnPropertyChanged(); }
        }

        public string Status
        {
            get => _status;
            set { _status = value; OnPropertyChanged(); }
        }

        public decimal Amount
        {
            get => _amount;
            set { _amount = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
