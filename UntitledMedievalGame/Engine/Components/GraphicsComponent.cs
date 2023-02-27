using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using UntitledMedievalGame.Engine.Services;

namespace UntitledMedievalGame.Engine.Components
{
    /// <summary>
    /// This component is responsible for rendering a sprite.
    /// </summary>
    class GraphicsComponent : IComponent
    {
        private ContentManager contentManager = GameServices.GetService<ContentManager>();

        public Texture2D sprite;
        public SpriteEffects spriteEffects;

        public GraphicsComponent(string spritePath)
        {
            this.sprite = LoadSprite(spritePath);
        }

        private Texture2D LoadSprite(string path)
        {
            return contentManager.Load<Texture2D>(path);
        }
    }
}
