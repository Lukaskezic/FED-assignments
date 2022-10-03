using Assignment1.Models;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace Assignment1.ViewModels
{
    public class AddDebtorsViewModel : BindableBase
    {
        public DelegateCommand<Window> CloseAppCommand { get; private set; }

        public AddDebtorsViewModel()
        {
            CloseAppCommand = new DelegateCommand<Window>(ExecuteCloseAppCommand);
        }

        public void ExecuteCloseAppCommand(Window window)
        {
            window.Close();
        }
    }
}
