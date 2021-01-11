using System;

namespace Hw23
{
    class Program
    {
        static void Main(string[] args)
        {
            ITypeFactory MySimpleFanFactory = new FanFactory();
            IType fan = MySimpleFanFactory.CreateFan(FanType.OfficeFan);
            fan.ISwitchOff();
            
            Console.ReadLine();
            Bus bus = new Bus();
             fan.SwitchOn();
        }
    }
}
