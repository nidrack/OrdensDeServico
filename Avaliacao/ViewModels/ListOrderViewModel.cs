using Avaliacao.Commands;
using Avaliacao.Models;
using Avaliacao.Services;
using Avaliacao.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Avaliacao.ViewModels
{
    public class ListOrderViewModel : BindableBase
    {
        private readonly ObservableCollection<OrderServiceViewModel> _orders;
        private readonly Company _company;
        public IEnumerable<OrderServiceViewModel> Orders => _orders;
        public ICommand MakeOrderCommand { get; }
        public ICommand EditOrderCommand { get; }
        public ICommand RemoveOrderCommand { get; }

        public ListOrderViewModel(Company company, NavigationService listOrderViewNavigationService)
        {
            MakeOrderCommand = new NavigateCommand(listOrderViewNavigationService);
            EditOrderCommand = new NavigateCommand(listOrderViewNavigationService);
            RemoveOrderCommand = new RemoveOrderCommand();

            _company = company;
            _orders = new ObservableCollection<OrderServiceViewModel>();

            UpdateOrders();

            //_orders.Add(new OrderServiceViewModel(new OrderService(01, "7375.0301.0002300232", new DateTime(2021, 10, 06), 430, 37, "Goiania", Models.Enums.OrderServiceType.A413)));
            //_orders.Add(new OrderServiceViewModel(new OrderService(02, "7375.0301.0002312232", new DateTime(2021, 10, 07), 367, 37, "Goiania", Models.Enums.OrderServiceType.A414)));
            //_orders.Add(new OrderServiceViewModel(new OrderService(03, "7375.0301.0002354232", new DateTime(2021, 10, 08), 367, 37, "Goiania", Models.Enums.OrderServiceType.A414)));
            //_orders.Add(new OrderServiceViewModel(new OrderService(04, "7375.0301.0002320232", new DateTime(2021, 10, 09), 350, 37, "Goiania", Models.Enums.OrderServiceType.A412)));
        }

        private void UpdateOrders()
        {
            _orders.Clear();
            foreach (var item in _company.GetAllOrderServices())
            {
                OrderServiceViewModel orderServiceViewModel = new OrderServiceViewModel(item);
                _orders.Add(orderServiceViewModel);
            }
        }
    }
}
