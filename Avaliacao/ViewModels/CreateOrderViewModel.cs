using Avaliacao.Commands;
using Avaliacao.Models;
using Avaliacao.Models.Enums;
using Avaliacao.Services;
using Avaliacao.Stores;
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
                OnPriceChanged();
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
                OnPriceChanged();
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
                OnDateChanged();
                OnPropertyChanged(nameof(InitialDate));
            }
        }
        private double _totalPrice;
        public double TotalPrice
        {
            get
            {
                return _totalPrice;
            }
            set
            {
                _totalPrice = value;
                OnPropertyChanged(nameof(TotalPrice));
            }
        }
        private string _finalDate;
        public string FinalDate
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
        private void OnDateChanged()
        {
            FinalDate = InitialDate.AddDays(7).ToString("d");
        }
        private void OnPriceChanged()
        {
            CalculateTotal();
        }
        private void CalculateTotal()
        {
            TotalPrice = ServicePrice + TravelPrice;
        }

        public ICommand SubmitCommand { get; }
        public ICommand ListOrderCommand { get; }
        public CreateOrderViewModel(Company company, NavigationService orderViewNavigationService)
        {
            SubmitCommand = new SubmitCommand(this, company, orderViewNavigationService);
            ListOrderCommand = new NavigateCommand(orderViewNavigationService);
        }

    }
}
