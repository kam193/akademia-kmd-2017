using MvvmCross.Core.ViewModels;

namespace Piller.Core.ViewModels
{
    public class StartViewModel : MvxViewModel
    {
        private string _text = "START VIEW PILLER";

        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }
    }
}
