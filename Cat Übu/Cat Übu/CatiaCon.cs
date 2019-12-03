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
    class CatiaCon
    {
        public bool CatiaLäuft()
        {
            object co = System.Runtime.InteropServices.Marshal.GetActiveObject("Catia.Application");
            INFITF.Application catApp = (INFITF.Application)co;
            return true;
        }
    }

    
}
