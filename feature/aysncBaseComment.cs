using Gerocery.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerocery.feature
{
    public abstract class aysncBaseComment:BaseViewModel
    {
        private readonly Action<Exception> _onException;

        private bool _isExecuting;
        public bool IsExecuting
        {
            get
            {
                return _isExecuting;
            }
            private set
            {
                _isExecuting = value;
                OnCanExecuteChanged();
            }
        }

        public event EventHandler CanExecuteChanged;

        public aysncBaseComment(Action<Exception> onException = null)
        {
            _onException = onException;
        }

        public bool CanExecute(object parameter)
        {
            return !IsExecuting;
        }

        public async void Execute(object parameter)
        {
            IsExecuting = true;

            try
            {
                await ExecuteAsync(parameter);
            }
            catch (Exception ex)
            {
                _onException?.Invoke(ex);
            }

            IsExecuting = false;
        }

        protected abstract Task ExecuteAsync(object parameter);

        protected void OnCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }
    }
}
