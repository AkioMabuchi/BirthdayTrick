using Events;
using Models;
using Presenters;
using Processes;
using VContainer;
using VContainer.Unity;
using Views;

public class GameLifetimeScope : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        builder.Register<BirthdayModel>(Lifetime.Singleton);
        
        builder.RegisterComponentInHierarchy<TitleScreen>();
        builder.RegisterComponentInHierarchy<MainScreen>();
        builder.RegisterComponentInHierarchy<ResultScreen>();

        builder.Register<AnswerYesProcess>(Lifetime.Singleton);
        builder.Register<InitializeMainGameProcess>(Lifetime.Singleton);
        builder.Register<NextStepMainScreenProcess>(Lifetime.Singleton);
        builder.Register<SetBirthdayNumbersOnMainScreenProcess>(Lifetime.Singleton);
        builder.Register<ShowTitleScreenProcess>(Lifetime.Singleton);
        builder.Register<ShowMainScreenProcess>(Lifetime.Singleton);
        builder.Register<ShowResultScreenProcess>(Lifetime.Singleton);

        builder.RegisterEntryPoint<ResultScreenPresenter>();

        builder.RegisterEntryPoint<OnButtonClickedTitleScreen>();
        builder.RegisterEntryPoint<OnButtonClickedMainScreen>();
        builder.RegisterEntryPoint<OnButtonClickedResultScreen>();

        builder.RegisterEntryPoint<OnGameStart>();
    }
}
