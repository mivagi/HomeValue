using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeValue.Data.Models
{
    //Класс для хранения введенных пользователем данных
    public class Parameter
    {
        public string Name { get; set; }
        public float Length { get; set; }
        public float Higth { get; set; }
        public float Width { get; set; }
        public float JobPrice { get; set; }
        public float MaterialPrice { get; set; }
    }
}
