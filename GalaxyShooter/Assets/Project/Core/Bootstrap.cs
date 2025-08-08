using Project.Infrastructure.Services;
using VContainer.Unity;

namespace Project.Core
{
    public class Bootstrap : IStartable
    {
        private readonly SceneLoaderService _sceneLoaderService;

        public Bootstrap(SceneLoaderService sceneLoaderService)
        {
            _sceneLoaderService = sceneLoaderService;
        }

        public void Start()
        {
            _sceneLoaderService.LoadMainMenu();
        }
    }
}