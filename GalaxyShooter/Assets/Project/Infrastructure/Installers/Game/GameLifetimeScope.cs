using Project.Core;
using Project.Infrastructure.Services;
using VContainer;
using VContainer.Unity;

namespace Project.Infrastructure.Installers.Game
{
    public class GameLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<SceneLoaderService>(Lifetime.Singleton);

            builder.RegisterEntryPoint<Bootstrap>();
        }
    }
}