using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class BookedHotelRepo : IRepo<BookedHotel, int,bool>
    {
        Easy_TravelsEntities db;
        public BookedHotelRepo(Easy_TravelsEntities db)
        {
            this.db = db;
        }
        public bool Create(BookedHotel obj)
        {
            db.BookedHotels.Add(obj);
            var res = db.SaveChanges();
            return res > 0;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<BookedHotel> Get()
        {
            return db.BookedHotels.ToList();
        }

        public BookedHotel Get(int id)
        {
            return db.BookedHotels.Find(id);
        }

        public bool Update(BookedHotel obj)
        {
            throw new NotImplementedException();
        }
    }
}
