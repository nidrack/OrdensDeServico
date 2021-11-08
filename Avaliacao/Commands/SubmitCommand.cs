using Avaliacao.Exceptions;
using Avaliacao.Models;
using Avaliacao.Services;
using Avaliacao.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Avaliacao.Commands
{
    public class SubmitCommand : CommandBase
    {
        private readonly CreateOrderViewModel _createOrderViewModel;
        private readonly Company _company;
        private readonly NavigationService _orderViewNavigationService;

        public SubmitCommand(CreateOrderViewModel createOrderViewModel,
            Company company,
            NavigationService orderViewNavigationService)
        {
            _createOrderViewModel = createOrderViewModel;
            _company = company;
            _orderViewNavigationService = orderViewNavigationService;
            _createOrderViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        private void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(CreateOrderViewModel.Cod))
            {
                OnCanExecutedChanged();
            }
        }

        public override bool CanExecute(object parameter)
        {
            return !string.IsNullOrEmpty(_createOrderViewModel.Cod) && base.CanExecute(parameter);
        }
        public override void Execute(object parameter)
        {
            OrderService order = new OrderService(
                _createOrderViewModel.Id,
                _createOrderViewModel.Cod,
                _createOrderViewModel.InitialDate,
                _createOrderViewModel.ServicePrice,
                _createOrderViewModel.TravelPrice,
                _createOrderViewModel.City,
                _createOrderViewModel.Type);
            try
            {
                _company.CreateOrderService(order);
                MessageBox.Show("Ordem criada com sucesso",
                    "Sucesso",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                _orderViewNavigationService.Navigate();
            }
            catch (ExistingOrderException)
            {
                MessageBox.Show("Essa ordem de serviço já foi cadastrada",
                    "Erro",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }

        }
    }
}
