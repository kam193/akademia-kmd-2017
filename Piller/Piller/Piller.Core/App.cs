using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using Piller.Core.ViewModels;

namespace Piller.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<StartViewModel>();
        }
    }
}
