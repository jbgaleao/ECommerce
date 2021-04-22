﻿using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerce.Classes
{
    public class CombosHelper:IDisposable
    {
        private static ECommerceContext db = new ECommerceContext();

        public static List<Departaments> GetDepartments()
        {
            var dep = db.Departaments.ToList();
            dep.Add(new Departaments {
                DepartamentsId = 0,
                Name = "[ Selecione um Departamento ]"
            });
            
            return dep.OrderBy(d => d.Name).ToList();
        }

        public static List<City> GetCities()
        {
            var city = db.Cities.ToList();
            city.Add(new City
            {
                CityId = 0,
                Name = "[ Selecione ua Cidade ]"
            });

            return city.OrderBy(d => d.Name).ToList();
        }


        public void Dispose()
        {
            db.Dispose();
        }
    }
}