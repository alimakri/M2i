using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoIoc
{
    class Program
    {
        static void Main(string[] args)
        {
            var velo = new Velo();
            var auto = new Auto();

            var a7 = new Autoroute(auto);
            a7.V.Roule();
            Console.ReadLine();
        }
    }
    class Autoroute
    {
        public Autoroute(IVehicule v)
        {
            V = v;
        }
        public IVehicule V;
    }
    interface IVehicule
    {
        void Roule();
    }
    class Auto : IVehicule
    {
        public void Roule()
        {
            Console.WriteLine("L'auto roule");
        }
    }
    class Velo : IVehicule
    {
        public void Roule()
        {
            Console.WriteLine("Le vélo roule");
        }
    }
}
