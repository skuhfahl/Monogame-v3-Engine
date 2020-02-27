using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using UntitledMedievalGame.Engine;

namespace UntitledMedievalGame.Engine
{
    /// <summary>
    /// The base object that will be drawn to the screen
    /// </summary>
    class Entity
    {
        private Vector2 position;
        private Vector2 dimensions;
        private Texture2D texture;

        private SpriteBatch spriteBatch;
        private SpriteEffects spriteEffects;

        public Entity(ContentManager content, SpriteBatch spriteBatch, string texturePath, Vector2 position, Vector2 dimensions)
        {
            this.texture = content.Load<Texture2D>(texturePath);
            this.position = position;
            this.dimensions = dimensions;
            this.spriteBatch = spriteBatch;

        }

        public virtual void Update()
        {
            System.Diagnostics.Debug.WriteLine($"{DateTime.Now}: In Entity Update!");
        }

        public virtual void Draw()
        {
            System.Diagnostics.Debug.WriteLine($"{DateTime.Now}: In Entity Draw!");
            spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, (int)dimensions.X, (int)dimensions.Y), null, Color.White, 0.0f, new Vector2(texture.Bounds.Width / 2, texture.Bounds.Height / 2), spriteEffects, 0.0f);
        }
    }
}
