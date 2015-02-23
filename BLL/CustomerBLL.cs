using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using DAL;

namespace BLL
{
    public class CustomerBLL : DAL.CustomersDAL
    {
        public IList GetVW()
        {
            CustomersDAL dal = new CustomersDAL();

            return dal.GetVW();
        }
    }
}
