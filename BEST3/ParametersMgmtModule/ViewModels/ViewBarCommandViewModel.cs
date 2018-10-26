using ParametersMgmtModule.Commands;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersMgmtModule.ViewModels
{
    public class ViewBarCommandViewModel : BindableBase
    {
        private IViewCommands _viewCommands;
        public IViewCommands ViewCommands
        {
            get { return _viewCommands; }
            set { SetProperty(ref _viewCommands, value); }
        }

        public ViewBarCommandViewModel(IViewCommands viewCommands)
        {
            _viewCommands = viewCommands;
        }
    }
}
