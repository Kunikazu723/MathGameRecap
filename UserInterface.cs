using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre;
using Spectre.Console;
namespace MathGameRecap
{
    internal class UserInterface
    {
        public void MainMenu()
        {
            AnsiConsole.MarkupLine("[blue]Welcome[/] to the Math game\nPress [green]Any Key[/] to Begin");
            Console.ReadKey(); 
            while (true)
            {
                Console.WriteLine("Game engine yadda yadda");
                Console.ReadKey();
            }
        }
    }
}
