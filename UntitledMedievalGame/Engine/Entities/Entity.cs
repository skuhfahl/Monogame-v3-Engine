using System.Collections.Generic;
using System.Linq;
using UntitledGame.Engine.Components;
using UntitledGame.Engine.Entities;

namespace UntitledGame.Engine
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
        public T GetComponent<T>() where T : IComponent
        {
            //Need to handle the case where the component is null or does not exist.

            return (T)this.components.Where(c => c.GetType() == typeof(T)).FirstOrDefault();
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
