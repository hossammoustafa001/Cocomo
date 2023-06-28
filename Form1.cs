using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cocomo
{

    public partial class Form1 : Form
    {
   

        double[] organic =  {2.4 , 1.05 , 2.5, 0.38};
        double[] organic_intermediate =  {3.2 , 1.05 , 2.5 , 0.38};
        
        double[] semidetached = { 3.0, 1.12, 2.5, 0.35 };

        double[] embedded = { 3.6, 1.20, 2.5, 0.32 };
        double[] embedded_intermediate = {2.8 , 1.2 , 2.5 , 0.32};

        string[] rating_text = new string[15];
        string[] rates = new string[6] {"Very Low","Low" , "Nominated","High" , "Very High" , "Extra High" };

       

        double[,] rating =
        {
            { 0.75 , 0.88 , 1 , 1.15 , 1.4 , 1 },
            { 1 , 0.94 , 1 , 1.08 , 1.16 , 1 },
            { 0.7 , 0.85 , 1 , 1.15 , 1.3 , 1.65 },
            { 1 , 1 , 1 , 1.11 , 1.3 , 1.66 },
            { 1 , 1 , 1 , 1.06 , 1.21 , 1.56},
            { 1 , 0.87 , 1 , 1.15 , 1.3 , 1 },
            { 1 , 0.87 , 1 , 1.07 , 1.15 , 1 },
            { 1.46 , 1.19 , 1 , 0.86 , 0.71 , 1 },
            { 1.29 , 1.13 , 1 , 0.91 , 0.82 , 1 },
            { 1.42 , 1.17 , 1 , 0.86 , 0.7 , 1 },
            { 1.21 , 1.1 , 1 , 0.9 , 1 , 1 },
            { 1.14 , 1.07 , 1 , 0.95 , 1 , 1 },
            { 1.24 , 1.1 , 1 , 0.91 , 0.82 , 1 },
            { 1.24 , 1.1 , 1 , 0.91 , 0.83 , 1 },
            { 1.23 , 10.8 , 1 , 1.04 , 1.1 , 1 }


        };

        double a = 0, b = 0, c = 0, d = 0 ;

        double a_inter = 0 , b_inter = 0 , c_inter = 0 , d_inter = 0 ; 

        double kloc = 0 , eaf = 1 ;
        double effort_value = 0  , tdev_value = 0  , effort_value_inter = 0 ;

        
        private void kloc1_TextChanged(object sender, EventArgs e)
        {

            kloc = Convert.ToInt32(kloc1.Text);

         
            if (kloc>=2 && kloc<50)
            {

                a = organic[0];
                b = organic[1];
                c = organic[2];
                d = organic[3];

                a_inter = organic_intermediate[0];
                b_inter = organic_intermediate[1];
                c_inter = organic_intermediate[2];
                d_inter = organic_intermediate[3];

                effort_value = Effort(kloc, a, b);
                effort_value_inter = Effort(kloc, a_inter, b_inter); 

            }
            else if (kloc>=50 && kloc <300) 
            {
                a = semidetached[0];
                b = semidetached[1];
                c = semidetached[2];
                d = semidetached[3];

                effort_value = Effort(kloc, a, b);
                effort_value_inter = Effort(kloc, a_inter, b_inter); 

            }
            else if (kloc>=300) 
            {
                a = embedded[0];
                b = embedded[1];
                c = embedded[2];
                d = embedded[3];

                a_inter = embedded_intermediate[0];
                b_inter = embedded_intermediate[1];
                c_inter = embedded_intermediate[2];
                d_inter = embedded_intermediate[3];

                effort_value = Effort(kloc, a, b);
                effort_value_inter = Effort(kloc, a_inter, b_inter);

            }
            

        }



        private void organic1_Click(object sender, EventArgs e)
        {
           
            a = organic[0];
            b = organic[1];
            c = organic[2];
            d = organic[3];


            a_inter = organic_intermediate[0];
            b_inter = organic_intermediate[1];
            c_inter = organic_intermediate[2];
            d_inter = organic_intermediate[3];

            effort_value = Effort(kloc, a, b);
            effort_value_inter = Effort(kloc, a_inter, b_inter);


        }

        private void semi2_Click(object sender, EventArgs e)
        {
            
            a = semidetached[0];
            b = semidetached[1];
            c = semidetached[2];
            d = semidetached[3];

            effort_value = Effort(kloc, a, b);

        }

        private void embedded1_Click(object sender, EventArgs e)
        {

           
            a = embedded[0];
            b = embedded[1];
            c = embedded[2];
            d = embedded[3];

            a_inter = embedded_intermediate[0];
            b_inter = embedded_intermediate[1];
            c_inter = embedded_intermediate[2];
            d_inter = embedded_intermediate[3];


            effort_value = Effort(kloc, a, b);
            effort_value_inter = Effort(kloc, a_inter, b_inter);

        }

        private void calculate_effort_Click(object sender, EventArgs e)
        {

            kloc_label.Text = effort_value.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = kloc1;
        }

        private void tdev_button_Click(object sender, EventArgs e)
        {

            tdev_value = Tdev(effort_value, c, d);
            tdev_label.Text = tdev_value.ToString();
            
        }

        public double Effort  (double kloc , double a , double b)
        {

            double effort = Math.Pow(kloc,b);
            effort = effort * a; 
           
            return effort; 
        }


        public double Tdev (double effor_value , double c , double d)
        {

            double tdev = Math.Pow(effort_value, d);
            tdev = tdev * c; 

            return tdev; 
        }


        private void calculate_actual_effort_Click_1(object sender, EventArgs e)
        {

            rating_text[0]  = Box0.Text;
            rating_text[1]  = Box1.Text;
            rating_text[2]  = Box2.Text;
            rating_text[3]  = Box3.Text;
            rating_text[4]  = Box4.Text;
            rating_text[5]  = Box5.Text;
            rating_text[6]  = Box6.Text;
            rating_text[7]  = Box7.Text;
            rating_text[8]  = Box8.Text;
            rating_text[9]  = Box9.Text;
            rating_text[10] = Box10.Text;
            rating_text[11] = Box11.Text;
            rating_text[12] = Box12.Text;
            rating_text[13] = Box13.Text;
            rating_text[14] = Box14.Text;


            for (int i=0; i<15; ++i)
            {
                for (int j=0; j<6; ++j)
                {
                    if (rating_text[i]==rates[j])
                    {
                        eaf *= rating[i,j];  

                    }

                }

            }

            eaf *= effort_value_inter;

            actual_effort.Text = eaf.ToString(); 
          

        }


        public Form1()
        {
            InitializeComponent();
        }


    }
}
