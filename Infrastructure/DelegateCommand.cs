using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Test_Assignment.Infrastructure
{
    class DelegateCommand : ICommand
    {
        private Predicate<object> canExecuteMethod;
        private Action<object> executeMethod;

        public DelegateCommand(Action<object> eM, Predicate<object> cEM = null)
        {
            canExecuteMethod = cEM;
            executeMethod = eM;
        }

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object parameter)
        {
            return canExecuteMethod == null || canExecuteMethod(parameter);
        }

        public void Execute(object parameter)
        {
            executeMethod(parameter);
        }
    }
}
