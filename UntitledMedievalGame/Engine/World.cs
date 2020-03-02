using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using UntitledMedievalGame.Engine;
using UntitledMedievalGame.Engine.Entities;
using UntitledMedievalGame.Engine.Services;

namespace UntitledMedievalGame.Engine
{
    class World
    {
        private List<Entity> entities = new List<Entity>();

        public World()
        {
            entities.Add(new Entity(EntityType.PlayerPlaceholder, new Vector2(50, 50), new Vector2(20, 30)));
            entities.Add(new Entity(EntityType.Rat, new Vector2(100, 50), new Vector2(30, 20)));
        }

        public virtual void Update()
        {
            foreach(Entity e in entities)
            {
                e.Update();
            }
        }

        public virtual void Draw()
        {
            foreach(Entity e in entities)
            {
                e.Draw();
            }
            
        }
    }
}
