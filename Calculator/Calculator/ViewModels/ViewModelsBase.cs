using Calculator.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Calculator.ViewModels
{
    public abstract class ViewModelsBase : ObservableProperty
    {
        public Dictionary<string, ICommand> Commands { get; protected set; }

        public ViewModelsBase()
        {
            Commands = new Dictionary<string, ICommand>();
        }
    }
}
