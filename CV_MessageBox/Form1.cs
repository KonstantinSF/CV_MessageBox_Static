using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console; 

namespace CV_MessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static void CVstart()
        {
            string filepath = "CV.txt";
            string CV_all; 
            string CVpart1=null, CVpart2=null, CVpart3 = null;
            int Average; 
            using (FileStream fr = new FileStream(filepath, FileMode.Open,  FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fr))
                {
                    CV_all =sr.ReadToEnd();
                    int separator1 = new Random().Next(0, 600);
                    int separator2 = new Random().Next(600, CV_all.Count());
                    new Random().Next(600, CV_all.Count());
                    for (int i=0; i<separator1 ;i++) CVpart1 += CV_all[i]; 
                    for (int i=separator1; i<separator2 ;i++) CVpart2 += CV_all[i];
                    for (int i=separator2; i<CV_all.Count();i++) CVpart3 += CV_all[i];
                    Average = CV_all.Count()/3;

                }
            }
                MessageBox.Show(CVpart1, "CV_Firulev_KS part 1", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                MessageBox.Show(CVpart2,"CV_Firulev_KS part 2", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                MessageBox.Show(CVpart3,$"CV_Firulev_KS part 3. Average num of symbols is {Average}", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        private void checkBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int X = this.Size.Width; 
            int Y = this.Size.Height;
            checkBox1.Location= new Point (new Random().Next(5,X-50),new Random().Next(5,Y-70)); 
            //MessageBox.Show($"{e.Location.X} {e.Location.Y}"); 
        }
    }
}
