using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piller.Core.Model
{
    public class Medicin
    {
        public string MedicineName
        {
            get; set;
        }

        public string MedicineDose
        {
            get; set;
        }

        public List<DayOfWeek> MedicineDays
        {
            get; set;
        }

        public Medicin(string name, string dose, List<DayOfWeek> days)
        {
            MedicineName = name;
            MedicineDose = dose;
            MedicineDays = days;
        }
    }
}
