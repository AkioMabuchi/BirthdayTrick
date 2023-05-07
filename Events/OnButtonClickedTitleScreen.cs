using Processes;
using UniRx;
using VContainer.Unity;
using Views;

namespace Events
{
    public class OnButtonClickedTitleScreen: IInitializable
    {
        private readonly TitleScreen _titleScreen;

        private readonly InitializeMainGameProcess _initializeMainGameProcess;
        private readonly ShowMainScreenProcess _showMainScreenProcess;
        private readonly SetBirthdayNumbersOnMainScreenProcess _setBirthdayNumbersOnMainScreenProcess;

        public OnButtonClickedTitleScreen(TitleScreen titleScreen, InitializeMainGameProcess initializeMainGameProcess,
            ShowMainScreenProcess showMainScreenProcess,
            SetBirthdayNumbersOnMainScreenProcess setBirthdayNumbersOnMainScreenProcess)
        {
            _titleScreen = titleScreen;

            _initializeMainGameProcess = initializeMainGameProcess;
            _showMainScreenProcess = showMainScreenProcess;
            _setBirthdayNumbersOnMainScreenProcess = setBirthdayNumbersOnMainScreenProcess;
        }

        public void Initialize()
        {
            _titleScreen.OnClickButtonStart.Subscribe(_ =>
            {
                _initializeMainGameProcess.InitializeMainGame();
                _showMainScreenProcess.ShowMainScreen();
                _setBirthdayNumbersOnMainScreenProcess.SetBirthdayNumbersOnMainScreen();
            });
        }
    }
}