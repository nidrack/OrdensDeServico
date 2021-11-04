using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao.ViewModels
{
    class MainViewModel : BindableBase 
    {
        public BindableBase CurrentViewModel { get; }

        public MainViewModel()
        {
            CurrentViewModel = new ListOrderViewModel();
        }
    }
}
