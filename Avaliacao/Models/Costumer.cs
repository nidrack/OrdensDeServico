using Avaliacao.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao.Models
{
    public class Costumer
    {
        private readonly List<OrderService> _orders;
        public Costumer()
        {
            _orders = new List<OrderService>();
        }
        /// <summary>
        /// Make a list from selected inspector
        /// </summary>
        /// <param name="inspector"></param>
        /// <returns></returns>
        public IEnumerable<OrderService> GetOrderByInspector(string inspector)
        {
            return _orders
                .Where(x => x.Inspector.Name == inspector);
        }
        /// <summary>
        /// Verifies if an order inserted have the same value in key property in the existing list of orders
        /// Utilize Conflicts() method from OrderService
        /// </summary>
        /// <param name="order">List of OrderService</param>
        public void AddOrder(OrderService order)
        {
            foreach (OrderService existingOrder in _orders)
            {
                if (existingOrder.Conflicts(order))
                {
                    throw new ExistingOrderException(existingOrder, order);
                }
            }
            _orders.Add(order);
        }
    }
}
