﻿using HomeValue.Data.Infrastruction;
using HomeValue.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeValue.Data.Repository
{
    //Класс для создания сессии и сохранения в нее стоимости работ и материалов, а так же получения данных из сессии
    public class Estimate
    {
        private List<EstimateItem> listEstimateItems = new List<EstimateItem>();
        [JsonIgnore]
        public ISession Session { get; set; }
        public static Estimate GetEstimate(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            Estimate estimate = session.GetJson<Estimate>("EstimateId") ?? new Estimate();
            estimate.Session = session;
            return estimate;
        }
        public void AddEstimeteItem(Parameter param, float price)
        {
            listEstimateItems.Add(
                new EstimateItem { 
                    Parameter = param, 
                    Volume = param.Higth * param.Length * param.Width,
                    Price = param.Higth * param.Length * param.Width * price
                });
            Session.SetJson("EstimateId", this);
        }
        public IEnumerable<EstimateItem> Estimates => listEstimateItems;
        public float TotalPrice() => listEstimateItems.Sum(s => s.Price);
    }
}
