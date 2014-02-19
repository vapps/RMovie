using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMovie.PCL.Commons
{
    public class DelegateCommand : System.Windows.Input.ICommand
    {
        //Func<object, bool> canExecute;
        //Action<object> executeAction;
        //bool canExecuteCache;

        //public DelegateCommand(Action<object> executeAction, Func<object, bool> canExecute)
        //{
        //    this.executeAction = executeAction;
        //    this.canExecute = canExecute;
        //}

        //#region ICommand Members

        //public bool CanExecute(object parameter)
        //{
        //    bool temp = canExecute(parameter);

        //    if (canExecuteCache != temp)
        //    {
        //        canExecuteCache = temp;
        //        if (CanExecuteChanged != null)
        //        {
        //            CanExecuteChanged(this, new EventArgs());
        //        }
        //    }

        //    return canExecuteCache;
        //}

        //public event EventHandler CanExecuteChanged;

        //public void Execute(object parameter)
        //{
        //    executeAction(parameter);
        //}

        //#endregion
        private readonly Predicate<object> _canExecute;
        private readonly Action<object> _execute;

        public event EventHandler CanExecuteChanged;

        public DelegateCommand(Action<object> execute)
            : this(execute, null)
        {
        }

        public DelegateCommand(Action<object> execute,
                       Predicate<object> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecute == null)
                return true;

            return _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public void RaiseCanExecuteChanged()
        {
            if (CanExecuteChanged != null)
            {
                CanExecuteChanged(this, null);
            }
        }
    }
}
