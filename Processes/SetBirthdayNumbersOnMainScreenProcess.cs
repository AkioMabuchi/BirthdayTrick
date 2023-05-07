using Models;
using VContainer;
using Views;

namespace Processes
{
    public class SetBirthdayNumbersOnMainScreenProcess
    {
        private readonly BirthdayModel _birthdayModel;
        private readonly MainScreen _mainScreen;

        [Inject]
        public SetBirthdayNumbersOnMainScreenProcess(BirthdayModel birthdayModel, MainScreen mainScreen)
        {
            _birthdayModel = birthdayModel;
            _mainScreen = mainScreen;
        }

        public void SetBirthdayNumbersOnMainScreen()
        {
            _mainScreen.SetNumbers(_birthdayModel.BirthdayNumbers);
        }
    }
}