using Comand.Commands;
using Comand.ControllerSystems;
using System;

namespace Comand
{
    class Program
    {
        static void Main(string[] args)
        {
            // получатели
            CTv tv = new CTv();
            CTeapot teapot = new CTeapot();
            // объекты комма нд
            TVCommand tvCommand = new TVCommand(tv);
            TeapotCommand teapotCommand = new TeapotCommand(teapot);
            // объекты отправителей
            RemoteControl remote = new RemoteControl();
            remote.SetCommandForButton(1, tvCommand);
            remote.SetCommandForButton(2, teapotCommand);
            string userInput;
            do
            {
                Console.WriteLine("Выбирите вариант: ");
                Console.WriteLine(remote);
                Console.WriteLine("\nВаш выбор: ");
                var input = Console.ReadLine();
                int buttonId;
                int.TryParse(input, out buttonId);
                remote.PushButton(buttonId);
                remote.PushButton(buttonId);
                remote.UndoButton(buttonId);
                remote.UndoButton(buttonId);
                Console.WriteLine("\nВы хотите продолжить? (y/n): ");
                userInput = Console.ReadLine();
            } while (userInput == "y");
        }
    }
}