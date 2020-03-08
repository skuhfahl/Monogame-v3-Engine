using Microsoft.Xna.Framework.Graphics;

namespace UntitledMedievalGame.Engine.Components
{
    /// <summary>
    /// This component is responsible for rendering a sprite.
    /// </summary>
    class GraphicsComponent : IComponent
    {
        public Texture2D sprite;
        public SpriteEffects spriteEffects;

        public GraphicsComponent()
        {

        }
    }
}
