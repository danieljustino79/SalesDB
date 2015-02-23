using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace DAL
{
    public class CustomersDAL : AbstractBase<Customer>
    {
        private SalesDBEntities entities = new SalesDBEntities();

        

        public User GetEntity()
        {
            User entity = new User();
            return entity;
        }

        public IList GetVW()
        {
            //var vw = (from c1 in entities.Customer
            //          join c2 in entities.City on c1.CityId equals c2.CityId
            //          select new { Customer = c1, c2 = CustomerCity }).ToList();

            var vw2 = entities.Customer.Join(entities.City,
                c1 => c1.CityId, c2 => c2.CityId,
                (c1, c2) => new { Customer = c1, City = c2 }).ToList();

            return vw2;



        }


    }
}
