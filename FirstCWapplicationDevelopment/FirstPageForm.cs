using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;



namespace FirstCWapplicationDevelopment
{
    public partial class FirstPageForm : Form
    {


       public FirstPageForm()
        {
            InitializeComponent();
            catogeryChart.Visible = false;

            //RateMe.ReadCategory() is defined as static class so it is easier and reuse of the code

            catogeryList.DataSource = RateMe.ReadCategory();
            ratedata();
            rateMe_Enter();
            ratedDatagridview2();

        }

        private void login_Click(object sender, EventArgs e)
        {

            Console.WriteLine("test success");
            //checkLogin.Name = nameTxt.Text;
            //checkLogin.Password = passTxt.Text;
            try
            {
                if (nameTxt.Text == "admin" && passTxt.Text == "admin")
                {

                    catogeryChart.Visible = true;
                    //validations
                    MessageBox.Show("WELCOME TO ADMIN PANNEL");

                }
                else
                {
                    MessageBox.Show("NOT AUTHORIZED");
                    catogeryChart.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void catogeryAddition_Click(object sender, EventArgs e)
        {
            if (catogeryAddTxt.Text == "")
            {

                MessageBox.Show("Please add Something");

            }
            else
            {
                CatogeryAdditionAdmin category = new CatogeryAdditionAdmin(catogeryAddTxt.Text);

                //RateMe.ReadCategory() is defined as static class so it is easier and reuse of the code

                catogeryList.DataSource = RateMe.ReadCategory();
                catogeryAddTxt.Text = "";
                MessageBox.Show("Success");
                //ratedata();
                //rateMe_Enter();

                FirstPageForm fr = new FirstPageForm();
                fr.Show();
                this.Hide();
            }

        }

        private void catogeryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }


        static void Reset()
        {
            // clearing the txt file
            File.WriteAllBytes("../../../CategoryFile.txt", new byte[0]);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Reset();
            //RateMe.ReadCategory() is defined as static class so it is easier and reuse of the code
            catogeryList.DataSource = RateMe.ReadCategory();

        }

        private void todayDate_ValueChanged(object sender, EventArgs e)
        {
            //if we want not to change todays date 
            //todayDate.Enabled = false;
        }

        DataTable table = new DataTable();
        DateTime now = DateTime.Now;
        
        private void rateMe_Enter()
            //method to add date to datagrid
        {
            var shortDateValue = now.ToShortDateString();
            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    if (column.Index == 5)
                    {
                        row.Cells[column.Index].Value = shortDateValue;
                    }
                }
            }
        }

        private void ratedata()
        {
            //DataTable table = new DataTable();
            table.Columns.Add("Criteria", typeof(string));
            table.Columns.Add("Excellent", typeof(string));
            table.Columns.Add("Good", typeof(string));
            table.Columns.Add("Average", typeof(string));
            table.Columns.Add("Dissatisfied", typeof(string));
            table.Columns.Add("Date", typeof(string));

            //adds text file in rate me datagridview

            string[] lines = File.ReadAllLines("../../../CategoryFile.txt");

            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(',');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }

                table.Rows.Add(row);
            }
            dataGridView1.DataSource = table;
        }

        private void rateBtn_Click(object sender, EventArgs e)
        {
            RateMe xml = new RateMe();
            List<string> rate = new List<string>();
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        if (column.Index != 0 && column.Index != 5)
                        {
                            bool a = Convert.ToBoolean(row.Cells[column.Index].Value);
                            if (a)
                            {
                                string criteria = Convert.ToString(row.Cells[0].Value);
                                string header = dataGridView1.Columns[column.Index].HeaderText;
                                rate.Add(criteria);
                                rate.Add(header);
                            }

                        }
                    }
                }
                //Console.WriteLine(rate);
                //Checking if the xml file is present or not
                bool exist = File.Exists("../../../rates.xml");
                if (!exist)
                {
                    MessageBox.Show("No xml file");
                    //creating a xml file if it does not exist.

                    xml.CreateXML();
                }
                else {
                    MessageBox.Show("Rating Completed, Xml file present");
                }
                xml.updateXML(rate,now.ToString());
                
                
                FirstPageForm fr = new FirstPageForm();

                fr.Show();
                this.Hide();



            }
            catch
            {
                MessageBox.Show("Please rate all the criteria");
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    if (e.RowIndex == row.Index) {
                        if (column.Index != 0 && column.Index != 5)
                        {
                            if (e.ColumnIndex != column.Index)
                            {
                                row.Cells[column.Index].Value = false;
                            }
                            else
                            {
                                row.Cells[column.Index].Value = true;
                            }
                        }
                        
                    }
                    
                }
              
            }


        }

        private void ascendingDateSortBtn_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void ratedDatagridview2()
        {

            DataTable table2 = new DataTable();
            table2.Columns.Add("Criteria", typeof(string));
            table2.Columns.Add("Rating", typeof(int));

            Dictionary<string,int> dict=RateMe.getTotal();
            foreach (KeyValuePair<string, int> rate in dict)
            {
                table2.Rows.Add(rate.Key, rate.Value);
            }
            
            dataGridView2.DataSource = table2;
        }

        //checks if the code is fine

        private void FirstPageForm_Load(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    this.chart1.Series["ServiceRating"].Points.AddXY(dataGridView2.Rows[i].Cells[0].Value.ToString(), Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value.ToString()));
                }
                MessageBox.Show("Welcome to the Application, Click OK to continue");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Graph did not load");
            }
        }

        //bubble sort ascending

        private void ascendingSortRateBtn_Click(object sender, EventArgs e)
        {
            dataGridView2.Sort(dataGridView2.Columns[1], ListSortDirection.Ascending);

            int[] a = new int[7] { 1, 2, 3, 4, 5, 6, 7 };

            //a = [1,2,3,4,5,6,7,8];

            bubblesort(a);

            //trying bubble sort

            //using bubble sort algorithm
            //Registration r = new Registration();
            int[] listStudents = a;
            int n = listStudents.Count();
            bool change;
            int[] temp = new int[7];
            //Registration temp;

            change = false;
            for (int i = 0; i < n - 1; i++)
            {
                //if the value is less than 0 the data must be arranged in descending manner
                if (i < temp.Length)
                {
                    // temp = listStudents[i];

                    listStudents[i] = listStudents[i + 1];
                    listStudents[i + 1] = 7;
                    change = true;

                }
            }
        }

        //bubble sort descending

        private void descendingSortRateBtn_Click(object sender, EventArgs e)
        {
            dataGridView2.Sort(dataGridView2.Columns[1], ListSortDirection.Descending);

            int[] a = new int[7] { 1,2,3,4,5,6,7};
            
            //a = [1,2,3,4,5,6,7,8];

            bubblesort(a);

            //trying bubble sort

            //using bubble sort algorithm
            //Registration r = new Registration();
            int[] listStudents = a;
            int n = listStudents.Count();
            bool change;
            int[] temp = new int[7];
            //Registration temp;
            
                change = false;
                for (int i = 0; i < n - 1; i++)
                {
                    //if the value is less than 0 the data must be arranged in descending manner
                    if (i < temp.Length)
                    {
                       // temp = listStudents[i];

                        listStudents[i] = listStudents[i + 1];
                        listStudents[i + 1] = 7;
                        change = true;

                    }
                }
            //}
            

        }

        // bubble sort algorithm
        static void bubblesort(int[] array)
        {
            int len = array.Length;

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    int a = array[j];
                    if (a != array[len - 1])
                    {
                        int b = array[j + 1];
                        if (a > b)
                        {
                            array[j] = b;
                            array[j + 1] = a;
                        }
                    }
                }
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            FirstPageForm fr = new FirstPageForm();
            fr.Show();
            this.Hide();
            
        }

        private void generateReport_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> dict = RateMe.getTotal();
            GenerateReport.ToCSV(dict);
        }

        private void openReport_Click(object sender, EventArgs e)
        {
            //afno path deu     
           
            
            var filePath = "C:\\.NetProjects\\FirstCWapplicationDevelopment\\reports.csv"; //giving path of the csv file

            Process.Start(filePath); //opening the csv file
        }

        
    }
}

