using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FirstCWapplicationDevelopment
{
    public class RateMe
    {

        public String Criteria { get; set; }    
        public bool Excellent { get; set; }
        public bool Good { get; set; }
        public bool Average { get; set; }
        public bool Dissatisfied { get; set; }
        public DateTime TodayDate { get; set; }

        public static List<String> ReadCategory()
        {
            // reading categories from the text file 
            List<String> Categories = new List<string>();
            StreamReader sr = new StreamReader("../../../CategoryFile.txt");
            string line = sr.ReadLine();
            while (line != null)
            {
                Categories.Add(line);
                line = sr.ReadLine();
            }
            sr.Close();
            return Categories;
        }
        private static List<String> Rating()
        {
            List<String> rating = new List<string>();
            rating.Add("Excellent");
            rating.Add("Good");
            rating.Add("Average");
            rating.Add("Dissatisfied");
            return rating;
        }
       

        public void CreateXML()
        {
            List<string> category = ReadCategory();
            List<String> ratings = Rating();
            var rateXml = new XDocument();

            //adding root element
            var rootElement = new XElement("Ratings");
            rateXml.Add(rootElement);

            //adding user node in the xml file
            var userElem = new XElement("Users");
            userElem.Value = "0";
            rootElement.Add(userElem);

            //adding dates node in the xml file
            var datesElem = new XElement("Rated_Dates");
            rootElement.Add(datesElem);

            foreach(String item in category)
            {
                var re = item.Replace(" ", "_");
                var criteriaElem = new XElement("Criteria");
                var childElem = new XElement(re);
                foreach(String i in ratings)
                {
                    var child = new XElement(i, 0);
                    childElem.Add(child);
                }
                criteriaElem.Add(childElem);
                rootElement.Add(criteriaElem);
            }
            // have to add the system own path
            rateXml.Save(@"C:\.NetProjects\FirstCWapplicationDevelopment\rates.xml");
        }


        public void updateXML(List<String> customerRating, string ratedDated)
        {
            XDocument rating = XDocument.Load("../../../rates.xml");
            System.Windows.Forms.MessageBox.Show("Xml file loaded");
            List<string> category = ReadCategory();
            List<String> ratings = Rating();

            foreach (String item in category)
            {
                var re = item.Replace(" ", "_");
                var elem = (from xml2 in rating.Descendants("Criteria").Elements()
                            where xml2.Name == re
                            select xml2.Name).FirstOrDefault();
                if (elem == null)
                {
                    XElement newNode = new XElement("Criteria",
                        new XElement(re,
                        new XElement ("Excellent", 0),
                        new XElement ("Good", 0),
                        new XElement ("Average", 0),
                        new XElement ("Dissatisfied", 0)
                        )
                        );
                    rating.Element("Ratings").Add(newNode);
                    //afno path deu
                    rating.Save(@"C:\.NetProjects\FirstCWapplicationDevelopment\rates.xml");
                }    
            }

            //getting value from Users node 
            var userVal = (from xml2 in rating.Descendants() 
                        where xml2.Name == "Users" 
                        select xml2.Value).FirstOrDefault();
            var userRoot = rating.Root.Descendants("Users").FirstOrDefault(); //getting Users node
            int userV = (int.Parse(userVal) + 1); //adding value by 1 
            userRoot.Value = userV.ToString(); //updating the new value

            //getting Rated_Dates node
            var dateRoot = rating.Root.Descendants("Rated_Dates").FirstOrDefault();
            XElement newDateNode = new XElement("Date",ratedDated); //adding new Date node along with the cureent date and time
            dateRoot.Add(newDateNode); //adding the new date node

            //afno path deu
            rating.Save(@"C:\.NetProjects\FirstCWapplicationDevelopment\rates.xml");

            for (int i =0; i< customerRating.Count; i=i+2 )
            {
                var firstElem = customerRating[i];
                var re = firstElem.Replace(" ", "_");
                var rated = customerRating[i + 1];
                var value = (from xml2 in rating.Descendants(re).Elements()
                             where xml2.Name == rated
                             select xml2.Value).FirstOrDefault();
                var a = rating.Root.Descendants("Criteria").Descendants(re).Descendants(rated).FirstOrDefault();
                int val = (int.Parse(value) + 1);
                a.Value = val.ToString();
                //afno path deu
                rating.Save(@"C:\.NetProjects\FirstCWapplicationDevelopment\rates.xml");
            }
        }

        public static Dictionary<string,int> getTotal()
        {
            Dictionary<string, int> total_dict = new Dictionary<string, int>();
            try
            {
                XDocument rating = XDocument.Load("../../../rates.xml");
                // System.Windows.Forms.MessageBox.Show("Xml file loaded");
                List<string> category = ReadCategory();
                List<String> ratings = Rating();
                foreach (String r in ratings)
                {
                    total_dict.Add(r, 0);
                }
                foreach (String c in category)
                {
                    var item = c.Replace(" ", "_");
                    foreach (String r in ratings)
                    {
                        var value = (from xml2 in rating.Descendants(item).Elements()
                                     where xml2.Name == r
                                     select xml2.Value).FirstOrDefault();
                        int val = (int.Parse(value));
                        total_dict[r] += val;
                    }
                }
                var userVal = (from xml2 in rating.Descendants()
                               where xml2.Name == "Users"
                               select xml2.Value).FirstOrDefault();
                int userV = (int.Parse(userVal));
                total_dict.Add("Users", userV);

            }
            catch
            {
                MessageBox.Show("No xml file");
            }

            return total_dict;
        }
    }
}
