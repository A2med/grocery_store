using Gerocery.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerocery.data
{
    public class ItemData:BaseViewModel
    {
        public int itemId { get; set; }

        string _itemName;
        public string itemName { get=>_itemName; set { _itemName = value;{ onpropertyChange(); } } }
        public double salesPrice { get; set; }
        public double purchasePrice { get; set; }
        public int categoryId { get; set; }
        string _imageName;
        public string imageName { get=>_imageName; set { _imageName = value;{ onpropertyChange(); } } }
        public DateTime createdDate { get; set; }
        public string createdBy { get; set; }
        public int currentState { get; set; }
        public object updatedBy { get; set; }
        public object updatedDate { get; set; }
        public object description { get; set; }
        public string gpu { get; set; }
        public string hardDisk { get; set; }
        public int itemTypeId { get; set; }
        public string processor { get; set; }
        public int ramSize { get; set; }
        public string screenReslution { get; set; }
        public string screenSize { get; set; }
        public string weight { get; set; }
        public int osId { get; set; }
        public object category { get; set; }
        public object itemType { get; set; }
        public object os { get; set; }
        public List<object> tbItemDiscounts { get; set; }
        public List<object> tbItemImages { get; set; }
        public List<object> tbPurchaseInvoiceItems { get; set; }
        public List<object> tbSalesInvoiceItems { get; set; }
        public List<object> customers { get; set; }
    }
}
