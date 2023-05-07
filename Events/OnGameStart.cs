using Processes;
using VContainer;
using VContainer.Unity;

namespace Events
{
    public class OnGameStart: IPostStartable
    {
        private readonly ShowTitleScreenProcess _showTitleScreenProcess;

        [Inject]
        public OnGameStart(ShowTitleScreenProcess showTitleScreenProcess)
        {
            _showTitleScreenProcess = showTitleScreenProcess;
        }
        
        public void PostStart()
        {
            _showTitleScreenProcess.ShowTitleScreen();
        }
    }
}