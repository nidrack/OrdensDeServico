using Avaliacao.Exceptions;
using Avaliacao.Models;
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
        public App()
        {
            _company = new Company("E4P Engenharia");
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_company)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
