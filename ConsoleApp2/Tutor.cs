using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    sealed class Tutor : Employee // Запечатаный класс - запрещает наследоваться от него.
    {
        public TutorSpeciality tutorSpeciality;

        public Tutor() : base()
        {

        }
        public Tutor(string name, string surname, string patronymic, DateTime birthDate,
                        Gender gender, Nationality nationality, EducationLevel educationLevel, float salary,
                        TutorSpeciality tutSpec)
            : base(name, surname, patronymic, birthDate, gender, nationality, educationLevel, salary)
        {
            tutorSpeciality = tutSpec;
        }
        public override string ToString()
        {
            return base.ToString() + $"\n\tTutorSpeciality: {tutorSpeciality}; ";
        }

    }
}
