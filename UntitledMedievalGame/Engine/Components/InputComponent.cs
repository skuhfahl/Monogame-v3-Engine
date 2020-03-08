namespace UntitledMedievalGame.Engine.Components
{
    /// <summary>
    /// InputComponent checks for any mouse & keyboard input and updates Entity accordingly.
    /// </summary>
    class InputComponent : IComponent
    {
        public InputHelper inputHelper;

        public InputComponent()
        {
            inputHelper = new InputHelper();
        }
    }
}
