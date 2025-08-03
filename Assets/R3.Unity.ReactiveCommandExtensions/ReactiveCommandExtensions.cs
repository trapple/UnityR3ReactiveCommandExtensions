namespace R3.Unity.ReactiveCommandExtensions
{
    public static class ReactiveCommandExtensions
    {
        public static bool TryExecute<T>(this ReactiveCommand<T> command, T value)
        {
            if (!command.CanExecute()) return false;
            command.Execute(value);
            return true;
        }
    }
}
