using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class CitiesDAL : AbstractBase<City>
    {
        private SalesDBEntities entities = new SalesDBEntities();

        public User GetEntity()
        {
            User entity = new User();
            return entity;
        }
    }
}
