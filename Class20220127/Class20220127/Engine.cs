using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220127
{
    interface IEngine
    {
        void StartEngine();
        void StopEngine();
        bool IsRunning();
    }
    interface IEngineInspection//发动机检查
    {
        int CheckStatus(int levelOfInspection);//检查级别
    }
    class GasEngine : IEngine,IEngineInspection//汽油引擎
    {
        public int CheckStatus(int levelOfInspection)
        {
            //里面可以放任何代码，但是需要注意返回值类型
            return 0;
        }

        public bool IsRunning()
        {
            return true;
        }

        public void StartEngine()
        {
            Console.WriteLine("Starting the Gas Engine");
        }

        public void StopEngine()
        {
            Console.WriteLine("Stopping the Gas Engine");
        }
    }
    class ElectricEngine : IEngine,IEngineInspection//电引擎
    {
        public int CheckStatus(int levelOfInspection)
        {
            return 1;
        }

        public bool IsRunning()
        {
            return true;
        }

        public void StartEngine()
        {
            Console.WriteLine("Starting the Electric Engine");
        }

        public void StopEngine()
        {
            Console.WriteLine("Stopping the Electric Engine");
        }
    }
    class DieselEngine : IEngine//柴油发动机
    {
        public bool IsRunning()
        {
            return true;
        }

        public void StartEngine()
        {
            Console.WriteLine("Starting the Diesel Engine");
        }

        public void StopEngine()
        {
            Console.WriteLine("Stopping the Diesel Engine");
        }
    }
    class WaterEngine : IEngine//水机
    {
        public bool IsRunning()
        {
            throw new NotImplementedException();
        }

        public void StartEngine()
        {
            Console.WriteLine("Starting the Water Engine");
        }

        public void StopEngine()
        {
            Console.WriteLine("Stopping the Water Engine");
        }
    }
}
