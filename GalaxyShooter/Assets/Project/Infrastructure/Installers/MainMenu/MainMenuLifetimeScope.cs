using VContainer;
using VContainer.Unity;

namespace Project.Infrastructure.Installers.MainMenu
{
    public class MainMenuLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<UI.MainMenu.Scripts.MainMenu>();
        }
    }
}