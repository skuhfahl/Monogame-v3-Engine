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
    class GraphicsComponent
    {
        //Services
        private ContentManager contentManager = GameServices.GetService<ContentManager>();
        private SpriteBatch spriteBatch = GameServices.GetService<SpriteBatch>();

        //Public Fields

        //Private Fields
        private Vector2 dimensions;
        private Texture2D sprite;
        private SpriteEffects spriteEffects;

        public GraphicsComponent()
        {

        }

        public void Update(Entity entity)
        {
            // Load the sprite corresponding to the entity type
            string spritePath = GetSpritePath(entity.type);
            sprite = contentManager.Load<Texture2D>(spritePath);
        }

        private string GetSpritePath(EntityType type)
        {
            //To do - Don't want to have to manually add a new case for each sprite.

            string spritePath;

            switch (type)
            {
                case EntityType.PlayerPlaceholder:
                    spritePath = "PlayerPlaceholder";
                    break;
                case EntityType.Rat:
                    spritePath = "Rat";
                    break;
                default:
                    spritePath = "TextureError";
                    break;
            }

            return spritePath;
        }

        public void Draw(Entity entity)
        {
            spriteBatch.Draw(sprite, new Rectangle((int)entity.position.X, (int)entity.position.Y, (int)entity.dimensions.X, (int)entity.dimensions.Y), null, Color.White, 0.0f, new Vector2(sprite.Bounds.Width / 2, sprite.Bounds.Height / 2), spriteEffects, 0.0f);
        }
    }
}
