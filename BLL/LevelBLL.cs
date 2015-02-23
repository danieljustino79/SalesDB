using DAL;
using System;

namespace BLL
{
    public class LevelBLL : LevelDAL
    {
        public void Add(string name)
        {
            LevelDAL levelDal = new LevelDAL();
            var entity = levelDal.GetEntity();
            entity.Name = name;
            entity.DateCreation = DateTime.Now;
            levelDal.Add(entity);
            levelDal.SaveChanges();
        }
    }
}
