namespace Project.Infrastructure.Services
{
    public class SceneLoaderService
    {
        private const string MAIN_MENU_SCENE = "MainMenu";

        public void LoadMainMenu()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(MAIN_MENU_SCENE);
        }
    }
}