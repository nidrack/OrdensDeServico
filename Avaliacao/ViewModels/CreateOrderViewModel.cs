using Avaliacao.Commands;
using Avaliacao.Models;
using Avaliacao.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Avaliacao.ViewModels
{
    public class CreateOrderViewModel : BindableBase
    {
        private readonly OrderService _orderService;

        private int _id;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }
        private string _cod;
        public string Cod
        {
            get
            {
                return _cod;
            }
            set
            {
                _cod = value;
                OnPropertyChanged(nameof(Cod));
            }
        }
        public Array enumList => Enum.GetValues(typeof(OrderServiceType));

        private OrderServiceType _type;
        public OrderServiceType Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = (OrderServiceType)value;
                OnPropertyChanged(nameof(Type));
            }
        }

        private double _servicePrice;
        public double ServicePrice
        {
            get
            {
                return _servicePrice;
            }
            set
            {
                _servicePrice = value;
                OnPropertyChanged(nameof(ServicePrice));
            }
        }

        private double _travelPrice;
        public double TravelPrice
        {
            get
            {
                return _travelPrice;
            }
            set
            {
                _travelPrice = value;
                OnPropertyChanged(nameof(TravelPrice));
            }
        }

        private string _city;
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
                OnPropertyChanged(nameof(City));
            }
        }

        private DateTime _initialdate = DateTime.Now;
        public DateTime InitialDate
        {
            get
            {
                return _initialdate;
            }
            set
            {
                _initialdate = value;
                OnPropertyChanged(nameof(InitialDate));
            }
        }
        private double _totalValue ;
        public double TotalValue
        {
            get
            {
                return _totalValue;
            }
            set
            {
                _totalValue = value;
                OnPropertyChanged(nameof(TotalValue));
            }
        }
        private DateTime _finalDate;
        public DateTime FinalDate
        {
            get
            {
                return _finalDate;
            }
            set
            {
                _finalDate = value;
                OnPropertyChanged(nameof(FinalDate));
            }
        }

        public ICommand SubmitCommand { get; }
        public CreateOrderViewModel(Company company)
        {
            SubmitCommand = new SubmitCommand(this, company);
        }

    }
}
