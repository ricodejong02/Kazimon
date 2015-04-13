using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Kazimon
{
    public partial class Form1 : Form
    {
        bool YourTurn = true;

        int YourHP = 0;
        int CurrentHPYou = 0;
        int CurrentHPOther = 0;
        int OtherHP = 0;
        int YourAttack = 0;
        int OtherAttack = 0;
        int YourDef = 0;
        int OtherDef = 0;

        int DekomanHP = 50;
        int DekomanAttack = 17;
        int DekomanDef = 20;

        int DekominHP = 50;
        int DekominAttack = 13;
        int DekominDef = 22;

        Random rd = new Random();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            YourHP = DekomanHP;
            YourAttack = DekomanAttack;
            YourDef = DekomanDef;
            CurrentHPYou = YourHP;
            OtherHP = DekomanHP;
            OtherAttack = DekominAttack;
            OtherDef = DekominDef;
            CurrentHPOther = DekominHP;

          

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Updater_Tick(object sender, EventArgs e)
        {

            Hplabel.Text = CurrentHPYou + "/" + YourHP;
            NameLabel.Text = "Dekoman";
            label1.Text = CurrentHPOther + "/" + OtherHP;
            label2.Text = "Dekomin";
            button1.Text = "Tackle";
            
            if (CurrentHPOther <= 0)
            {
                MessageBox.Show("You win!");
                Thread.Sleep(1000);
                this.Close();
            }

            if (CurrentHPYou <= 0)
            {
                MessageBox.Show("You fail!");
                Thread.Sleep(1000);
                this.Close();
            }

            if (YourTurn == false)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                Thread.Sleep(650);
                DoTackleOther();
                YourTurn = true;
            }

            if (YourTurn == true)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }                  
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            YourTurn = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoTackle();
            YourTurn = false;
        }

        public void DoTackle()
        {
            CurrentHPOther -= 15 + YourAttack - OtherDef;
        }

        public void DoTackleOther()
        {
            CurrentHPYou -= 15 + OtherAttack - YourDef;
        }
    }

}
