using FastMember;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Process
{
    public class AuthorProcess
    {
        public static bool AddAuthor(Author author)
        {
            try
            {
                using (var bookEntities = new BookEntities())
                {
                    bookEntities.Authors.Add(author);
                    bookEntities.SaveChanges();
                    return true;
                }
            }
            catch
            {

            }
            return false;
        }

        public static bool UpdateAuthor(Author author)
        {
            try
            {
                using (var bookEntities = new BookEntities())
                {
                    bookEntities.Entry(author).State = System.Data.Entity.EntityState.Modified;
                    bookEntities.SaveChanges();
                    return true;
                }
            }
            catch
            {

            }
            return false;
        }

        public static bool DeleteAuthor(string authorId)
        {
            try
            {
                using (var bookEntities = new BookEntities())
                {
                    Author author = bookEntities.Authors.First(x => x.Id.Equals(authorId));
                    bookEntities.Authors.Remove(author);
                    bookEntities.SaveChanges();
                    return true;
                }
            }
            catch
            {

            }
            return false;
        }

        public static DataTable SelectAuthor()
        {
            using (var bookEntities = new BookEntities())
            {
                List<spGetAuthor_Result> author = bookEntities.spGetAuthor().ToList();
                DataTable table = new DataTable();
                using (var reader = ObjectReader.Create(author))
                {
                    table.Load(reader);
                }
                return table;

            }
        }
    }
}
