using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using UntitledMedievalGame.Engine;

namespace UntitledMedievalGame.Engine
{
    class World
    {
        private Entity player;

        public World(ContentManager content, SpriteBatch spriteBatch)
        {
            player = new Entity(content, spriteBatch, "PlayerPlaceholder", new Vector2(50, 50), new Vector2(20, 30));
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
