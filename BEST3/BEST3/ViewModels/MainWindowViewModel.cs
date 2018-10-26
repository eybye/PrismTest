using Prism.Mvvm;

namespace BEST3.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "BEST 3";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
