using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLSerializer.Model
{
    public class ResponseModel
    {
        public string Status { get; set; }
        public string SKU { get; set; }
        public decimal Fee { get; set; }
        public decimal Price { get; set; }

        public void ToWriteLineString()
        {
            Console.WriteLine("Status:"+Status+ ",SKU:"+ SKU+ ",Fee:"+ Fee+ ",Price:"+ Price);
        }
    }
}
