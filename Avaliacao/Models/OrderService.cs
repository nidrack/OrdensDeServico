using Avaliacao.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao.Models
{
    public class OrderService
    {
        public int Id { get; set; }
        public string Cod { get; set; }
        public DateTime InitialDate { get; set; }
        public double ServicePrice { get; set; }
        public double TravelPrice { get; set; }
        public string City { get; set; }
        public OSType Type { get; set; }
        public double TotalPrice => ServicePrice + TravelPrice;
        public DateTime FinalDate => InitialDate.AddDays(7);
        public OrderService(int id, string cod, DateTime initialDate, double servicePrice, double travelPrice, string city, OSType type)
        {
            Id = id;
            Cod = cod;
            InitialDate = initialDate;
            ServicePrice = servicePrice;
            TravelPrice = travelPrice;
            City = city;
            Type = type;
        }
        /// <summary>
        /// Support method that verifies if the cod from inserted by user corresponds
        /// Check the use in Costumer
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public bool Conflicts(OrderService order) => order.Cod.Equals(Cod);
    }
}
