using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class InqRepo : IRepo<Inq, int, bool>
    {
        Easy_TravelsEntities db;
        public InqRepo(Easy_TravelsEntities db)
        {
            this.db = db;
        }
        public bool Create(Inq obj)
        {
            db.Inqs.Add(obj);
            var res = db.SaveChanges();
            return res > 0;
        }

        public bool Delete(int id)
        {
            db.Inqs.Remove(db.Inqs.FirstOrDefault(e => e.Id == id));
            var res = db.SaveChanges();
            return res == 0;
        }

        public List<Inq> Get()
        {
            return db.Inqs.ToList();
        }

        public Inq Get(int id)
        {
            return db.Inqs.Find(id);
        }

        public bool Update(Inq obj)
        {
            var data = db.Inqs.FirstOrDefault(e => e.Id == obj.Id);
            data.Name = obj.Name;
            data.Question = obj.Question;
            data.Answer = obj.Answer;
            db.SaveChanges();
            return true;
        }
    }
}
