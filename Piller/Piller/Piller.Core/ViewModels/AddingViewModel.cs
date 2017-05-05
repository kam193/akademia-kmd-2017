using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace Piller.Core.ViewModels
{
    public class AddingViewModel : MvxViewModel
    {
        private string _medicineName;

        public string MedicineName
        {
            get { return _medicineName; }
            set { SetProperty(ref _medicineName, value); }
        }

        private string _medicineDose;

        public string MedicineDose
        {
            get { return _medicineDose; }
            set { SetProperty(ref _medicineDose, value); }
        }

        private List<DayOfWeek> _medicineDays = new List<DayOfWeek>();

        public List<DayOfWeek> MedicineDays
        {
            get { return _medicineDays; }
            set { _medicineDays = value; }
        }

        public ICommand AddMedicine
        {
            get
            {
                return new MvxCommand(() => addMedicineToList());
            }
        }

        private void addMedicineToList()
        {
            var m = new Model.Medicin(_medicineName, _medicineDose, _medicineDays);
            Model.Medicins.MedicinsList.Add(m);
            ShowViewModel<StartViewModel>();
        }


    }
}
