using OnlineShop.Data;
using OnlineShop.Services;
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
        private readonly AppDbContext _context;
        private readonly OrderRepository _orderRepository;
        private readonly ChatService _chatService;

        public ObservableCollection<Order> Orders { get; set; }
        public ICollectionView OrdersView { get; set; }

        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                OnPropertyChanged(nameof(IsBusy));
            }
        }

        private Order _selectedOrder;
        public Order SelectedOrder
        {
            get => _selectedOrder;
            set
            {
                _selectedOrder = value;
                OnPropertyChanged(nameof(SelectedOrder));
            }
        }

        private string _selectedStatusFilter = "Все";
        public string SelectedStatusFilter
        {
            get => _selectedStatusFilter;
            set
            {
                _selectedStatusFilter = value;
                OnPropertyChanged(nameof(SelectedStatusFilter));
                OrdersView?.Refresh();
            }
        }

        private string _chatLog = "";
        public string ChatLog
        {
            get => _chatLog;
            set
            {
                _chatLog = value;
                OnPropertyChanged(nameof(ChatLog));
            }
        }

        private string _chatInput;
        public string ChatInput
        {
            get => _chatInput;
            set
            {
                _chatInput = value;
                OnPropertyChanged(nameof(ChatInput));
            }
        }

        public ICommand AddOrderCommand { get; }
        public ICommand EditOrderCommand { get; }
        public ICommand DeleteOrderCommand { get; }
        public ICommand SendChatCommand { get; }
        public ICommand ChangeStatusCommand { get; }

        public MainWindowViewModel()
        {
            _context = new AppDbContext();
            _context.Database.EnsureCreated();

            _orderRepository = new OrderRepository(_context);
            _chatService = new ChatService();

            Orders = new ObservableCollection<Order>();
            OrdersView = CollectionViewSource.GetDefaultView(Orders);
            OrdersView.Filter = FilterOrders;

            _chatService.OnMessageReceived += (msg) =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    ChatLog += $"[{DateTime.Now:HH:mm}] {msg}\n";
                });
            };
            _chatService.StartListening();

            AddOrderCommand = new RelayCommand(async _ => await AddOrderAsync());
            EditOrderCommand = new RelayCommand(async _ => await EditOrderAsync(), _ => SelectedOrder != null);
            DeleteOrderCommand = new RelayCommand(async _ => await DeleteOrderAsync(), _ => SelectedOrder != null);
            ChangeStatusCommand = new RelayCommand(async obj => await ChangeStatusAsync(obj));
            SendChatCommand = new RelayCommand(async _ => await SendChatAsync(), _ => !string.IsNullOrWhiteSpace(ChatInput));

            _ = LoadOrdersAsync();
        }

        private bool FilterOrders(object obj)
        {
            if (obj is not Order order)
                return false;

            if (SelectedStatusFilter == "Все")
                return true;

            return order.Status == SelectedStatusFilter;
        }

        private async Task LoadOrdersAsync()
        {
            try
            {
                IsBusy = true;

                var ordersFromDb = await _orderRepository.GetAllOrdersAsync();

                Application.Current.Dispatcher.Invoke(() =>
                {
                    Orders.Clear();
                    foreach (var order in ordersFromDb)
                        Orders.Add(order);

                    OrdersView.Refresh();
                });
            }
            finally
            {
                IsBusy = false;
            }
        }

        private async Task AddOrderAsync()
        {
            var win = new CreateWindow(this);
            if (win.ShowDialog() == true && win.ResultOrder != null)
            {
                try
                {
                    IsBusy = true;

                    await _context.Orders.AddAsync(win.ResultOrder);
                    await _context.SaveChangesAsync();   // <- вот оно, обязательное сохранение

                    Orders.Add(win.ResultOrder);
                    OrdersView.Refresh();

                    StoreService.SendMmfNotify("OrderCreated");
                }
                finally
                {
                    IsBusy = false;
                }
            }
        }

        private async Task EditOrderAsync()
        {
            if (SelectedOrder == null)
                return;

            var win = new CreateWindow(this, SelectedOrder);
            if (win.ShowDialog() == true)
            {
                try
                {
                    IsBusy = true;

                    _context.Orders.Update(SelectedOrder);
                    await _context.SaveChangesAsync();

                    OrdersView.Refresh();
                }
                finally
                {
                    IsBusy = false;
                }
            }
        }

        private async Task ChangeStatusAsync(object obj)
        {
            if (obj is not Order order)
                return;

            var win = new CreateWindow(this, order);
            if (win.ShowDialog() == true)
            {
                try
                {
                    IsBusy = true;

                    _context.Orders.Update(order);
                    await _context.SaveChangesAsync();

                    OrdersView.Refresh();
                }
                finally
                {
                    IsBusy = false;
                }
            }
        }

        private async Task DeleteOrderAsync()
        {
            if (SelectedOrder == null)
                return;

            if (MessageBox.Show("Удалить заказ?", "Вопрос", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                try
                {
                    IsBusy = true;

                    _context.Orders.Remove(SelectedOrder);
                    await _context.SaveChangesAsync();   // <- обязательное сохранение

                    Orders.Remove(SelectedOrder);
                    OrdersView.Refresh();
                }
                finally
                {
                    IsBusy = false;
                }
            }
        }

        private async Task SendChatAsync()
        {
            if (string.IsNullOrWhiteSpace(ChatInput))
                return;

            string msg = ChatInput;
            ChatInput = string.Empty;
            ChatLog += $"[Вы]: {msg}\n";
            await StoreService.SendChatMessage(msg);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string n)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(n));
        }
    }
}