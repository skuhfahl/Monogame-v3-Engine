using Microsoft.Xna.Framework;

namespace UntitledMedievalGame.Engine.Components
{
    /// <summary>
    /// The Physics Component is responsible for applying forces to the entity. 
    /// </summary>
    class PhysicsComponent : IComponent
    {
        public int MovementSpeed { get; set; }
        public Vector2 Velocity { get; set; }

        public PhysicsComponent(int movementSpeed, Vector2 velocity)
        {
            this.MovementSpeed = movementSpeed;
            this.Velocity = velocity;
        }
    }
}
