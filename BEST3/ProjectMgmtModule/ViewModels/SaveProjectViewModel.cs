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
    public class SaveProjectViewModel : BindableBase
    {
        public DelegateCommand ExecuteCommand { get; private set; }

        public SaveProjectViewModel()
        {
            ExecuteCommand = new DelegateCommand(Execute);
        }

        private void Execute()
        {
            //
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == true)
            {

            }
        }
    }
}
