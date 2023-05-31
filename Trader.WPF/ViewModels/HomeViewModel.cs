using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trader.WPF.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public MajorIndexViewerViewModel MajorIndexViewModel { get; set; }

        public HomeViewModel(MajorIndexViewerViewModel majorIndexViewModel)
        {
            MajorIndexViewModel = majorIndexViewModel;
        }
    }
}
