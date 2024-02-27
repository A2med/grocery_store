using Gerocery.data;
using Gerocery.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerocery
{
   public static class maindata
    {
        public static ObservableCollection<Category2> lstitems { get; set; } = new ObservableCollection<Category2>();
    }
}
