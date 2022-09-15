using HomeValue.Data.Interfaces;
using HomeValue.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeValue.Data.Mocks
{
    //Временный класс изображающий БД и взаимодействующий с ней. Впоследствии будет удален
    public class MockElements : IAllElements
    {
        public IEnumerable<Element> Elements {
            get
            {
                return new List<Element> {
                    new Element { Name = "фундамент", JobPrice = 3000, MaterialPrice = 6000 },
                    new Element { Name = "стены", JobPrice = 2500, MaterialPrice = 3500 },
                    new Element { Name = "крыша", JobPrice = 2000, MaterialPrice = 4000 }
                 };
            }
        }

        public Element GetOneElement(int id)
        {
            throw new NotImplementedException();
        }
    }
}
