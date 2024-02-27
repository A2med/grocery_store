using Gerocery.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerocery.data
{
    public class OrderData:BaseViewModel
    {

        public OrderData()
        {
            item = new List<Item>();
        }
        public string ItemName { get; set; }
        public int ItemId { get; set; }
        public int InvoiceId { get; set; }
        public string Notes { get; set; }
        public string CustomarId { get; set; }
        public List<Item> item { get; set; }
    }
    public class Item : BaseViewModel
    {
        public string ItemName { get; set; }
        public int ItemId { get; set; }
        int _Qty;
        public int Qty { get => _Qty; set { _Qty = value; onpropertyChange(); } }
    }
}
