using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class RegionsDAL : AbstractBase<Region>
    {
        private SalesDBEntities entities = new SalesDBEntities();

        public User GetEntity()
        {
            User entity = new User();
            return entity;
        }
    }
}
