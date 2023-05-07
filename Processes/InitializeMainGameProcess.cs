using Models;

namespace Processes
{
    public class InitializeMainGameProcess
    {
        private readonly BirthdayModel _birthdayModel;

        public InitializeMainGameProcess(BirthdayModel birthdayModel)
        {
            _birthdayModel = birthdayModel;
        }

        public void InitializeMainGame()
        {
            _birthdayModel.Initialize();
        }
    }
}