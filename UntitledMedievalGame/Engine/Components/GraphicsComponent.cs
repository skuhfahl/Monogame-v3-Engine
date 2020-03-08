using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using UntitledMedievalGame.Engine.Entities;
using UntitledMedievalGame.Engine.Services;

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
