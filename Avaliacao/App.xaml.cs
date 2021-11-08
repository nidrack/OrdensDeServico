using Avaliacao.Exceptions;
using Avaliacao.Models;
using Avaliacao.Services;
using Avaliacao.Stores;
using Avaliacao.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Avaliacao
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly Company _company;
        private readonly NavigationStore _navigationStore;
        public App()
        {
            _company = new Company("E4P Engenharia");
            _navigationStore = new NavigationStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = WindowListOrderViewModel();
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
        private CreateOrderViewModel WindowCreateOrderViewModel()
        {
            return new CreateOrderViewModel(_company, new NavigationService(_navigationStore, WindowListOrderViewModel));
        }

        private ListOrderViewModel WindowListOrderViewModel()
        {
            return new ListOrderViewModel(_company, new NavigationService(_navigationStore, WindowCreateOrderViewModel));
        }
    }
}
