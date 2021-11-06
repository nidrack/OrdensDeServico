using Avaliacao.Models;
using Avaliacao.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao.ViewModels
{
    public class OrderServiceViewModel : BindableBase
    {
        private readonly OrderService _orderService;
        public int Id => _orderService.Id;
        public string Cod => _orderService.Cod;
        public string InitialDate => _orderService.InitialDate.ToString("d");
        public double ServicePrice => _orderService.ServicePrice;
        public double TravelPrice => _orderService.TravelPrice;
        public string City => _orderService.City;
        public OrderServiceType Type => _orderService.Type;

        public OrderServiceViewModel(Models.OrderService orderService)
        {
            _orderService = orderService;
        }
    }
}
