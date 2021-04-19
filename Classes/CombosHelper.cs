using ECommerce.Models;
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
            IList<Departaments> dep = db.Departaments.ToList();
            dep.Add(new Departaments
            {
                DepartamentsId = 0,
                Name = "[ Selecione um Departamento ]"
            });

            dep = dep.OrderBy(d => d.Name).ToList();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}