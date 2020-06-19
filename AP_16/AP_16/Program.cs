using AP_16.DelegateApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_16
{
    class Program
    {
        

        static void Main(string[] args)
        {
            
            VD2();
            VD3();
            Console.ReadKey();
        }

        static void VD1() 
        { 
            NumberChanger nc1 = new NumberChanger(TestDelegate.AddNum);
            NumberChanger nc2 = new NumberChanger(TestDelegate.MultNum);

            nc1(25);
            Console.WriteLine("Value of Num: {0}", TestDelegate.getNum());
            nc2(5);
            Console.WriteLine("Value of Num: {0}", TestDelegate.getNum());

        }

        static void VD2()
        {
            NumberChanger nc;
            NumberChanger nc1 = new NumberChanger(TestDelegate.AddNum);
            NumberChanger nc2 = new NumberChanger(TestDelegate.MultNum);

            nc = nc1;
            nc += nc2;

            nc(5);
            Console.WriteLine("Value of Num: {0}", TestDelegate.getNum());

        }

        static void VD3()
        {
            PrintString.printString ps1 = new PrintString.printString(PrintString.WriteToScreen);
            PrintString.printString ps2 = new PrintString.printString(PrintString.WriteToFile);
            PrintString.sendString(ps1);
            PrintString.sendString(ps2);
        }

    }
}
