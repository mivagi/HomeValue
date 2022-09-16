using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeValue.Data.Models
{
    //Модель для хранения уже расчитанной стоимости работы и материала
    public class EstimateItem
    {
        public float Volume { get; set; }
        public float Price { get; set; }
        public Parameter Parameter { get; set; }
    }
}
