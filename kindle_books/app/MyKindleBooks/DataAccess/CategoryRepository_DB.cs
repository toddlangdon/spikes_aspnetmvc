using System.Collections.Generic;
using MyKindleBooks.Domain;
using NHibernate;

namespace MyKindleBooks.DataAccess
{
    public class CategoryRepository_DB : ICategoryRepository
    {

        public IList<Category> GetAllCategoriesWithSubcategories(ISession session) {
            IQuery query = session.CreateQuery("FROM Category");
            IList<Category> categories = query.List<Category>();
            return categories;
        }

//        public IList<Subcategory> GetAllSubcategories(ISession session) {
//            IQuery query = session.CreateQuery("From Subcategory");
//            IList<Subcategory> subCategories = query.List<Subcategory>();
//            return subCategories;
//        }

    }
}