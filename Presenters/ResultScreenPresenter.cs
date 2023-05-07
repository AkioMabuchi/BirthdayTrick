using Models;
using UniRx;
using VContainer;
using VContainer.Unity;
using Views;

namespace Presenters
{
    public class ResultScreenPresenter : IInitializable
    {
        private readonly BirthdayModel _birthdayModel;
        private readonly ResultScreen _resultScreen;

        [Inject]
        public ResultScreenPresenter(BirthdayModel birthdayModel, ResultScreen resultScreen)
        {
            _birthdayModel = birthdayModel;
            _resultScreen = resultScreen;
        }

        public void Initialize()
        {
            _birthdayModel.OnChangedResultNumber.Subscribe(resultNumber =>
            {
                _resultScreen.SerResultNumber(resultNumber);
            });
        }
    }
}