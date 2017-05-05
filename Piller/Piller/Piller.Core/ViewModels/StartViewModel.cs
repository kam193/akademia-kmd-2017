using MvvmCross.Core.ViewModels;
using System.Windows.Input;
using System.Collections.Generic;

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

        public ICommand GoToAdd
        {
            get { return new MvxCommand(() => ShowViewModel<AddingViewModel>()); }
        }

        public List<Model.Medicin> ListOfMedicins
        {
            get { return Model.Medicins.MedicinsList; }
            //set { SetProperty(ref Model.Medicins.MedicinsList, value); }
        }

    }
}
