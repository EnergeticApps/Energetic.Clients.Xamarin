using Energetic.Clients.ViewModels;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Energetic.Clients.Xamarin.ViewModels
{
    public class CommandFactory : ICommandFactory
    {
        public ICommand CreateCommand(Action<object> execute)
        {
            return new Command(execute);
        }

        public ICommand CreateCommand(Action execute)
        {
            return new Command(execute);
        }

        public ICommand CreateCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            return new Command(execute, canExecute);
        }

        public ICommand CreateCommand(Action execute, Func<bool> canExecute)
        {
            return new Command(execute, canExecute);
        }

        public ICommand CreateCommand<T>(Action<T> execute)
        {
            return new Command<T>(execute);
        }

        public ICommand CreateCommand<T>(Action<T> execute, Func<T, bool> canExecute)
        {
            return new Command<T>(execute, canExecute);
        }

        public IAsyncCommand CreateCommand(Func<Task> execute, Func<bool>? canExecute = null, Action<Exception>? errorHandler = null)
        {
            return new AsyncCommand(execute, canExecute, errorHandler);
        }
    }
}