using Models;
using VContainer;

namespace Processes
{
    public class AnswerYesProcess
    {
        private readonly BirthdayModel _birthdayModel;

        [Inject]
        public AnswerYesProcess(BirthdayModel birthdayModel)
        {
            _birthdayModel = birthdayModel;
        }

        public void AnswerYes()
        {
            _birthdayModel.OnAnsweredYes();
        }
    }
}