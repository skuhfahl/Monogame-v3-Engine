using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using UntitledMedievalGame.Engine;
using UntitledMedievalGame.Engine.Components;
using UntitledMedievalGame.Engine.Services;

namespace UntitledMedievalGame.Engine
{
    /// <summary>
    /// The base object that will be drawn to the screen
    /// </summary>
    class Entity
    {
        //Services
        private ContentManager contentManager = GameServices.GetService<ContentManager>();
        private SpriteBatch spriteBatch = GameServices.GetService<SpriteBatch>();

        //Components
        private InputComponent inputComponent = new InputComponent();

        //Public Fields
        public Vector2 position;
        public int movementSpeed = 1;

        //Private Fields
        private Vector2 dimensions;
        private Texture2D texture;

        private SpriteEffects spriteEffects;

        public Entity(string texturePath, Vector2 position, Vector2 dimensions)
        {
            this.texture = contentManager.Load<Texture2D>(texturePath);
            this.position = position;
            this.dimensions = dimensions;
        }

        public virtual void Update()
        {
            inputComponent.Update(this);
        }

        public virtual void Draw()
        {
            spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, (int)dimensions.X, (int)dimensions.Y), null, Color.White, 0.0f, new Vector2(texture.Bounds.Width / 2, texture.Bounds.Height / 2), spriteEffects, 0.0f);
        }
    }
}
