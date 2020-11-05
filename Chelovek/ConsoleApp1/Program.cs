using System;
using Chelovek;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Chelovek1 gosha = new Chelovek1();
            /*gosha.TellName();
            Console.WriteLine(gosha.age);*/

            /*gosha.name = "Gosha";
            gosha.age = 7;
            gosha.TellName();

            Chelovek1 petia = new Chelovek1();
            petia.name = "Petia";
            petia.age = 7;
            petia.TellName();
            petia.AskName(gosha);*/
            /*  Chelovek1 gosha = new Chelovek1();
              gosha.GetPulse();
              gosha.Run(15);
              gosha.pulse = 0;
              gosha.GetPulse();*/
            Chelovek1 gosha = new Chelovek1("gosha", 10);
            gosha.TellName();
            Console.WriteLine(gosha.Name);
            gosha.Age = 144;
            Console.WriteLine(gosha.Age);


        }
    }
}
