using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class TokenRepo : IRepo<Token, string, Token>
    {
        Easy_TravelsEntities db;
        public TokenRepo(Easy_TravelsEntities db)
        {
            this.db = db;
        }

        public Token Create(Token obj)
        {
            db.Tokens.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Token> Get()
        {
            return db.Tokens.ToList();
        }

        public Token Get(string token)
        {
            return db.Tokens.FirstOrDefault(t => t.TokenKey.Equals(token));
        }

        public bool Update(Token obj)
        {
            var exst = db.Tokens.FirstOrDefault(x => x.TokenKey.Equals(obj.TokenKey));
            if (exst != null)
            {
                db.Entry(exst).CurrentValues.SetValues(obj);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
