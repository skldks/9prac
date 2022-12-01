using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9prac
{
    class Worker : Worker_Father, ICloneable, IComparable, IPerson
    {
        public Worker(string firstName, string surName, string patronymic) : base(firstName, surName, patronymic)
        {
            FirstName = firstName;
            Patronymic = patronymic;
            SurName = surName;
        }
        public int CompareTo(object obj)
        {
            Worker worker = (Worker)obj;
            if (SurName == worker.SurName) return 1;
            if (SurName != worker.SurName) return -1;
            return 0;
        }
        public Worker ShallowClone()
        {
            return (Worker)MemberwiseClone();
        }
        public object Clone()
        {
            return new Worker(FirstName, SurName, Patronymic);
        }
    }
}
