using Gerocery.ViewModels;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerocery.data
{
    public class Category2:BaseViewModel
    {
        int _id;
       // [PrimaryKey]
        public int id { get=>_id; set { _id = value;onpropertyChange(); } }
        string _itemname;
        public string ItemName { get=>_itemname; set { _itemname = value;onpropertyChange(); }  }
        public string Image { get; set; }

        
        public decimal salary { get; set; }

        int _Qty;
        public int Qty { get => _Qty; set { _Qty = value;onpropertyChange(); } }

       

       // class api
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        //public string createdBy { get; set; }
        //public DateTime createdDate { get; set; }
        //public int currentState { get; set; }
      
        //public bool showInHomePage { get; set; }
        //public object updatedBy { get; set; }
        //public object updatedDate { get; set; }
        //public List<object> tbItems { get; set; }
    }
    
}
