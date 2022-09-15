using HomeValue.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeValue.Data
{
    public class DbObject
    {
        //Метод проверяет БД, и заполняет её, если она пустая
        public static void Initial(AppDbContent content)
        {
            if (!content.Elements.Any())
            {
                content.Elements.Add(new Element { Name = "фундамент", JobPrice = 3000, MaterialPrice = 6000 });
                content.Elements.Add(new Element { Name = "стены", JobPrice = 2500, MaterialPrice = 3500 });
                content.Elements.Add(new Element { Name = "крыша", JobPrice = 2000, MaterialPrice = 4000 });
            }
            content.SaveChanges();
        }
    }
}
