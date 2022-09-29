using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace DeviceManagement_WebApp.Repository
{
    public class CategoriesRepository           //CattegoriesRepository links with CategoriesController and connects with the Database(CMPG323_P3)
    {
        protected readonly CMPG323_P3Context _context = new CMPG323_P3Context();        

        public List<Category> Getall()
        {
            return _context.Category.ToList();
        }
    }
}
