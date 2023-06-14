using Microsoft.Xna.Framework;
using System.Collections.Generic;
using UntitledGame.Engine.Components;
using UntitledGame.Engine.Entities;
using UntitledGame.Engine.Systems;

namespace UntitledGame.Engine
{
    class World
    {
        private List<Entity> entities = new List<Entity>();
        private PlayerControllerSystem playerControllerSystem;
        private CollisionSystem collisionSystem;
        private MovementSystem movementSystem;
        private RenderingSystem renderingSystem;

        public World()
        {
            // Create Player
            Entity player = new Entity(EntityType.PlayerPlaceholder);
            player.AddComponent(new PositionComponent(new Vector2(50, 50), new Vector2(20, 30), 0.0f));
            player.AddComponent(new PhysicsComponent(2.0f, Vector2.Zero, true));
            player.AddComponent(new GraphicsComponent("PlayerPlaceholder"));
            player.AddComponent(new InputComponent());
            entities.Add(player);

            // Create Rat
            Entity rat = new Entity(EntityType.Rat);
            rat.AddComponent(new PositionComponent(new Vector2(100, 50), new Vector2(30, 20), 0.0f));
            rat.AddComponent(new PhysicsComponent(0.0f, Vector2.Zero, true));
            rat.AddComponent(new GraphicsComponent("Rat"));
            entities.Add(rat);

            playerControllerSystem = new PlayerControllerSystem(entities);
            collisionSystem = new CollisionSystem(entities);
            movementSystem = new MovementSystem(entities);
            renderingSystem = new RenderingSystem(entities);
        }

        public virtual void Update()
        {
            playerControllerSystem.Update();
            collisionSystem.Update();
            movementSystem.Update();
        }

        public virtual void Draw()
        {
            renderingSystem.Update();
        }
    }
}
