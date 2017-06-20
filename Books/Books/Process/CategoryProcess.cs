using FastMember;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Process
{
    public class CategoryProcess
    {
        public static bool AddCategory(Category category)
        {
            try
            {
                using (var bookEntities = new BookEntities())
                {
                    bookEntities.Categories.Add(category);
                    bookEntities.SaveChanges();
                    return true;
                }
            }
            catch
            {

            }
            return false;
        }

        public static bool UpdateCategory(Category category)
        {
            try
            {
                using (var bookEntities = new BookEntities())
                {
                    bookEntities.Entry(category).State = System.Data.Entity.EntityState.Modified;
                    bookEntities.SaveChanges();
                    return true;
                }
            }
            catch
            {

            }
            return false;
        }

        public static bool DeleteCategory(string categoryId)
        {
            try
            {
                using (var bookEntities = new BookEntities())
                {
                    Category category = bookEntities.Categories.First(x => x.Id.Equals(categoryId));
                    bookEntities.Categories.Remove(category);
                    bookEntities.SaveChanges();
                    return true;
                }
            }
            catch
            {

            }
            return false;
        }

        public static DataTable SelectCategory()
        {
            using (var bookEntities = new BookEntities())
            {
                List<spGetCategory_Result> category = bookEntities.spGetCategory().ToList();
                DataTable table = new DataTable();
                using (var reader = ObjectReader.Create(category))
                {
                    table.Load(reader);
                }
                return table;

            }
        }
    }
}
