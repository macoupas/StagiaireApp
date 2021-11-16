using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PresentationStagiaire.RelayCommand
{
    public class RelayCommands : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Action action;
        private Action<object> actionObject;
        private Func<object, bool> _canexecute;


        public RelayCommands(Action action)
        {
            this.action = action;
        }

        public RelayCommands(Action<object> action)
        {
            this.actionObject = action;
        }

        public RelayCommands(Action<object> actionObject, Func<object, bool> canexecute)
        {
            this.actionObject = actionObject;
            this._canexecute = canexecute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (actionObject != null) { actionObject(parameter); } else { action(); }
        }
    }
}
