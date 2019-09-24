namespace Command
{
    /// <summary>
    /// The 'Command' abstract class
    /// </summary>
    abstract class TheCommand
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }
}
