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
            

            bool isAppRunning = true;
            do
            {
                AnsiConsole.MarkupLine("[blue]Welcome[/] to the Math game");
                var mainMenuChoice = AnsiConsole.Prompt(
                        new SelectionPrompt<MenuChoice>()
                        .Title("What would you like to do?")
                        .AddChoices(Enum.GetValues<MenuChoice>())
                    );
                switch (mainMenuChoice)
                {
                    case MenuChoice.Play:
                        GamesMenu();
                        break;
                    case MenuChoice.History:
                        MockDatabase.ViewHistory();
                        break;
                    case MenuChoice.Exit:
                        return;
                }

            } while (isAppRunning);

            
        }

        private void GamesMenu()
        {
            while (true)
            {
                var operatoinChoice = AnsiConsole.Prompt(
                    new SelectionPrompt<GameType>()
                        .Title("Select the game [blue]Type / Operation[/]:")
                        .AddChoices(Enum.GetValues<GameType>())
                    );

                if (operatoinChoice == GameType.MainMenu) return;

                _engine.RunGame(operatoinChoice);
            }
        }
    }
}
