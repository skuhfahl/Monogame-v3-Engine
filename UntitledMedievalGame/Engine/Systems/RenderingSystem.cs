using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using UntitledMedievalGame.Engine.Components;
using UntitledMedievalGame.Engine.Entities;
using UntitledMedievalGame.Engine.Services;

namespace UntitledMedievalGame.Engine.Systems
{
    class RenderingSystem
    {
        //Services
        private ContentManager contentManager = GameServices.GetService<ContentManager>();
        private SpriteBatch spriteBatch = GameServices.GetService<SpriteBatch>();
        
        List<Entity> entities;

        public RenderingSystem(List<Entity> entities)
        {
            this.entities = entities;
        }
        
        public void Update()
        {
            foreach(Entity e in entities)
            {
                GraphicsComponent gc = e.GetComponent<GraphicsComponent>();
                PositionComponent pc = e.GetComponent<PositionComponent>();

                if (gc != null && pc != null)
                {
                    string spritePath = GetSpritePath(e.type);
                    gc.sprite = contentManager.Load<Texture2D>(spritePath);
                    spriteBatch.Draw(
                        gc.sprite, 
                        new Rectangle((int)pc.Position.X, (int)pc.Position.Y, (int)pc.Dimensions.X, (int)pc.Dimensions.Y), 
                        null, 
                        Color.White, 
                        pc.Rotation, 
                        new Vector2(gc.sprite.Bounds.Width / 2, gc.sprite.Bounds.Height / 2), gc.spriteEffects, 0.0f
                        );
                }
            }
        }

        private string GetSpritePath(EntityType type)
        {
            // This should probably be removed in favor of passing the path in GraphicsComponent Constructor

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

    }
}
