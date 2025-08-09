using Project.Infrastructure.Services;
using UnityEngine.UIElements;
using VContainer.Unity;

namespace Project.UI.MainMenu.Scripts
{
    public class MainMenuPresenter : IInitializable
    {
        private readonly UIDocument _uiDocument;
        private readonly SceneLoaderService _sceneLoaderService;

        public MainMenuPresenter(UIDocument uiDocument, SceneLoaderService sceneLoaderService)
        {
            _uiDocument = uiDocument;
            _sceneLoaderService = sceneLoaderService;
        }

        public void Initialize()
        {
            VisualElement root = _uiDocument.rootVisualElement;

            Button startButton = root.Q<Button>("StartButton");
            Button settingsButton = root.Q<Button>("SettingsButton");
            Button exitButton = root.Q<Button>("ExitButton");

            startButton.clicked += _sceneLoaderService.LoadFirstLevel;
            settingsButton.clicked += () => { };
            exitButton.clicked += () => { };
        }
    }
}