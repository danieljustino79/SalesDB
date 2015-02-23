using System;
using DAL;
using System.Text;
using System.Security.Cryptography;

namespace BLL
{
    public class UserBLL : UsersDAL
    {
        public void Add(string name, string email, string password, int levelId)
        {
            UsersDAL dal = new UsersDAL();
            var entity = dal.GetEntity();
            entity.Name = name;
            entity.Email = email;
            entity.Password = MD5(password);
            entity.LevelId = levelId;
            entity.DateCreation = DateTime.Now;
            dal.Add(entity);
            dal.SaveChanges();
        }

        public string MD5(string word)
        {
            using (MD5 hashCreate = System.Security.Cryptography.MD5.Create())
            {
                byte[] data = hashCreate.ComputeHash(Encoding.UTF8.GetBytes(word));
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                return sBuilder.ToString();
            }
        }

        public int LoginCount(string email, string password)
        {
            UsersDAL dal = new UsersDAL();
            password = MD5(password);

            return dal.LoginCount(email, password);
        }

        public User GetObjByLogin(string email, string password)
        {
            UsersDAL dal = new UsersDAL();
            password = MD5(password);

            return dal.GetObjByLogin(email, password);
        }
    }
}

