using VContainer;
using Views;

namespace Processes
{
    public class ShowTitleScreenProcess
    {
        private readonly TitleScreen _titleScreen;
        private readonly MainScreen _mainScreen;
        private readonly ResultScreen _resultScreen;

        [Inject]
        public ShowTitleScreenProcess(TitleScreen titleScreen, MainScreen mainScreen, ResultScreen resultScreen)
        {
            _titleScreen = titleScreen;
            _mainScreen = mainScreen;
            _resultScreen = resultScreen;
        }

        public void ShowTitleScreen()
        {
            _titleScreen.Show();
            _mainScreen.Hide();
            _resultScreen.Hide();
        }
    }
}