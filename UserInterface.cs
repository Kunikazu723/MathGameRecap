using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre;
using Spectre.Console;
using static MathGameRecap.Enums;
namespace MathGameRecap
{
    internal class UserInterface
    {
        private readonly GameEngine _engine;
        public UserInterface(GameEngine engine)
        {
            _engine = engine;
        }

        public void MainMenu()
        {
            AnsiConsole.MarkupLine("[blue]Welcome[/] to the Math game");
            Helpers.Intermission();

            while (true)
            {
                var operatoinChoice = AnsiConsole.Prompt(
                    new SelectionPrompt<GameType>()
                        .Title("Select the game [blue]Type / Operation[/]:")
                        .AddChoices(Enum.GetValues<GameType>())
                    );

                _engine.RunGame(operatoinChoice);
            }
        }
    }
}
