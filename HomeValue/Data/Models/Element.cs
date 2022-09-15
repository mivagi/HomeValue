using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeValue.Data.Models
{
    //Модель для хранения названия работ, стоимости работы и стоимости материалов 
    public class Element
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float JobPrice { get; set; }
        public float MaterialPrice { get; set; }
    }
}
