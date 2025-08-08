using Project.Infrastructure.Services;
using UnityEngine.UIElements;

namespace Project.UI.MainMenu.Scripts
{
    public class MainMenu
    {
        public MainMenu(UIDocument uiDocument, SceneLoaderService sceneLoaderService)
        {
            VisualElement root = uiDocument.rootVisualElement;

            Button startButton = root.Q<Button>("StartButton");
            Button settingsButton = root.Q<Button>("SettingsButton");
            Button exitButton = root.Q<Button>("ExitButton");

            startButton.clicked += sceneLoaderService.LoadFirstLevel;
            settingsButton.clicked += () => { };
            exitButton.clicked += () => { };
        }
    }
}