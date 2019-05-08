using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lines
{
    public partial class Form1 : Form
    {
        Button[,] grid;

        int x = -1;
        int y = -1;

        int tmr = 60;

        public Form1()
        {
            InitializeComponent();
            grid = new Button[150, 150];

            #region buttons

            grid[0, 0] = button1;
            grid[0, 1] = button2;
            grid[0, 2] = button3;
            grid[0, 3] = button4;
            grid[0, 4] = button5;
            grid[0, 5] = button10;
            grid[0, 6] = button9;
            grid[0, 7] = button8;
            grid[0, 8] = button7;
            grid[0, 9] = button6;
            grid[1, 0] = button20;
            grid[1, 1] = button19;
            grid[1, 2] = button18;
            grid[1, 3] = button17;
            grid[1, 4] = button16;
            grid[1, 5] = button15;
            grid[1, 6] = button14;
            grid[1, 7] = button13;
            grid[1, 8] = button12;
            grid[1, 9] = button11;
            grid[2, 0] = button30;
            grid[2, 1] = button29;
            grid[2, 2] = button28;
            grid[2, 3] = button27;
            grid[2, 4] = button26;
            grid[2, 5] = button25;
            grid[2, 6] = button24;
            grid[2, 7] = button23;
            grid[2, 8] = button22;
            grid[2, 9] = button21;
            grid[3, 0] = button40;
            grid[3, 1] = button39;
            grid[3, 2] = button38;
            grid[3, 3] = button37;
            grid[3, 4] = button36;
            grid[3, 5] = button35;
            grid[3, 6] = button34;
            grid[3, 7] = button33;
            grid[3, 8] = button32;
            grid[3, 9] = button31;
            grid[4, 0] = button50;
            grid[4, 1] = button49;
            grid[4, 2] = button48;
            grid[4, 3] = button47;
            grid[4, 4] = button46;
            grid[4, 5] = button45;
            grid[4, 6] = button44;
            grid[4, 7] = button43;
            grid[4, 8] = button42;
            grid[4, 9] = button41;
            grid[5, 0] = button100;
            grid[5, 1] = button99;
            grid[5, 2] = button98;
            grid[5, 3] = button97;
            grid[5, 4] = button96;
            grid[5, 5] = button95;
            grid[5, 6] = button94;
            grid[5, 7] = button93;
            grid[5, 8] = button92;
            grid[5, 9] = button91;
            grid[6, 0] = button90;
            grid[6, 1] = button89;
            grid[6, 2] = button88;
            grid[6, 3] = button87;
            grid[6, 4] = button86;
            grid[6, 5] = button85;
            grid[6, 6] = button84;
            grid[6, 7] = button83;
            grid[6, 8] = button82;
            grid[6, 9] = button81;
            grid[7, 0] = button80;
            grid[7, 1] = button79;
            grid[7, 2] = button78;
            grid[7, 3] = button77;
            grid[7, 4] = button76;
            grid[7, 5] = button75;
            grid[7, 6] = button74;
            grid[7, 7] = button73;
            grid[7, 8] = button72;
            grid[7, 9] = button71;
            grid[8, 0] = button70;
            grid[8, 1] = button69;
            grid[8, 2] = button68;
            grid[8, 3] = button67;
            grid[8, 4] = button66;
            grid[8, 5] = button65;
            grid[8, 6] = button64;
            grid[8, 7] = button63;
            grid[8, 8] = button62;
            grid[8, 9] = button61;
            grid[9, 0] = button60;
            grid[9, 1] = button59;
            grid[9, 2] = button58;
            grid[9, 3] = button57;
            grid[9, 4] = button56;
            grid[9, 5] = button55;
            grid[9, 6] = button54;
            grid[9, 7] = button53;
            grid[9, 8] = button52;
            grid[9, 9] = button51;

            #endregion
        }

        public void generateSquare()
        {
            Random random = new Random();
            int numGenA = random.Next(0, 8);
            int numGenB = random.Next(0, 8);
            int[,] map = new int[100, 100];


            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (grid[i, j].BackColor == Color.CornflowerBlue)
                    {
                        map[i, j] = 1;
                    }
                    else
                    {
                        map[i, j] = 0;
                    }
                }
            }


            if (map[numGenA, numGenB] == 1)
            {
                numGenA = random.Next(0, 8);
                numGenB = random.Next(0, 8);

                grid[numGenA, numGenB].BackColor = Color.CornflowerBlue;
            }
            else
            {
                grid[numGenA, numGenB].BackColor = Color.CornflowerBlue;

                numGenA = random.Next(0, 8);
                numGenB = random.Next(0, 8);

                grid[numGenA, numGenB].BackColor = Color.CornflowerBlue;
            }

            #region tabstop

            button1.TabStop = false;
            button2.TabStop = false;
            button3.TabStop = false;
            button4.TabStop = false;
            button5.TabStop = false;
            button6.TabStop = false;
            button7.TabStop = false;
            button8.TabStop = false;
            button9.TabStop = false;
            button10.TabStop = false;
            button11.TabStop = false;
            button12.TabStop = false;
            button13.TabStop = false;
            button14.TabStop = false;
            button15.TabStop = false;
            button16.TabStop = false;
            button17.TabStop = false;
            button18.TabStop = false;
            button19.TabStop = false;
            button20.TabStop = false;
            button21.TabStop = false;
            button22.TabStop = false;
            button23.TabStop = false;
            button24.TabStop = false;
            button25.TabStop = false;
            button26.TabStop = false;
            button27.TabStop = false;
            button28.TabStop = false;
            button29.TabStop = false;
            button30.TabStop = false;
            button31.TabStop = false;
            button32.TabStop = false;
            button33.TabStop = false;
            button34.TabStop = false;
            button35.TabStop = false;
            button36.TabStop = false;
            button37.TabStop = false;
            button38.TabStop = false;
            button39.TabStop = false;
            button40.TabStop = false;
            button41.TabStop = false;
            button42.TabStop = false;
            button43.TabStop = false;
            button44.TabStop = false;
            button45.TabStop = false;
            button46.TabStop = false;
            button47.TabStop = false;
            button48.TabStop = false;
            button49.TabStop = false;
            button50.TabStop = false;
            button51.TabStop = false;
            button52.TabStop = false;
            button53.TabStop = false;
            button54.TabStop = false;
            button55.TabStop = false;
            button56.TabStop = false;
            button57.TabStop = false;
            button58.TabStop = false;
            button59.TabStop = false;
            button60.TabStop = false;
            button61.TabStop = false;
            button62.TabStop = false;
            button63.TabStop = false;
            button64.TabStop = false;
            button65.TabStop = false;
            button66.TabStop = false;
            button67.TabStop = false;
            button68.TabStop = false;
            button69.TabStop = false;
            button70.TabStop = false;
            button71.TabStop = false;
            button72.TabStop = false;
            button73.TabStop = false;
            button74.TabStop = false;
            button75.TabStop = false;
            button76.TabStop = false;
            button77.TabStop = false;
            button78.TabStop = false;
            button79.TabStop = false;
            button80.TabStop = false;
            button81.TabStop = false;
            button82.TabStop = false;
            button83.TabStop = false;
            button84.TabStop = false;
            button85.TabStop = false;
            button86.TabStop = false;
            button87.TabStop = false;
            button88.TabStop = false;
            button89.TabStop = false;
            button90.TabStop = false;
            button91.TabStop = false;
            button92.TabStop = false;
            button93.TabStop = false;
            button94.TabStop = false;
            button95.TabStop = false;
            button96.TabStop = false;
            button97.TabStop = false;
            button98.TabStop = false;
            button99.TabStop = false;
            button100.TabStop = false;

            #endregion
        }


        public void checkRowsCells()
        {
            int sumRows = 0;
            int sumCols = 0;

            int[] mr = new int[20];
            int[] mc = new int[20];


            for (int i = 0; i < 10; i++)
            {
                int num = 0;
                int count = 0;

                for (int c = 0; c < mr.Length; c++)
                {
                    mr[c] = 0;
                }

                for (int j = 0; j < 10; j++)
                {
                    if (grid[i, j].BackColor == Color.CornflowerBlue)
                    {
                        num = num + 1;

                        if (grid[i, j + 1].BackColor == Color.FromArgb(224, 224, 224))
                        {
                            mr[count] = num;
                            num = 0;
                            count++;
                        }

                    }
                }

                int max_row = Max(mr);

                if (max_row >= 5)
                {
                    sumRows += max_row;
                }
            }


            for (int i = 0; i < 10; i++)
            {
                int num = 0;
                int count = 0;

                for (int c = 0; c < mc.Length; c++)
                {
                    mc[c] = 0;
                }

                for (int j = 0; j < 10; j++)
                {
                    if (grid[j, i].BackColor == Color.CornflowerBlue)
                    {
                        num = num + 1;

                        if (grid[j + 1, i].BackColor == Color.FromArgb(224, 224, 224))
                        {
                            mc[count] = num;
                            num = 0;
                            count++;
                        }

                    }
                }


                int max_col = Max(mc);

                if (max_col >= 5)
                {
                    sumCols += max_col;
                }
            }

            int ActualSumRows = sumRows;
            int ActualSumCols = sumCols;

            label1.Text = (ActualSumRows + ActualSumCols).ToString();
        }


        public void unlockGrid()
        {
            #region unlock

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
            button26.Enabled = true;
            button27.Enabled = true;
            button28.Enabled = true;
            button29.Enabled = true;
            button30.Enabled = true;
            button31.Enabled = true;
            button32.Enabled = true;
            button33.Enabled = true;
            button34.Enabled = true;
            button35.Enabled = true;
            button36.Enabled = true;
            button37.Enabled = true;
            button38.Enabled = true;
            button39.Enabled = true;
            button40.Enabled = true;
            button41.Enabled = true;
            button42.Enabled = true;
            button43.Enabled = true;
            button44.Enabled = true;
            button45.Enabled = true;
            button46.Enabled = true;
            button47.Enabled = true;
            button48.Enabled = true;
            button49.Enabled = true;
            button50.Enabled = true;
            button51.Enabled = true;
            button52.Enabled = true;
            button53.Enabled = true;
            button54.Enabled = true;
            button55.Enabled = true;
            button56.Enabled = true;
            button57.Enabled = true;
            button58.Enabled = true;
            button59.Enabled = true;
            button60.Enabled = true;
            button61.Enabled = true;
            button62.Enabled = true;
            button63.Enabled = true;
            button64.Enabled = true;
            button65.Enabled = true;
            button66.Enabled = true;
            button67.Enabled = true;
            button68.Enabled = true;
            button69.Enabled = true;
            button70.Enabled = true;
            button71.Enabled = true;
            button72.Enabled = true;
            button73.Enabled = true;
            button74.Enabled = true;
            button75.Enabled = true;
            button76.Enabled = true;
            button77.Enabled = true;
            button78.Enabled = true;
            button79.Enabled = true;
            button80.Enabled = true;
            button81.Enabled = true;
            button82.Enabled = true;
            button83.Enabled = true;
            button84.Enabled = true;
            button85.Enabled = true;
            button86.Enabled = true;
            button87.Enabled = true;
            button88.Enabled = true;
            button89.Enabled = true;
            button90.Enabled = true;
            button91.Enabled = true;
            button92.Enabled = true;
            button93.Enabled = true;
            button94.Enabled = true;
            button95.Enabled = true;
            button96.Enabled = true;
            button97.Enabled = true;
            button98.Enabled = true;
            button99.Enabled = true;
            button100.Enabled = true;

            #endregion
        }

        public void lockGrid()
        {
            #region lock

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;
            button24.Enabled = false;
            button25.Enabled = false;
            button26.Enabled = false;
            button27.Enabled = false;
            button28.Enabled = false;
            button29.Enabled = false;
            button30.Enabled = false;
            button31.Enabled = false;
            button32.Enabled = false;
            button33.Enabled = false;
            button34.Enabled = false;
            button35.Enabled = false;
            button36.Enabled = false;
            button37.Enabled = false;
            button38.Enabled = false;
            button39.Enabled = false;
            button40.Enabled = false;
            button41.Enabled = false;
            button42.Enabled = false;
            button43.Enabled = false;
            button44.Enabled = false;
            button45.Enabled = false;
            button46.Enabled = false;
            button47.Enabled = false;
            button48.Enabled = false;
            button49.Enabled = false;
            button50.Enabled = false;
            button51.Enabled = false;
            button52.Enabled = false;
            button53.Enabled = false;
            button54.Enabled = false;
            button55.Enabled = false;
            button56.Enabled = false;
            button57.Enabled = false;
            button58.Enabled = false;
            button59.Enabled = false;
            button60.Enabled = false;
            button61.Enabled = false;
            button62.Enabled = false;
            button63.Enabled = false;
            button64.Enabled = false;
            button65.Enabled = false;
            button66.Enabled = false;
            button67.Enabled = false;
            button68.Enabled = false;
            button69.Enabled = false;
            button70.Enabled = false;
            button71.Enabled = false;
            button72.Enabled = false;
            button73.Enabled = false;
            button74.Enabled = false;
            button75.Enabled = false;
            button76.Enabled = false;
            button77.Enabled = false;
            button78.Enabled = false;
            button79.Enabled = false;
            button80.Enabled = false;
            button81.Enabled = false;
            button82.Enabled = false;
            button83.Enabled = false;
            button84.Enabled = false;
            button85.Enabled = false;
            button86.Enabled = false;
            button87.Enabled = false;
            button88.Enabled = false;
            button89.Enabled = false;
            button90.Enabled = false;
            button91.Enabled = false;
            button92.Enabled = false;
            button93.Enabled = false;
            button94.Enabled = false;
            button95.Enabled = false;
            button96.Enabled = false;
            button97.Enabled = false;
            button98.Enabled = false;
            button99.Enabled = false;
            button100.Enabled = false;

            #endregion
        }

        public int Max(int[] intArray)
        {
            int maxVal = intArray[0];

            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] > maxVal)
                    maxVal = intArray[i];
            }
            return maxVal;
        }


        public void resetGrid()
        {
            label1.Text = "0";

            #region reset

            button1.BackColor = Color.FromArgb(224, 224, 224);
            button2.BackColor = Color.FromArgb(224, 224, 224);
            button3.BackColor = Color.FromArgb(224, 224, 224);
            button4.BackColor = Color.FromArgb(224, 224, 224);
            button5.BackColor = Color.FromArgb(224, 224, 224);
            button6.BackColor = Color.FromArgb(224, 224, 224);
            button7.BackColor = Color.FromArgb(224, 224, 224);
            button8.BackColor = Color.FromArgb(224, 224, 224);
            button9.BackColor = Color.FromArgb(224, 224, 224);
            button10.BackColor = Color.FromArgb(224, 224, 224);
            button11.BackColor = Color.FromArgb(224, 224, 224);
            button12.BackColor = Color.FromArgb(224, 224, 224);
            button13.BackColor = Color.FromArgb(224, 224, 224);
            button14.BackColor = Color.FromArgb(224, 224, 224);
            button15.BackColor = Color.FromArgb(224, 224, 224);
            button16.BackColor = Color.FromArgb(224, 224, 224);
            button17.BackColor = Color.FromArgb(224, 224, 224);
            button18.BackColor = Color.FromArgb(224, 224, 224);
            button19.BackColor = Color.FromArgb(224, 224, 224);
            button20.BackColor = Color.FromArgb(224, 224, 224);
            button21.BackColor = Color.FromArgb(224, 224, 224);
            button22.BackColor = Color.FromArgb(224, 224, 224);
            button23.BackColor = Color.FromArgb(224, 224, 224);
            button24.BackColor = Color.FromArgb(224, 224, 224);
            button25.BackColor = Color.FromArgb(224, 224, 224);
            button26.BackColor = Color.FromArgb(224, 224, 224);
            button27.BackColor = Color.FromArgb(224, 224, 224);
            button28.BackColor = Color.FromArgb(224, 224, 224);
            button29.BackColor = Color.FromArgb(224, 224, 224);
            button30.BackColor = Color.FromArgb(224, 224, 224);
            button31.BackColor = Color.FromArgb(224, 224, 224);
            button32.BackColor = Color.FromArgb(224, 224, 224);
            button33.BackColor = Color.FromArgb(224, 224, 224);
            button34.BackColor = Color.FromArgb(224, 224, 224);
            button35.BackColor = Color.FromArgb(224, 224, 224);
            button36.BackColor = Color.FromArgb(224, 224, 224);
            button37.BackColor = Color.FromArgb(224, 224, 224);
            button38.BackColor = Color.FromArgb(224, 224, 224);
            button39.BackColor = Color.FromArgb(224, 224, 224);
            button40.BackColor = Color.FromArgb(224, 224, 224);
            button41.BackColor = Color.FromArgb(224, 224, 224);
            button42.BackColor = Color.FromArgb(224, 224, 224);
            button43.BackColor = Color.FromArgb(224, 224, 224);
            button44.BackColor = Color.FromArgb(224, 224, 224);
            button45.BackColor = Color.FromArgb(224, 224, 224);
            button46.BackColor = Color.FromArgb(224, 224, 224);
            button47.BackColor = Color.FromArgb(224, 224, 224);
            button48.BackColor = Color.FromArgb(224, 224, 224);
            button49.BackColor = Color.FromArgb(224, 224, 224);
            button50.BackColor = Color.FromArgb(224, 224, 224);
            button51.BackColor = Color.FromArgb(224, 224, 224);
            button52.BackColor = Color.FromArgb(224, 224, 224);
            button53.BackColor = Color.FromArgb(224, 224, 224);
            button54.BackColor = Color.FromArgb(224, 224, 224);
            button55.BackColor = Color.FromArgb(224, 224, 224);
            button56.BackColor = Color.FromArgb(224, 224, 224);
            button57.BackColor = Color.FromArgb(224, 224, 224);
            button58.BackColor = Color.FromArgb(224, 224, 224);
            button59.BackColor = Color.FromArgb(224, 224, 224);
            button60.BackColor = Color.FromArgb(224, 224, 224);
            button61.BackColor = Color.FromArgb(224, 224, 224);
            button62.BackColor = Color.FromArgb(224, 224, 224);
            button63.BackColor = Color.FromArgb(224, 224, 224);
            button64.BackColor = Color.FromArgb(224, 224, 224);
            button65.BackColor = Color.FromArgb(224, 224, 224);
            button66.BackColor = Color.FromArgb(224, 224, 224);
            button67.BackColor = Color.FromArgb(224, 224, 224);
            button68.BackColor = Color.FromArgb(224, 224, 224);
            button69.BackColor = Color.FromArgb(224, 224, 224);
            button70.BackColor = Color.FromArgb(224, 224, 224);
            button71.BackColor = Color.FromArgb(224, 224, 224);
            button72.BackColor = Color.FromArgb(224, 224, 224);
            button73.BackColor = Color.FromArgb(224, 224, 224);
            button74.BackColor = Color.FromArgb(224, 224, 224);
            button75.BackColor = Color.FromArgb(224, 224, 224);
            button76.BackColor = Color.FromArgb(224, 224, 224);
            button77.BackColor = Color.FromArgb(224, 224, 224);
            button78.BackColor = Color.FromArgb(224, 224, 224);
            button79.BackColor = Color.FromArgb(224, 224, 224);
            button80.BackColor = Color.FromArgb(224, 224, 224);
            button81.BackColor = Color.FromArgb(224, 224, 224);
            button82.BackColor = Color.FromArgb(224, 224, 224);
            button83.BackColor = Color.FromArgb(224, 224, 224);
            button84.BackColor = Color.FromArgb(224, 224, 224);
            button85.BackColor = Color.FromArgb(224, 224, 224);
            button86.BackColor = Color.FromArgb(224, 224, 224);
            button87.BackColor = Color.FromArgb(224, 224, 224);
            button88.BackColor = Color.FromArgb(224, 224, 224);
            button89.BackColor = Color.FromArgb(224, 224, 224);
            button90.BackColor = Color.FromArgb(224, 224, 224);
            button91.BackColor = Color.FromArgb(224, 224, 224);
            button92.BackColor = Color.FromArgb(224, 224, 224);
            button93.BackColor = Color.FromArgb(224, 224, 224);
            button94.BackColor = Color.FromArgb(224, 224, 224);
            button95.BackColor = Color.FromArgb(224, 224, 224);
            button96.BackColor = Color.FromArgb(224, 224, 224);
            button97.BackColor = Color.FromArgb(224, 224, 224);
            button98.BackColor = Color.FromArgb(224, 224, 224);
            button99.BackColor = Color.FromArgb(224, 224, 224);
            button100.BackColor = Color.FromArgb(224, 224, 224);

            #endregion
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            generateSquare();
            label1.Text = "0";
            timer1.Enabled = true;
            button101.Enabled = false;
        }

        private void button82_Click(object sender, EventArgs e)
        {
            if (button82.BackColor == Color.CornflowerBlue)
            {
                x = 6;
                y = 8;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button82.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button82.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (button1.BackColor == Color.CornflowerBlue)
            {
                x = 0;
                y = 0;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button1.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button1.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (button7.BackColor == Color.CornflowerBlue)
            {
                x = 0;
                y = 8;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button7.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button7.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.CornflowerBlue)
            {
                x = 0;
                y = 1;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button2.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button2.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.CornflowerBlue)
            {
                x = 0;
                y = 2;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button3.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button3.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == Color.CornflowerBlue)
            {
                x = 0;
                y = 3;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button4.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button4.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.BackColor == Color.CornflowerBlue)
            {
                x = 0;
                y = 4;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button5.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button5.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.BackColor == Color.CornflowerBlue)
            {
                x = 0;
                y = 5;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button10.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button10.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.BackColor == Color.CornflowerBlue)
            {
                x = 0;
                y = 6;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button9.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button9.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.BackColor == Color.CornflowerBlue)
            {
                x = 0;
                y = 7;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button8.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button8.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }


        private void button20_Click(object sender, EventArgs e)
        {
            if (button20.BackColor == Color.CornflowerBlue)
            {
                x = 1;
                y = 0;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button20.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button20.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (button19.BackColor == Color.CornflowerBlue)
            {
                x = 1;
                y = 1;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button19.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button19.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (button18.BackColor == Color.CornflowerBlue)
            {
                x = 1;
                y = 2;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button18.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button18.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (button17.BackColor == Color.CornflowerBlue)
            {
                x = 1;
                y = 3;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button17.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button17.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button16.BackColor == Color.CornflowerBlue)
            {
                x = 1;
                y = 4;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button16.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button16.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.BackColor == Color.CornflowerBlue)
            {
                x = 1;
                y = 5;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button15.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button15.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.BackColor == Color.CornflowerBlue)
            {
                x = 1;
                y = 6;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button14.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button14.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.BackColor == Color.CornflowerBlue)
            {
                x = 1;
                y = 7;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button13.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button13.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.BackColor == Color.CornflowerBlue)
            {
                x = 1;
                y = 8;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button12.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button12.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (button30.BackColor == Color.CornflowerBlue)
            {
                x = 2;
                y = 0;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button30.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button30.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (button29.BackColor == Color.CornflowerBlue)
            {
                x = 2;
                y = 1;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button29.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button29.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (button28.BackColor == Color.CornflowerBlue)
            {
                x = 2;
                y = 2;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button28.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button28.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (button27.BackColor == Color.CornflowerBlue)
            {
                x = 2;
                y = 3;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button27.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button27.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (button26.BackColor == Color.CornflowerBlue)
            {
                x = 2;
                y = 4;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button26.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button26.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (button25.BackColor == Color.CornflowerBlue)
            {
                x = 2;
                y = 5;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button25.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button25.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (button24.BackColor == Color.CornflowerBlue)
            {
                x = 2;
                y = 6;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button24.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button24.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (button23.BackColor == Color.CornflowerBlue)
            {
                x = 2;
                y = 7;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button23.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button23.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (button22.BackColor == Color.CornflowerBlue)
            {
                x = 2;
                y = 8;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button22.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button22.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (button40.BackColor == Color.CornflowerBlue)
            {
                x = 3;
                y = 0;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button40.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button40.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (button39.BackColor == Color.CornflowerBlue)
            {
                x = 3;
                y = 1;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button39.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button39.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (button38.BackColor == Color.CornflowerBlue)
            {
                x = 3;
                y = 2;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button38.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button38.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (button37.BackColor == Color.CornflowerBlue)
            {
                x = 3;
                y = 3;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button37.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button37.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (button36.BackColor == Color.CornflowerBlue)
            {
                x = 3;
                y = 4;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button36.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button36.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (button35.BackColor == Color.CornflowerBlue)
            {
                x = 3;
                y = 5;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button35.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button35.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (button34.BackColor == Color.CornflowerBlue)
            {
                x = 3;
                y = 6;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button34.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button34.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (button33.BackColor == Color.CornflowerBlue)
            {
                x = 3;
                y = 7;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button33.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button33.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (button32.BackColor == Color.CornflowerBlue)
            {
                x = 3;
                y = 8;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button32.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button32.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (button50.BackColor == Color.CornflowerBlue)
            {
                x = 4;
                y = 0;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button50.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button50.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (button49.BackColor == Color.CornflowerBlue)
            {
                x = 4;
                y = 1;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button49.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button49.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (button48.BackColor == Color.CornflowerBlue)
            {
                x = 4;
                y = 2;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button48.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button48.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (button47.BackColor == Color.CornflowerBlue)
            {
                x = 4;
                y = 3;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button47.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button47.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (button46.BackColor == Color.CornflowerBlue)
            {
                x = 4;
                y = 4;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button46.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button46.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (button45.BackColor == Color.CornflowerBlue)
            {
                x = 4;
                y = 5;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button45.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button45.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (button44.BackColor == Color.CornflowerBlue)
            {
                x = 4;
                y = 6;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button44.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button44.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (button43.BackColor == Color.CornflowerBlue)
            {
                x = 4;
                y = 7;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button43.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button43.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (button42.BackColor == Color.CornflowerBlue)
            {
                x = 4;
                y = 8;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button42.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button42.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            
        }

        private void button100_Click(object sender, EventArgs e)
        {
            if (button100.BackColor == Color.CornflowerBlue)
            {
                x = 5;
                y = 0;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button100.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button100.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button99_Click(object sender, EventArgs e)
        {
            if (button99.BackColor == Color.CornflowerBlue)
            {
                x = 5;
                y = 1;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button99.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button99.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button98_Click(object sender, EventArgs e)
        {
            if (button98.BackColor == Color.CornflowerBlue)
            {
                x = 5;
                y = 2;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button98.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button98.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button97_Click(object sender, EventArgs e)
        {
            if (button97.BackColor == Color.CornflowerBlue)
            {
                x = 5;
                y = 3;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button97.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button97.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button96_Click(object sender, EventArgs e)
        {
            if (button96.BackColor == Color.CornflowerBlue)
            {
                x = 5;
                y = 4;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button96.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button96.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button95_Click(object sender, EventArgs e)
        {
            if (button95.BackColor == Color.CornflowerBlue)
            {
                x = 5;
                y = 5;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button95.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button95.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button94_Click(object sender, EventArgs e)
        {
            if (button94.BackColor == Color.CornflowerBlue)
            {
                x = 5;
                y = 6;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button94.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button94.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button93_Click(object sender, EventArgs e)
        {
            if (button93.BackColor == Color.CornflowerBlue)
            {
                x = 5;
                y = 7;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button93.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button93.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button92_Click(object sender, EventArgs e)
        {
            if (button92.BackColor == Color.CornflowerBlue)
            {
                x = 5;
                y = 8;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button92.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button92.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button91_Click(object sender, EventArgs e)
        {
           
        }

        private void button90_Click(object sender, EventArgs e)
        {
            if (button90.BackColor == Color.CornflowerBlue)
            {
                x = 6;
                y = 0;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button90.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button90.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button89_Click(object sender, EventArgs e)
        {
            if (button89.BackColor == Color.CornflowerBlue)
            {
                x = 6;
                y = 1;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button89.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button89.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button88_Click(object sender, EventArgs e)
        {
            if (button88.BackColor == Color.CornflowerBlue)
            {
                x = 6;
                y = 2;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button88.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button88.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button87_Click(object sender, EventArgs e)
        {
            if (button87.BackColor == Color.CornflowerBlue)
            {
                x = 6;
                y = 3;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button87.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button87.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button86_Click(object sender, EventArgs e)
        {
            if (button86.BackColor == Color.CornflowerBlue)
            {
                x = 6;
                y = 4;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button86.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button86.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button85_Click(object sender, EventArgs e)
        {
            if (button85.BackColor == Color.CornflowerBlue)
            {
                x = 6;
                y = 5;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button85.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button85.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button84_Click(object sender, EventArgs e)
        {
            if (button84.BackColor == Color.CornflowerBlue)
            {
                x = 6;
                y = 6;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button84.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button84.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button83_Click(object sender, EventArgs e)
        {
            if (button83.BackColor == Color.CornflowerBlue)
            {
                x = 6;
                y = 7;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button83.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button83.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button81_Click(object sender, EventArgs e)
        {
            
        }

        private void button80_Click(object sender, EventArgs e)
        {
            if (button80.BackColor == Color.CornflowerBlue)
            {
                x = 7;
                y = 0;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button80.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button80.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button79_Click(object sender, EventArgs e)
        {
            if (button79.BackColor == Color.CornflowerBlue)
            {
                x = 7;
                y = 1;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button79.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button79.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button78_Click(object sender, EventArgs e)
        {
            if (button78.BackColor == Color.CornflowerBlue)
            {
                x = 7;
                y = 2;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button78.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button78.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button77_Click(object sender, EventArgs e)
        {
            if (button77.BackColor == Color.CornflowerBlue)
            {
                x = 7;
                y = 3;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button77.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button77.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button76_Click(object sender, EventArgs e)
        {
            if (button76.BackColor == Color.CornflowerBlue)
            {
                x = 7;
                y = 4;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button76.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button76.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button75_Click(object sender, EventArgs e)
        {
            if (button75.BackColor == Color.CornflowerBlue)
            {
                x = 7;
                y = 5;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button75.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button75.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button74_Click(object sender, EventArgs e)
        {
            if (button74.BackColor == Color.CornflowerBlue)
            {
                x = 7;
                y = 6;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button74.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button74.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button73_Click(object sender, EventArgs e)
        {
            if (button73.BackColor == Color.CornflowerBlue)
            {
                x = 7;
                y = 7;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button73.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button73.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button72_Click(object sender, EventArgs e)
        {
            if (button72.BackColor == Color.CornflowerBlue)
            {
                x = 7;
                y = 8;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button72.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button72.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button71_Click(object sender, EventArgs e)
        {
            
        }

        private void button70_Click(object sender, EventArgs e)
        {
            if (button70.BackColor == Color.CornflowerBlue)
            {
                x = 8;
                y = 0;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button70.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button70.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button69_Click(object sender, EventArgs e)
        {
            if (button69.BackColor == Color.CornflowerBlue)
            {
                x = 8;
                y = 1;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button69.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button69.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button68_Click(object sender, EventArgs e)
        {
            if (button68.BackColor == Color.CornflowerBlue)
            {
                x = 8;
                y = 2;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button68.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button68.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button67_Click(object sender, EventArgs e)
        {
            if (button67.BackColor == Color.CornflowerBlue)
            {
                x = 8;
                y = 3;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button67.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button67.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            if (button66.BackColor == Color.CornflowerBlue)
            {
                x = 8;
                y = 4;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button66.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button66.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button65_Click(object sender, EventArgs e)
        {
            if (button65.BackColor == Color.CornflowerBlue)
            {
                x = 8;
                y = 5;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button65.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button65.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button64_Click(object sender, EventArgs e)
        {
            if (button64.BackColor == Color.CornflowerBlue)
            {
                x = 8;
                y = 6;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button64.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button64.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            if (button63.BackColor == Color.CornflowerBlue)
            {
                x = 8;
                y = 7;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button63.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button63.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (button62.BackColor == Color.CornflowerBlue)
            {
                x = 8;
                y = 8;
            }
            else
            {
                if (x == -1 && y == -1)
                {
                    button62.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    button62.BackColor = Color.CornflowerBlue;

                    grid[x, y].BackColor = Color.FromArgb(224, 224, 224);

                    x = -1;
                    y = -1;

                    generateSquare();
                    checkRowsCells();
                }
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            tmr--;
            label2.Text = tmr.ToString();

            if (tmr == 0)
            {
                timer1.Enabled = false;
                button101.Enabled = true;
                lockGrid();

                MessageBox.Show("You Won " + label1.Text + " points.", "Your score");
            }
        }

        private void button101_Click(object sender, EventArgs e)
        {
            tmr = 60;
            timer1.Enabled = true;
            button101.Enabled = false;
            unlockGrid();
            resetGrid();
            generateSquare();
        }
    }
}
