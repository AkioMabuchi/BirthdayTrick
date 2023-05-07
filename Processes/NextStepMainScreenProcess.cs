using Models;
using VContainer;

namespace Processes
{
    public class NextStepMainScreenProcess
    {
        private readonly BirthdayModel _birthdayModel;
        private readonly SetBirthdayNumbersOnMainScreenProcess _setBirthdayNumbersOnMainScreenProcess;
        private readonly ShowResultScreenProcess _showResultScreenProcess;

        [Inject]
        public NextStepMainScreenProcess(BirthdayModel birthdayModel,
            SetBirthdayNumbersOnMainScreenProcess setBirthdayNumbersOnMainScreenProcess,
            ShowResultScreenProcess showResultScreenProcess)
        {
            _birthdayModel = birthdayModel;
            _setBirthdayNumbersOnMainScreenProcess = setBirthdayNumbersOnMainScreenProcess;
            _showResultScreenProcess = showResultScreenProcess;
        }

        public void NextStepMainScreen()
        {
            _birthdayModel.IncreaseIndexesIndex();
            if (_birthdayModel.IsFinished)
            {
                _showResultScreenProcess.ShowResultScreen();
            }
            else
            {
                _setBirthdayNumbersOnMainScreenProcess.SetBirthdayNumbersOnMainScreen();
            }
        }
    }
}