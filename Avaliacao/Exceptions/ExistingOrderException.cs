using Avaliacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao.Exceptions
{
    public class ExistingOrderException : Exception
    {
        public OrderService ExistingOrder { get; }
        public OrderService IncomingOrder { get; }
        public ExistingOrderException(OrderService existingOrder, OrderService incomingOrder)
        {
            ExistingOrder = existingOrder;
            IncomingOrder = incomingOrder;
        }

        public ExistingOrderException(string message, OrderService existingOrder, OrderService incomingOrder) : base(message)
        {
            ExistingOrder = existingOrder;
            IncomingOrder = incomingOrder;
        }

        public ExistingOrderException(string message, Exception innerException, OrderService existingOrder, OrderService incomingOrder) : base(message, innerException)
        {
            ExistingOrder = existingOrder;
            IncomingOrder = incomingOrder;
        }

        protected ExistingOrderException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
