using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMgmtModule.ViewModels
{
    public class NewProjectViewModel : BindableBase
    {
        public DelegateCommand ExecuteCommand { get; private set; }

        public NewProjectViewModel()
        {
            ExecuteCommand = new DelegateCommand(Execute);
        }

        private void Execute()
        {
            //
        }

    }
}
