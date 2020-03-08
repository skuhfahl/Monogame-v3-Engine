using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using UntitledMedievalGame.Engine.Components;
using UntitledMedievalGame.Engine.Entities;

namespace UntitledMedievalGame.Engine
{
    /// <summary>
    /// The base object that will be drawn to the screen
    /// </summary>
    class Entity : IEntity
    {
        public EntityType type;
        private List<IComponent> components;

        public Entity(EntityType type)
        {
            this.type = type;
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
        public T GetComponent<T>() where T : IComponent
        {
            return (T)this.components.Where(c => c.GetType() == typeof(T)).First();
        }

        /// <summary>
        /// Remove all Components of type T from the Entity.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public void RemoveComponent<T>() where T : IComponent
        {
            this.components.RemoveAll(c => c.GetType() == typeof(T));
        }
    }
}
