using Microsoft.Xna.Framework;
using System.Collections.Generic;
using UntitledMedievalGame.Engine.Components;

namespace UntitledMedievalGame.Engine.Systems
{
    class CollisionSystem
    {
        List<Entity> entities;

        public CollisionSystem(List<Entity> entities)
        {
            this.entities = entities;
        }

        public void Update()
        {
            foreach (Entity e in entities)
            {
                PhysicsComponent physC = e.GetComponent<PhysicsComponent>();
                GraphicsComponent gC = e.GetComponent<GraphicsComponent>();
                PositionComponent posC = e.GetComponent<PositionComponent>();

                // run logic if entitiy has PhysicsComponent. 
                // check if entities would have collided and if so set velocity to 0

                if(physC != null && physC.Collidable && gC != null && posC != null)
                {
                    foreach(Entity e2 in entities)
                    {
                        PhysicsComponent physC2 = e2.GetComponent<PhysicsComponent>();
                        GraphicsComponent gC2 = e2.GetComponent<GraphicsComponent>();
                        PositionComponent posC2 = e2.GetComponent<PositionComponent>();

                        if (physC2 != null && physC2.Collidable && gC2 != null && posC2 != null)
                        {
                            if (IsTouchingLeft(e, e2) || IsTouchingRight(e, e2))
                            {
                                physC.Velocity = new Vector2(0.0f, physC.Velocity.Y);
                            }
                            if (IsTouchingTop(e, e2) || IsTouchingBottom(e, e2))
                            {
                                physC.Velocity = new Vector2(physC.Velocity.X, 0.0f);
                            } 
                        }
                    }                    
                }
            }
        }

        #region Collision Detection Methods

        protected bool IsTouchingLeft(Entity e1, Entity e2)
        {
            PhysicsComponent e1physComp = e1.GetComponent<PhysicsComponent>();
            GraphicsComponent e1gc = e1.GetComponent<GraphicsComponent>();
            PositionComponent e1posComp = e1.GetComponent<PositionComponent>();

            PhysicsComponent e2physComp = e2.GetComponent<PhysicsComponent>();
            GraphicsComponent e2gc = e2.GetComponent<GraphicsComponent>();
            PositionComponent e2posComp = e2.GetComponent<PositionComponent>();

            Rectangle e1BoundingBox = new Rectangle((int)e1posComp.Position.X, (int)e1posComp.Position.Y, (int)e1posComp.Dimensions.X, (int)e1posComp.Dimensions.Y);
            Rectangle e2BoundingBox = new Rectangle((int)e2posComp.Position.X, (int)e2posComp.Position.Y, (int)e2posComp.Dimensions.X, (int)e2posComp.Dimensions.Y);


            return e1BoundingBox.Right + e1physComp.Velocity.X > e2BoundingBox.Left &&
              e1BoundingBox.Left < e2BoundingBox.Left &&
              e1BoundingBox.Bottom > e2BoundingBox.Top &&
              e1BoundingBox.Top < e2BoundingBox.Bottom;
        }

        protected bool IsTouchingRight(Entity e1, Entity e2)
        {
            PhysicsComponent e1physComp = e1.GetComponent<PhysicsComponent>();
            GraphicsComponent e1gc = e1.GetComponent<GraphicsComponent>();
            PositionComponent e1posComp = e1.GetComponent<PositionComponent>();

            PhysicsComponent e2physComp = e2.GetComponent<PhysicsComponent>();
            GraphicsComponent e2gc = e2.GetComponent<GraphicsComponent>();
            PositionComponent e2posComp = e2.GetComponent<PositionComponent>();

            Rectangle e1BoundingBox = new Rectangle((int)e1posComp.Position.X, (int)e1posComp.Position.Y, (int)e1posComp.Dimensions.X, (int)e1posComp.Dimensions.Y);
            Rectangle e2BoundingBox = new Rectangle((int)e2posComp.Position.X, (int)e2posComp.Position.Y, (int)e2posComp.Dimensions.X, (int)e2posComp.Dimensions.Y);

            return e1BoundingBox.Left + e1physComp.Velocity.X < e2BoundingBox.Right &&
              e1BoundingBox.Right > e2BoundingBox.Right &&
              e1BoundingBox.Bottom > e2BoundingBox.Top &&
              e1BoundingBox.Top < e2BoundingBox.Bottom;
        }

        protected bool IsTouchingTop(Entity e1, Entity e2)
        {
            PhysicsComponent e1physComp = e1.GetComponent<PhysicsComponent>();
            GraphicsComponent e1gc = e1.GetComponent<GraphicsComponent>();
            PositionComponent e1posComp = e1.GetComponent<PositionComponent>();

            PhysicsComponent e2physComp = e2.GetComponent<PhysicsComponent>();
            GraphicsComponent e2gc = e2.GetComponent<GraphicsComponent>();
            PositionComponent e2posComp = e2.GetComponent<PositionComponent>();

            Rectangle e1BoundingBox = new Rectangle((int)e1posComp.Position.X, (int)e1posComp.Position.Y, (int)e1posComp.Dimensions.X, (int)e1posComp.Dimensions.Y);
            Rectangle e2BoundingBox = new Rectangle((int)e2posComp.Position.X, (int)e2posComp.Position.Y, (int)e2posComp.Dimensions.X, (int)e2posComp.Dimensions.Y);

            return e1BoundingBox.Bottom + e1physComp.Velocity.Y > e2BoundingBox.Top &&
              e1BoundingBox.Top < e2BoundingBox.Top &&
              e1BoundingBox.Right > e2BoundingBox.Left &&
              e1BoundingBox.Left < e2BoundingBox.Right;
        }

        protected bool IsTouchingBottom(Entity e1, Entity e2)
        {
            PhysicsComponent e1physComp = e1.GetComponent<PhysicsComponent>();
            GraphicsComponent e1gc = e1.GetComponent<GraphicsComponent>();
            PositionComponent e1posComp = e1.GetComponent<PositionComponent>();

            PhysicsComponent e2physComp = e2.GetComponent<PhysicsComponent>();
            GraphicsComponent e2gc = e2.GetComponent<GraphicsComponent>();
            PositionComponent e2posComp = e2.GetComponent<PositionComponent>();

            Rectangle e1BoundingBox = new Rectangle((int)e1posComp.Position.X, (int)e1posComp.Position.Y, (int)e1posComp.Dimensions.X, (int)e1posComp.Dimensions.Y);
            Rectangle e2BoundingBox = new Rectangle((int)e2posComp.Position.X, (int)e2posComp.Position.Y, (int)e2posComp.Dimensions.X, (int)e2posComp.Dimensions.Y);

            return e1BoundingBox.Top + e1physComp.Velocity.Y < e2BoundingBox.Bottom &&
              e1BoundingBox.Bottom > e2BoundingBox.Bottom &&
              e1BoundingBox.Right > e2BoundingBox.Left &&
              e1BoundingBox.Left < e2BoundingBox.Right;
        }

        #endregion

    }
}
