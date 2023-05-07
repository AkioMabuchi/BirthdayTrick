using Processes;
using UniRx;
using VContainer;
using VContainer.Unity;
using Views;

namespace Events
{
    public class OnButtonClickedResultScreen : IInitializable
    {
        private readonly ResultScreen _resultScreen;
        private readonly ShowTitleScreenProcess _showTitleScreenProcess;

        [Inject]
        public OnButtonClickedResultScreen(ResultScreen resultScreen, ShowTitleScreenProcess showTitleScreenProcess)
        {
            _resultScreen = resultScreen;
            _showTitleScreenProcess = showTitleScreenProcess;
        }

        public void Initialize()
        {
            _resultScreen.OnClickButtonTitle.Subscribe(_ =>
            {
                _showTitleScreenProcess.ShowTitleScreen();
            });
        }
    }
}