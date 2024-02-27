using Gerocery.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerocery.data
{
    public class Category1 :BaseViewModel
    {
        public string imageName { get; set; }

        string _name;
        public string name { get => _name; set { _name = value; onpropertyChange(); } }
        public string image { get; set; }
    }
}
