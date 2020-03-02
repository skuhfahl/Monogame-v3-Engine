using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using UntitledMedievalGame.Engine;
using UntitledMedievalGame.Engine.Components;
using UntitledMedievalGame.Engine.Entities;
using UntitledMedievalGame.Engine.Services;

namespace UntitledMedievalGame.Engine
{
    /// <summary>
    /// The base object that will be drawn to the screen
    /// </summary>
    class Entity
    {
        //Components
        private InputComponent inputComponent = new InputComponent();
        private GraphicsComponent graphicsComponent = new GraphicsComponent();

        //Public Fields
        public EntityType type;
        public Vector2 position;
        public Vector2 dimensions;
        public int movementSpeed = 1;

        public Entity(EntityType type, Vector2 position, Vector2 dimensions)
        {
            this.type = type;
            this.position = position;
            this.dimensions = dimensions;
        }

        public virtual void Update()
        {
            inputComponent.Update(this);
            graphicsComponent.Update(this);
        }

        public virtual void Draw()
        {
            graphicsComponent.Draw(this);
        }
    }
}
