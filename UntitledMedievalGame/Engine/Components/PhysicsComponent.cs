using Microsoft.Xna.Framework;

namespace UntitledGame.Engine.Components
{
    /// <summary>
    /// The Physics Component is responsible for applying forces to the entity. 
    /// </summary>
    class PhysicsComponent : IComponent
    {
        public float MovementSpeed { get; set; }
        public Vector2 Velocity { get; set; }

        public bool Collidable { get; set; }

        public PhysicsComponent(float movementSpeed, Vector2 velocity, bool collidable)
        {
            this.MovementSpeed = movementSpeed;
            this.Velocity = velocity;
            this.Collidable = collidable;
        }
    }
}
