using Processes;
using UniRx;
using VContainer;
using VContainer.Unity;
using Views;

namespace Events
{
    public class OnButtonClickedMainScreen: IInitializable
    {
        private readonly MainScreen _mainScreen;
        private readonly AnswerYesProcess _answerYesProcess;
        private readonly NextStepMainScreenProcess _nextStepMainScreenProcess;
        
        [Inject]
        public OnButtonClickedMainScreen(MainScreen mainScreen, AnswerYesProcess answerYesProcess, NextStepMainScreenProcess nextStepMainScreenProcess)
        {
            _mainScreen = mainScreen;
            _answerYesProcess = answerYesProcess;
            _nextStepMainScreenProcess = nextStepMainScreenProcess;
        }
        
        public void Initialize()
        {
            _mainScreen.OnClickButtonYes.Subscribe(_ =>
            {
                _answerYesProcess.AnswerYes();
                _nextStepMainScreenProcess.NextStepMainScreen();
            });

            _mainScreen.OnClickButtonNo.Subscribe(_ =>
            {
                _nextStepMainScreenProcess.NextStepMainScreen();
            });
        }
    }
}