using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UntitledMedievalGame.Engine.Components;

namespace UntitledMedievalGame.Engine.Systems
{
    class PlayerControllerSystem
    {
        List<Entity> entities;

        public PlayerControllerSystem(List<Entity> entities)
        {
            this.entities = entities;
        }

        public void Update()
        {
            foreach(Entity e in entities)
            {
                InputComponent ic = e.GetComponent<InputComponent>();
                PhysicsComponent pc = e.GetComponent<PhysicsComponent>();

                if (ic != null && pc != null)
                {
                    ic.inputHelper.Update();

                    // X and Y Movement
                    if (ic.inputHelper.IsKeyDown(Keys.A))
                    {
                        pc.Velocity = new Vector2(pc.Velocity.X - pc.MovementSpeed, pc.Velocity.Y);
                    }
                    if (ic.inputHelper.IsKeyDown(Keys.D))
                    {
                        pc.Velocity = new Vector2(pc.Velocity.X + pc.MovementSpeed, pc.Velocity.Y);
                    }
                    if (ic.inputHelper.IsKeyDown(Keys.W))
                    {
                        pc.Velocity = new Vector2(pc.Velocity.X, pc.Velocity.Y - pc.MovementSpeed);
                    }
                    if (ic.inputHelper.IsKeyDown(Keys.S))
                    {
                        pc.Velocity = new Vector2(pc.Velocity.X, pc.Velocity.Y + pc.MovementSpeed);
                    }
                }
            }
        }
    }
}
