using HomeValue.Data.Interfaces;
using HomeValue.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeValue.Data.Repository
{
    //Класс для взаимодействия с БД
    public class ElementRepository : IAllElements
    {
        private readonly AppDbContent content;

        public ElementRepository(AppDbContent content)
        {
            this.content = content;
        }
        public IEnumerable<Element> Elements => content.Elements;

        public Element GetOneElement(int id)
        {
            return content.Elements.FirstOrDefault(e => e.Id == id);
        }
    }
}
