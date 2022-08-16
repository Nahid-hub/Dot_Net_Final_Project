using DAL.EF;
using DAL.Interfaces;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static Easy_TravelsEntities db = new Easy_TravelsEntities();
        public static IRepo<HotelReg, int,bool> GetHotelRegDataAccess()
        {
            return new HotelRegRepo(db);
        }
        public static IRepo<RoomList, int,bool> GetRoomListDataAccess()
        {
            return new RoomListRepo(db);
        }
        public static IRepo<Inq, int,bool> GetInqDataAccess()
        {
            return new InqRepo(db);
        }
        public static IRepo<Report, int,bool> GetReportDataAccess()
        {
            return new ReportRepo(db);
        }
        public static IRepo<BookedHotel, int,bool> GetBookedHotelDataAccess()
        {
            return new BookedHotelRepo(db);
        }
        public static IAuth<HotelReg> GetAuthDataAccess()
        {
            return new HotelRegRepo(db);
        }
        public static IRepo<Token, string, Token> GetTokenDataAccess()
        {
            return new TokenRepo(db);
        }
    }
}
