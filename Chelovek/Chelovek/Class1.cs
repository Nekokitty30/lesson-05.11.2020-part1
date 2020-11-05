using System;

namespace Chelovek
{
    public class Chelovek1
    {
        private string _mood = "norm";
        /*private string _name;*/
       /* private int _age;*/
        private int _pulse=60;


        public string Mood { get; set; }
        public string Name { get; private set; }

        private int _age;
        public int Age {
            get
            {
                return _age + 10;
            }
                 set
            { if (value <= 114)
                { _age = value; 
                } else
                { throw new Exception(); 
                }
            }
        }

        public Chelovek1(string name,int age)
        {
            Name = name;
            _age = age;
        }
        public void TellName()
        {
            Console.WriteLine(Name);
        }

        public void Run(int km)
        {
            Console.WriteLine("Я бегу");
            _pulse += km;
            Mood = "устал";

        }


        public void Relax(int time)
        {
            Console.WriteLine("Я отдыхаю");
            _pulse -= time;
            Mood = "xorosho";
        }
        public void GetPulse()
        {

            Console.WriteLine(_pulse);
        }
       /* public void AskName(Chelovek1 ch)
        {  Console.WriteLine($"Я-{Name}.Спросил как зовут{ch.name}");

        }*/
    }
}
