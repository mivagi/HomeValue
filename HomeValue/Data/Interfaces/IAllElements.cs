using HomeValue.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeValue.Data.Interfaces
{
    //Интерфейс определяющий методы взаимодействия с БД
    public interface IAllElements
    {
        IEnumerable<Element> Elements { get; }
        void EditElement(Element element);
        Element GetOneElement(int id);
    }
}
