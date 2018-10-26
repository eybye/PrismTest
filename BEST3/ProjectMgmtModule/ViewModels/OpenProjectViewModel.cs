using Microsoft.Win32;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMgmtModule.ViewModels
{
    public class OpenProjectViewModel : BindableBase
    {
        public DelegateCommand ExecuteCommand { get; private set; }

        public OpenProjectViewModel()
        {
            ExecuteCommand = new DelegateCommand(Execute);
        }

        private void Execute()
        {
            //
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == true)
            {

            }
        }
    }
}
