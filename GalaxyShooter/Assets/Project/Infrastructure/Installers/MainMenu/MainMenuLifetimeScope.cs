using Project.UI.MainMenu.Scripts;
using UnityEngine;
using UnityEngine.UIElements;
using VContainer;
using VContainer.Unity;

namespace Project.Infrastructure.Installers.MainMenu
{
    public class MainMenuLifetimeScope : LifetimeScope
    {
        [SerializeField] private UIDocument _mainMenuUIDocument;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<MainMenuPresenter>().WithParameter<UIDocument>(_mainMenuUIDocument);
        }
    }
}