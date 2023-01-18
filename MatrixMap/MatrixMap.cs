using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixMap
{
    public partial class MatrixMap : Form
    {

        const int NUM_ROWS = 10, NUM_COLS = 10, CELL_SIZE = 32;

        Random rnd = new Random();
        Label[,] labelArr = new Label[NUM_ROWS , CELL_SIZE];
        int[] tileInts = new int[] {0, 1, 2, 3, 4, 5};

        private void MatrixMap_Load(object sender, EventArgs e)
        {
            this.Width =  CELL_SIZE * NUM_ROWS;
            this.Height = CELL_SIZE * NUM_ROWS;
            tlpMap.Width = CELL_SIZE * NUM_ROWS;
            tlpMap.Height = CELL_SIZE * NUM_ROWS;
            Console.WriteLine(this.Width);
            Console.WriteLine(this.Height);

            loadArrays();


        }

        private void loadArrays()
        {
            for (int i = 0; i < NUM_ROWS; i++)
            {
                for (int j = 0; j < NUM_COLS; j++)
                {
                    int num =rnd.Next(6);
                    int t = rnd.Next(tileInts.Length);

                    Label l = new Label();
                   // l.Text = col.ToString();
                    l.Width = CELL_SIZE;
                    l.Height = CELL_SIZE;
                    
                    switch(t)
                    {
                        case 1:
                            l.Image = ilsTiles.Images[0];
                            break;
                        case 2:
                            l.Image = ilsTiles.Images[1];
                            break;
                        case 3:
                            l.Image = ilsTiles.Images[2];
                            break;
                        case 4:
                            l.Image = ilsTiles.Images[3];
                            break;
                        case 5:
                            l.Image = ilsTiles.Images[4];
                            break;
                        case 0:
                            l.Image = ilsTiles.Images[5];
                            break;
                    }

                    l.Margin = new Padding(0);
                    l.TextAlign = ContentAlignment.MiddleCenter;
                   
                    
                    tlpMap.Controls.Add(l);
                    //l.BringToFront();
                }
            }
        }




        public MatrixMap()
        {
            InitializeComponent();
        }
    }
}
