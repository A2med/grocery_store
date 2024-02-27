using Gerocery.ViewModels;
using Java.Util;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerocery.data
{
   public static class consData 
    {
        public static ObservableCollection<Category2> LstItems { get; set; } = new ObservableCollection<Category2>();
    }
}
