using Microsoft.Xna.Framework;
using System.Collections.Generic;
using UntitledMedievalGame.Engine.Components;

namespace UntitledMedievalGame.Engine.Systems
{
    // The Movement System is responsible for taking the forces in the Physics
    // Component and updating the Position Component accordingly. 
    class MovementSystem
    {
        List<Entity> entities;

        public MovementSystem(List<Entity> entities)
        {
            this.entities = entities;
        }

        public void Update()
        {
            foreach(Entity e in entities)
            {
                PositionComponent positionComponent = e.GetComponent<PositionComponent>();
                PhysicsComponent physicsComponent = e.GetComponent<PhysicsComponent>();

                if (positionComponent != null && physicsComponent != null)
                {
                    SetPosition(positionComponent, physicsComponent);
                    ClearVelocity(physicsComponent);
                }
            }
        }

        private void SetPosition(PositionComponent positionComponent, PhysicsComponent physicsComponent)
        {
            float newX = positionComponent.Position.X + physicsComponent.Velocity.X;
            float newY = positionComponent.Position.Y + physicsComponent.Velocity.Y;

            positionComponent.Position = new Vector2(newX, newY);
        }

        private void ClearVelocity(PhysicsComponent physicsComponent)
        {
            physicsComponent.Velocity = new Vector2(0.0f, 0.0f);
        }
    }
}
