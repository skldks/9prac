using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9prac
{
    class Worker_Father
    {
        public string FirstName { get; set; }

        public string SurName { get; set; }

        public string Patronymic { get; set; }
        public Worker_Father(string firstName, string surName, string patronymic)
        {
            FirstName = firstName;
            Patronymic = patronymic;
            SurName = surName;
        }
    }
}
