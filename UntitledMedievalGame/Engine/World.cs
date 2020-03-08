using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using UntitledMedievalGame.Engine;
using UntitledMedievalGame.Engine.Components;
using UntitledMedievalGame.Engine.Entities;
using UntitledMedievalGame.Engine.Services;

namespace UntitledMedievalGame.Engine
{
    class World
    {
        private List<Entity> entities = new List<Entity>();

        public World()
        {
            // Create Player
            Entity player = new Entity(EntityType.PlayerPlaceholder);
            player.AddComponent(new PositionComponent(new Vector2(50, 50), new Vector2(20, 30), 0.0f));
            player.AddComponent(new GraphicsComponent());
            player.AddComponent(new InputComponent());

            entities.Add(player);
        }

        public virtual void Update()
        {
        }

        public virtual void Draw()
        {
        }
    }
}
