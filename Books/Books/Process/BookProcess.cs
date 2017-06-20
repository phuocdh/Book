using FastMember;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Process
{
    public class BookProcess
    {
        public static bool AddBooks(Book book)
        {
            try
            {
                using (var bookEntities = new BookEntities())
                {
                    bookEntities.Books.Add(book);
                    bookEntities.SaveChanges();
                    return true;
                }
            }
            catch
            {

            }
            return false;
        }

        public static bool UpdateBooks(Book book)
        {
            try
            {
                using (var bookEntities = new BookEntities())
                {
                    bookEntities.Entry(book).State = System.Data.Entity.EntityState.Modified;
                    bookEntities.SaveChanges();
                    return true;
                }
            }
            catch
            {

            }
            return false;
        }

        public static bool DeleteBooks(string id)
        {
            try
            {
                using (var bookEntities = new BookEntities())
                {
                    Book book = bookEntities.Books.First(x => x.Id.Equals(id));
                    bookEntities.Books.Remove(book);
                    bookEntities.SaveChanges();
                    return true;
                }
            }
            catch
            {

            }
            return false;
        }

        public static DataTable SelectBooks()
        {
            using (var bookEntities = new BookEntities())
            {
                List<spGetBooks_Result> book = bookEntities.spGetBooks().ToList();
                DataTable table = new DataTable();
                using (var reader = ObjectReader.Create(book))
                {
                    table.Load(reader);
                }
                return table;
            }
        }
    }
}
