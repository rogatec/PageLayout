using System;
using System.Windows.Input;

namespace PageLayoutService.ViewModels.Commands {
    public sealed class TransformCommand<T> : ICommand {
        #region "properties"

        private readonly Action<T> _executeMethod;
        private readonly Predicate<T> _canExecuteEvaluator;

        #endregion "properties"

        #region "constructors"

        public TransformCommand(Action<T> executeMethod, Predicate<T> canExecuteEvaluator = null) {
            _executeMethod = executeMethod ??
                             throw new ArgumentNullException(nameof(executeMethod),
                                 @"Delegate commands can not be null");
            _canExecuteEvaluator = canExecuteEvaluator;
        }

        #endregion "constructors"

        #region "methods/events"

#pragma warning disable 0067

        public event EventHandler CanExecuteChanged = delegate { };

#pragma warning restore 0067

        public bool CanExecute(object parameter) {
            return _canExecuteEvaluator == null || _canExecuteEvaluator((T) parameter);
        }

        public void Execute(object parameter) {
            _executeMethod((T) parameter);
        }

        #endregion "methods/events"
    }
}