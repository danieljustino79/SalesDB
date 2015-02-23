namespace DAL
{
    public class LevelDAL : AbstractBase<Level>
    {
        private SalesDBEntities entities = new SalesDBEntities();

        public Level GetEntity()
        {
            Level entity = new Level();
            return entity;
        }
    }
}
