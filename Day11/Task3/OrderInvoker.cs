namespace Task3
{
    public class OrderInvoker
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public string Invoke()
        {
            return _command.Execute();
        }
    }
}