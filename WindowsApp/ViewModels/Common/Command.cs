using System;
using System.Windows.Input;

namespace WindowsApp
{
    /// <summary>
    /// A common class delegating various commands so this can be genericly used
    /// </summary>
    public class Command : ICommand
    {
        private readonly Action _action;
        private readonly Predicate<object> _canExecute;

        public Command(Action action) : this(action, null)
        {
            _action = action;
        }
        public Command(Action action, Predicate<object> canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecute == null)
            {
                return true;
            }

            return _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _action();
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
