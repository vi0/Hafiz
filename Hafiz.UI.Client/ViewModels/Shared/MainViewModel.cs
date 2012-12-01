using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hafiz.UI.Client.ViewModels;
using System.Collections.ObjectModel;
using Hafiz.UI.Client.ViewModels.Commands;

namespace Hafiz.UI.Client.ViewModels
{
    public class MainViewModel : ViewModelBase
    {

        #region Commands

        ObservableCollection<CommandViewModel> _commands;

        /// <summary>
        /// The main command list (main menu) the UI will display for the user
        /// </summary>
        public ObservableCollection<CommandViewModel> Commands
        {
            set
            {
                if (_commands == null)
                    _commands = new ObservableCollection<CommandViewModel>();
                if (value != null && value is IEnumerable<CommandViewModel>)
                {
                    _commands.Clear();
                    value.ToList().ForEach(_commands.Add);
                    OnPropertyChanged<ObservableCollection<CommandViewModel>>();
                }
            }
            get
            {
                if (_commands == null)
                    _commands = new ObservableCollection<CommandViewModel>();
                this.CreateCommands().ForEach(_commands.Add);
                return _commands;
            }
        }

        List<CommandViewModel> CreateCommands()
        {
            return new List<CommandViewModel>
            {
                new CommandViewModel(
                    "Show tasks",
                    new RelayCommand(param => this.ShowTasks())),

                new CommandViewModel(
                    "Create task",
                    new RelayCommand(param => this.CreateTask()))
            };
        }

        #region Command handlers

        private void CreateTask()
        {
            //throw new NotImplementedException();
        }

        private void ShowTasks()
        {
            //throw new NotImplementedException();
        }

        #endregion


        #endregion // Commands

    }
}
