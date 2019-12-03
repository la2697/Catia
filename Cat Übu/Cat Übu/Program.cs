using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INFITF;
using MECMOD;
using PARTITF;
namespace Cat_Übu
{
    class Program
    {
        Program()
        {
            CatiaCon CK = new CatiaCon();
            CK.CatiaLäuft();
        }

        static void Main(string[] args)
        {
            new Program();
        }
    }
}
