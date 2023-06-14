using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using UntitledGame.Engine.Components;
using UntitledGame.Engine.Services;

namespace UntitledGame.Engine.Systems
{
    class RenderingSystem
    {
        //Services
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
    }
}
