using Avaliacao.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Avaliacao.ViewModels
{
    class ListOrderViewModel : BindableBase
    {
        private readonly ObservableCollection<OrderServiceViewModel> _orders;
        public IEnumerable<OrderServiceViewModel> Orders => _orders;
        public ICommand EditOrder { get; }
        public ListOrderViewModel()
        {
            _orders = new ObservableCollection<OrderServiceViewModel>();

            _orders.Add(new OrderServiceViewModel(new OrderService(01, "7375.0301.0002300232", new DateTime(2021, 10, 06), 430, 37, "Goiania", Models.Enums.OSType.A413)));
            _orders.Add(new OrderServiceViewModel(new OrderService(02, "7375.0301.0002312232", new DateTime(2021, 10, 07), 367, 37, "Goiania", Models.Enums.OSType.A414)));
            _orders.Add(new OrderServiceViewModel(new OrderService(03, "7375.0301.0002354232", new DateTime(2021, 10, 08), 367, 37, "Goiania", Models.Enums.OSType.A414)));
            _orders.Add(new OrderServiceViewModel(new OrderService(04, "7375.0301.0002320232", new DateTime(2021, 10, 09), 350, 37, "Goiania", Models.Enums.OSType.A412)));
        }
    }
}
