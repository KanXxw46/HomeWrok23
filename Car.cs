using System;
using System.Collections.Generic;
using System.Text;

namespace Hw23
{
    public enum CarType
    {
        Bus, Truck, Tractor
    }
    public interface IType
    {
        void ISwitchOn();
        void ISwitchOff();
        void SwitchOn();
    }

    public class Bus : IType
    {
        public void ISwitchOff()
        {
            Console.WriteLine("TableFan Switched Off");
        }

        public void ISwitchOn()
        {
            Console.WriteLine("TableFan Switched On");
        }

    }
    public class Truck : IType
    {
        public void ISwitchOff()
        {
            Console.WriteLine("PCFan Switched Off");
        }

        public void ISwitchOn()
        {
            Console.WriteLine("PCFan Switched On");
        }

    }
    public class Tractor : IType
    {
        public void ISwitchOff()
        {
            Console.WriteLine("HairFan Switched Off");
        }

        public void ISwitchOn()
        {
            Console.WriteLine("HairFan Switched On");
        }

    }
    public interface ITypeFactory
    {
        IType CreateFan(FaneType typeType);
    }

    public class FanFactory : ITypeFactory
    {
        public IType CreateFan(FaneType fanType)
        {
            switch (fanType)
            {
                case FanType.TableFan:
                    return new Bus();
                case FanType.PCFan:
                    return new Truck();
                case FanType.HairFan:
                    return new Tractor();
                default:
                    return new Bus();
            }
        }
    }
}
