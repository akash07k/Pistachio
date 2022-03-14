namespace Pistachio.ViewModels
{
    internal class RelayCommand : ICommand
    {
        private readonly Action _Action;
        private readonly Func<bool> _CanExecute;

        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action action)
            : this(action, null)
        {
                    }

        public RelayCommand(Action action, Func<bool> canExecute)
        {
            if(action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }
            _Action = action;
            _CanExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _CanExecute == null || _CanExecute();
        }

        public void Execute(object parameter)
        {
            _Action();
        }

        public void RaiseCanExecuteChanged()
        {
CanExecuteChanged?.Invoke(this, EventArgs.Empty);
}

    }
}
