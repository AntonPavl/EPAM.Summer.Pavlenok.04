using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_DifferentViews
{
    public class Customer 
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public decimal Revenue { get; set; }
        public Customer(string name = "",string phone = "",decimal revenue = decimal.Zero)
        {
            Name = name;
            Phone = phone;
            Revenue = revenue;
        }

        public string ToString(string format)
        {
            return String.Format(format, Name, Phone, Revenue);
        }
        /// <summary>
        /// Get String
        /// </summary>
        /// <param name="format">Output format: 0-Name,1-Phone,2-Revenue</param>
        /// <returns></returns>
        public string ToString(string format,params object[] arg) //не то
        {
            if (arg == null) throw new ArgumentNullException();
            if (arg.Length > 3) throw new ArgumentOutOfRangeException();
            return String.Format(format, arg[0],arg[1] = "1",arg[2] = "2"); //изменить
        }
    }
}
