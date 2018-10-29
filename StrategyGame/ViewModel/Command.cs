using System;
using System.Windows.Input;

namespace StrategyGame.ViewModel
{
    class Command : ICommand
    {
        private Action<object> execute;
        private Func<object, bool> canExecute;

        public Command(Action<object> execute, Func<object, bool> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter)
        {
            return canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
