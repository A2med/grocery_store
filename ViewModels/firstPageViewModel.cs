
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Gerocery.ViewModels
{
   public class firstPageViewModel
    {
        public ICommand Btn { get; set; }

        public firstPageViewModel()
        {
            Btn = new Command(onBtn);
        }
        public async void onBtn()
        {
            await Shell.Current.GoToAsync("login/items");
        }
    }
}
