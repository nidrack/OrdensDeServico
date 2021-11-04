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
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel()
            };
            MainWindow.Show();
            //// TESTING
            //Company company = new Company("Caixa");
            //Inspector thiago = new Inspector(1, "Thiago");

            //try
            //{
            //    company.CreateOrderService(
            //        new OrderService(thiago, 1, "7375.0000222500", new DateTime(2021, 10, 20), 430, 37, "Goiânia", Models.Enums.OSType.A413));
            //    company.CreateOrderService(
            //        new OrderService(thiago, 1, "7375.0000222500", new DateTime(2021, 10, 21), 380, 37, "Goiânia", Models.Enums.OSType.A414));
            //    company.CreateOrderService(
            //        new OrderService(thiago, 1, "7375.0000250388", new DateTime(2021, 10, 22), 380, 37, "Goiânia", Models.Enums.OSType.A414));
            //}
            //catch (ExistingOrderException ex)
            //{
            //    Console.WriteLine(ex.StackTrace);
            //}
            //IEnumerable<OrderService> orders = company.GetOrderByInspector(thiago.Name);


            base.OnStartup(e);
        }
    }
}
