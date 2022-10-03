using Assignment1.Models;
using Assignment1.Views;
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
    public class MainWindowViewModel : BindableBase
    {
        public DelegateCommand OpenWindowCommand { get; private set; }

        public MainWindowViewModel()
        {
            OpenWindowCommand = new DelegateCommand(ExecuteOpenWindowCommand);
        }
        public void ExecuteOpenWindowCommand()
        {
            AddDebtWindow objWindowShow = new AddDebtWindow();
            objWindowShow.Show();
        }
    }
}
