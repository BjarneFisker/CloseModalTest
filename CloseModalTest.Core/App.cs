using MvvmCross.Platform.IoC;
using CloseModalTest.Core.ViewModels;
using MvvmCross.Platform;

namespace CloseModalTest.Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterNavigationServiceAppStart<FirstViewModel>();
        }
    }
}
