using DotNetLabs.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLabs.Services
{
    public class ComparePersonsDateService
    {
        private static ComparePersonsDateService _instance;
        private ComparePersonsDateService()
        {

        }

        public static ComparePersonsDateService GetInstance()
        {
            if(_instance == null)
            {
                _instance = new ComparePersonsDateService();
            }
            return _instance;
        }

        public string GetResult(PersonDto person1, PersonDto person2, string compareType)
        {
            switch(DateTime.Compare(person1.Date, person2.Date))
            {
                case 1:
                    if (compareType == "Старше")
                    {
                        return $"{person2.Fio} старше {person1.Fio}";
                    }
                    else return $"{person1.Fio} младше {person2.Fio}";
                case -1:
                    if (compareType == "Старше")
                    {
                        return $"{person1.Fio} старше {person2.Fio}";
                    }
                    else return $"{person2.Fio} младше {person1.Fio}";
                default:
                    return "Одинаковый возраст";
            }
        }

    }
}
