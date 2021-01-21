using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCWapplicationDevelopment
{
    class CatogeryAdditionAdmin
    {
        public String categoryName;
        List<String> CategoriesList = new List<String>();
        public CatogeryAdditionAdmin(string categoryName) {

            this.categoryName = categoryName;
            CategoriesList.Add(categoryName);
            WriteCategory(categoryName);
        }

        static void WriteCategory(String category)
        {
            // writing the category to text file
            StreamWriter sw = new StreamWriter("../../../CategoryFile.txt",true);
            sw.WriteLineAsync(category);
            sw.Close();
        }

        

    }
}
