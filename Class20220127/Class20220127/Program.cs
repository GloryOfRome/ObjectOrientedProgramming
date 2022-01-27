using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220127
{
    class Program
    {
        static void Main(string[] args)
        {
            //ElectricEngine engine = new ElectricEngine();//--XXX--不要new具体的类，要new interface类

            IEngine engine1 = new GasEngine();
            IEngine engine2 = new ElectricEngine();
            IEngine engine3 = new ElectricEngine();
            IEngine engine4 = new DieselEngine();
            IEngine engine5 = new WaterEngine();

            List<IEngine> engines = new List<IEngine>();
            engines.Add(engine1);
            engines.Add(engine2);
            engines.Add(engine3);
            engines.Add(engine4);
            engines.Add(engine5);

            StartAllEngines(engines);

            ICollection<int> list = new List<int>();
            ICollection<int> hs = new HashSet<int>();
            //ICollection<int> st = new Queue<int>();//不可用于Stack和queue

            AddToCollection(list, 9);
            AddToCollection(hs, 10);
        }

        public static void StartAllEngines(List<IEngine> engines)
        {
            foreach (var engine in engines)
            {
                engine.StartEngine();
            }
        }

        public static void AddToCollection(ICollection<int> collection,int item)
        {
            collection.Add(item);
        }

        //public static void StartAllEngines(List<ElectricEngine> engines)
        //{
        //    foreach (var engine in engines)
        //    {
        //        engine.StartEngine();
        //    }
        //}

        //public static void StartAllEngines(List<GasEngine> engines)
        //{
        //    foreach (var engine in engines)
        //    {
        //        engine.StartEngine();
        //    }
        //}
    }
}
