using Microsoft.Xna.Framework;
using System.Collections.Generic;
using UntitledMedievalGame.Engine.Components;
using UntitledMedievalGame.Engine.Entities;
using UntitledMedievalGame.Engine.Systems;

namespace UntitledMedievalGame.Engine
{
    class World
    {
        private List<Entity> entities = new List<Entity>();
        private PlayerControllerSystem playerControllerSystem;
        private MovementSystem movementSystem;
        private RenderingSystem renderingSystem;

        public World()
        {
            // Create Player
            Entity player = new Entity(EntityType.PlayerPlaceholder);
            player.AddComponent(new PositionComponent(new Vector2(50, 50), new Vector2(20, 30), 0.0f));
            player.AddComponent(new PhysicsComponent(1, new Vector2(0, 0)));
            player.AddComponent(new GraphicsComponent());
            player.AddComponent(new InputComponent());
            entities.Add(player);

            // Create Rat
            Entity rat = new Entity(EntityType.Rat);
            rat.AddComponent(new PositionComponent(new Vector2(100, 50), new Vector2(30, 20), 0.0f));
            rat.AddComponent(new GraphicsComponent());
            entities.Add(rat);

            playerControllerSystem = new PlayerControllerSystem(entities);
            movementSystem = new MovementSystem(entities);
            renderingSystem = new RenderingSystem(entities);
        }

        public virtual void Update()
        {
            playerControllerSystem.Update();
            movementSystem.Update();
        }

        public virtual void Draw()
        {
            renderingSystem.Update();
        }
    }
}
