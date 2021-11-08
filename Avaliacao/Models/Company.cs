using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao.Models
{
    public class Company
    {
        private readonly Costumer _costumer;
        public string Name { get; }
        public Company(string name)
        {
            Name = name;
            _costumer = new Costumer();
        }

        //public IEnumerable<OrderService> GetOrderByInspector(string inspectorName)
        //{
        //    return _costumer.GetOrderByInspector(inspectorName);
        //}
        public IEnumerable<OrderService> GetAllOrderServices()
        {
            return _costumer.GetAllOrders();
        }

        public void CreateOrderService (OrderService order)
        {
            _costumer.AddOrder(order);
        }
    }
}
