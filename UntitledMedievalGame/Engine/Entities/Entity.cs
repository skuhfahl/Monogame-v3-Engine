using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using UntitledMedievalGame.Engine;
using UntitledMedievalGame.Engine.Components;
using UntitledMedievalGame.Engine.Entities;
using UntitledMedievalGame.Engine.Services;

namespace UntitledMedievalGame.Engine
{
    /// <summary>
    /// The base object that will be drawn to the screen
    /// </summary>
    class Entity : IEntity
    {
        //Components
        private List<IComponent> components;
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
            this.components = new List<IComponent>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="component"> The Component to add to this Entity. </param>
        public void AddComponent(IComponent component)
        {
            this.components.Add(component);
        }

        /// <summary>
        /// Retrieves the component of the desired type. 
        /// </summary>
        /// <typeparam name="T"> The type of Component to retrieve. </typeparam>
        /// <returns> The Component of type T </returns>
        public IComponent GetComponent<T>() where T : IComponent
        {
            return this.components.Where(c => c.GetType() == typeof(T)).First();
        }

        /// <summary>
        /// Remove all Components of type T from the Entity.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public void RemoveComponent<T>() where T : IComponent
        {
            this.components.RemoveAll(c => c.GetType() == typeof(T));
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
