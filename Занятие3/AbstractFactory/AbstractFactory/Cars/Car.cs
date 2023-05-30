using AbstractFactory.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Cars
{
    public abstract class Car
    {
        protected string Name = "";
        protected string Body = "";

        protected Engine Engine;
        protected Paint PaintColor;
        protected Wheels Wheels;

        public abstract void Configure();
        public void AssembleBody()
        {
            Console.WriteLine("Кузов установлен");
        }

        public void InstallEngine()
        {
            Console.WriteLine("Двигатель установлен");
        }

        public void InstallPaint()
        {
            Console.WriteLine("Машина окрашена");
        }

        public void InstallWheels()
        {
            Console.WriteLine("Колеса установлены");
        }
    }

}
