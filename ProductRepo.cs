using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ProductRepo: IProductRepo
    {
        public string GetSomethingFromProduct()
        {
            return "Hello! This is Product Repository";
        }

    }
}
