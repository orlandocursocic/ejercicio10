using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio10
{
    public class FicheroService
    {

        public void GuardaNumero(int c)
        {
            FicheroUtil ficheroUtil = new FicheroUtil();

            ficheroUtil.AlmacenarDatos(c, "miFichero.txt");
        }
    }
}
