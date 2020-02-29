using Microsoft.Xna.Framework.Input;

namespace UntitledMedievalGame.Engine.Components
{
    /// <summary>
    /// InputComponent checks for any mouse & keyboard input and updates Entity accordingly.
    /// </summary>
    class InputComponent
    {
        private InputHelper inputHelper;

        public InputComponent()
        {
            inputHelper = new InputHelper();
        }

        public void Update(Entity entity)
        {
            inputHelper.Update();

            if (inputHelper.IsNewKeyPress(Keys.LeftShift))
            {
                entity.movementSpeed *= 2;
            }

            if (inputHelper.IsNewKeyRelease(Keys.LeftShift))
            {
                entity.movementSpeed /= 2;
            }

            if (inputHelper.IsKeyDown(Keys.A))
            {
                System.Diagnostics.Debug.WriteLine("InputComponent - Key Pressed: A");
                entity.position.X -= entity.movementSpeed;
            }
            if (inputHelper.IsKeyDown(Keys.D))
            {
                System.Diagnostics.Debug.WriteLine("InputComponent - Key Pressed: D");
                entity.position.X += entity.movementSpeed;
            }
            if (inputHelper.IsKeyDown(Keys.W))
            {
                System.Diagnostics.Debug.WriteLine("InputComponent - Key Pressed: W");
                entity.position.Y -= entity.movementSpeed;
            }
            if (inputHelper.IsKeyDown(Keys.S))
            {
                System.Diagnostics.Debug.WriteLine("InputComponent - Key Pressed: S");
                entity.position.Y += entity.movementSpeed;
            }
        }
    }
}
