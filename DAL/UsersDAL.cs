using System.Linq;

namespace DAL
{
    public class UsersDAL : AbstractBase<User>
    {
        private SalesDBEntities entities = new SalesDBEntities();

        public User GetEntity()
        {
            User entity = new User();
            return entity;
        }

        public int LoginCount(string _email, string _password)
        {
            var count = entities.User.Where(u => u.Email == _email && u.Password == _password).Count();
            //var count (from u in entities.User where u.Email == _email && u.Password == _password  select u).Count();

            if (count == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public User GetObjByLogin(string _email, string _password)
        {
            User obj = (from u in entities.User where u.Email == _email && u.Password == _password select u).First();

            return obj;
        }
    }
}
