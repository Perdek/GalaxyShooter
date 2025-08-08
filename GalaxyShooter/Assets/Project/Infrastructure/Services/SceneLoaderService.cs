namespace Project.Infrastructure.Services
{
    public class SceneLoaderService
    {
        private const string MAIN_MENU_SCENE = "MainMenu";
        private const string FIRST_LEVEL_SCENE = "Level1";

        public void LoadMainMenu()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(MAIN_MENU_SCENE);
        }

        public void LoadFirstLevel()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(FIRST_LEVEL_SCENE);
        }
    }
}