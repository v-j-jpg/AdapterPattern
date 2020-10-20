using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZivotinjskoCarstvo;

namespace Zivotinje
{
    class Program
    {
        static void Main(string[] args)
        { TableEntity=

            Konj l1 = new Konj();
            Svinja l2 = new Svinja();

            Labud labud = new Labud();
            Vrabac vrabac = new Vrabac();

            Adapter l3 = new Adapter(labud);
            Adapter l4 = new Adapter(vrabac);


            l1.OglasiSe();
            l3.OglasiSe();
            l4.OglasiSe();
            l2.OglasiSe();

      

            Console.ReadKey();


        }
    }
}
