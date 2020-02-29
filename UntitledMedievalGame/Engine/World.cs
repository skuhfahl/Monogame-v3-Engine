using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using UntitledMedievalGame.Engine;
using UntitledMedievalGame.Engine.Services;

namespace UntitledMedievalGame.Engine
{
    class World
    {
        private Entity player;

        public World()
        {
            player = new Entity("PlayerPlaceholder", new Vector2(50, 50), new Vector2(20, 30));
        }

        public virtual void Update()
        {
            player.Update();
        }

        public virtual void Draw()
        {
            player.Draw();
        }
    }
}
