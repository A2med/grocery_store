using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerocery.data
{
    public class categoriapi
    {
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public string createdBy { get; set; }
        public DateTime createdDate { get; set; }
        public int currentState { get; set; }
        public string imageName { get; set; }
        public bool showInHomePage { get; set; }
        public object updatedBy { get; set; }
        public object updatedDate { get; set; }
        public List<object> tbItems { get; set; }
    }
    

}
