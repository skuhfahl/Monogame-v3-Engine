using Microsoft.Xna.Framework;

namespace UntitledMedievalGame.Engine.Services
{
    // To do - Evaluate whether this class is needed. 
    // Other alternatives:
    // 1. Passing dependencies in through constructor
    // 2. Utilizing Game.Services to store dependencies and passing in through constructor

    public static class GameServices
    {
        private static GameServiceContainer container;
        public static GameServiceContainer Instance
        {
            get
            {
                if (container == null)
                {
                    container = new GameServiceContainer();
                }
                return container;
            }
        }

        public static T GetService<T>()
        {
            return (T)Instance.GetService(typeof(T));
        }

        public static void AddService<T>(T service)
        {
            Instance.AddService(typeof(T), service);
        }

        public static void RemoveService<T>()
        {
            Instance.RemoveService(typeof(T));
        }
    }
}
