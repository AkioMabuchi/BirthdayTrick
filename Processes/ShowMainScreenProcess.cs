using VContainer;
using Views;

namespace Processes
{
    public class ShowMainScreenProcess
    {
        private readonly TitleScreen _titleScreen;
        private readonly MainScreen _mainScreen;
        private readonly ResultScreen _resultScreen;

        [Inject]
        public ShowMainScreenProcess(TitleScreen titleScreen, MainScreen mainScreen, ResultScreen resultScreen)
        {
            _titleScreen = titleScreen;
            _mainScreen = mainScreen;
            _resultScreen = resultScreen;
        }

        public void ShowMainScreen()
        {
            _titleScreen.Hide();
            _mainScreen.Show();
            _resultScreen.Hide();
        }
    }
}