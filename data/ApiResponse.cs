using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.Maui.Controls.Internals.Profile;

namespace Gerocery.data
{
    public class ApiResponse<t>
    {
        public List<t> data { get; set; }
        public object errors { get; set; }
        public string statusCode { get; set; }
    }

    public class ApiObjectResponse<t>
    {
        public t data { get; set; }
        public object errors { get; set; }
        public string statusCode { get; set; }
    }
}
