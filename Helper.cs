using Probnik.Context;
using Probnik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probnik
{
    internal class Helper
    {
        public static KlimBaseContext DataObj = new KlimBaseContext();
        public static List<Product> Basket = new List<Product>();
    }
}