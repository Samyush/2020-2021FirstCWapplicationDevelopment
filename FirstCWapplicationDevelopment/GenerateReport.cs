using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FirstCWapplicationDevelopment
{
    public static class GenerateReport
    {
        public static List<String> getDates()  //getting rated dates from xml file
        {
            List<String> ratedDates = new List<string>();
            try
            {
                XDocument rating = XDocument.Load("../../../rates.xml");
                //getting all the date value from xml file
                var dateVal = (from xml2 in rating.Descendants("Date")
                               select xml2.Value);
                //adding each date in the list
                foreach (var val in dateVal)
                {
                    ratedDates.Add(val);
                }
            }
            catch { MessageBox.Show("No xml file"); }
            return ratedDates;
        }
        public static void ToCSV(Dictionary<string, int> dict)
        {
            List<String> dates = getDates();
            StreamWriter sw = new StreamWriter("../../../reports.csv");
            sw.WriteLine("Rating Reports:" + Environment.NewLine + Environment.NewLine); //adding blank lines in the csv file
            // adding every item in the dictionary to csv file
            foreach (var item in dict)
            {
                sw.WriteLine(String.Format("{0},{1}", item.Key, item.Value));
            }
            sw.WriteLine(Environment.NewLine + Environment.NewLine);
            sw.WriteLine("Rated Dates:" + Environment.NewLine);
            // adding all the date values to the csv file
            foreach (var date in dates)
            {
                String[] splitted = date.Split(new char[] { ' ' }); //splitting date, time and am/pm and putting in a list
                sw.WriteLine(String.Format("{0},{1},{2}", splitted[0], splitted[1], splitted[2]));  //writing the splitted values into separate cells in excel
                
            }
            sw.Close();
            MessageBox.Show("Report generated");
        }
    }
}
