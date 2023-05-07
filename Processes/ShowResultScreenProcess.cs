using VContainer;
using Views;

namespace Processes
{
    public class ShowResultScreenProcess
    {
        private readonly TitleScreen _titleScreen;
        private readonly MainScreen _mainScreen;
        private readonly ResultScreen _resultScreen;

        [Inject]
        public ShowResultScreenProcess(TitleScreen titleScreen, MainScreen mainScreen, ResultScreen resultScreen)
        {
            _titleScreen = titleScreen;
            _mainScreen = mainScreen;
            _resultScreen = resultScreen;
        }

        public void ShowResultScreen()
        {
            _titleScreen.Hide();
            _mainScreen.Hide();
            _resultScreen.Show();
        }
    }
}