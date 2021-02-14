using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TAS_KAGIT_MAKAS.Properties;

namespace TAS_KAGIT_MAKAS
{
    public partial class Form1 : Form
    {
        
        Timer timer = new Timer();
        int otomatik;
        int round;
        int oyuncupuan = 0;
        

        int pcpuan = 0;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible=false;
        }
        public void yenidenoyna()
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Yeniden oynamak ister misin?", "EVET", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Form2 form2 = new Form2();
                form2.Show();  // form2 göster diyoruz
                this.Hide();
                // if (Application.OpenForms[0] == this)//Uygulamanin main form'u
                //{

                //uygulamanın ana formunu kapatirsaniz uygulama kapanir, ana formu yeniden baslatmak uygulamayi yeniden baslatmak demektir.
                //Application.Restart();
                //}
            }
            else
            {
                this.Close();   
            }
        }
        public void kazan()
        {
            if (radioButton1.Checked)
            {
                round = 1;
                if (round == 1)
                {
                    if (oyuncupuan == 1)
                    {
                        MessageBox.Show("Kazandın tebrikler");
                        yenidenoyna();
                    }
                    else if(pcpuan==1)
                    {
                        MessageBox.Show("Bİlgisayar kazandı");
                        yenidenoyna();
                    }

                }
            }else if (radioButton2.Checked)
            {
                round = 3;
                if (round == 3)
                {
                    if (oyuncupuan == 3)
                    {
                        MessageBox.Show("Kazandın tebrikler");
                        yenidenoyna();
                    }
                    else if(pcpuan==3)
                    {
                        MessageBox.Show("Bİlgisayar kazandı");
                        yenidenoyna();
                    }

                }
            }

           
            
                
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            kazan();
           
            otomatik = random.Next(3);
            if (otomatik == 0)
            {
                label5.Text = "berabere";
                label9.Text = "bilgisyarın secimi taş";

            }
            else if (otomatik == 1)
            {
                pcpuan++;
                label8.Text = pcpuan.ToString();
                label5.Text = "Kağıt taşı sarar";
                label9.Text = "bilgisyarın secimi kağıt";

            } 
            else if(otomatik == 2)
                    {
                oyuncupuan++;
                label7.Text = oyuncupuan.ToString();
                label5.Text = "Taş makası kırar";
                label9.Text = "bilgisyarın secimi makas";
            }
            kazan();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            otomatik = random.Next(3);
            if (otomatik == 0)
            {
                oyuncupuan++;
                label7.Text = oyuncupuan.ToString();
                label5.Text = "Kağıt taşı sarar";
                label9.Text = "bilgisyarın secimi taş";

            }
            else if (otomatik == 1)
            {
                
                label5.Text = "Berabere";
                label9.Text = "bilgisyarın secimi kağıt";

            }
            else if (otomatik == 2)
            {
                pcpuan++;
                label8.Text = pcpuan.ToString();
                label5.Text = "Makas kağıdı keser";
                label9.Text = "bilgisyarın secimi makas";
            }
            kazan();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            otomatik = random.Next(3);
            if (otomatik == 0)
            {
                
                pcpuan++;
                label8.Text = pcpuan.ToString();
                label5.Text = "taş makası kırar";
                label9.Text = "bilgisyarın secimi taş";

            }
            else if (otomatik == 1)
            {
                
                oyuncupuan++;
                label7.Text = oyuncupuan.ToString();
                label5.Text = "makas kağıdı keser";
                label9.Text = "bilgisyarın secimi kağıt";

            }
            else if (otomatik == 2)
            {
               
                label5.Text = "Berabere";
                label9.Text = "bilgisyarın secimi makas";
            }
            kazan();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
          
            
            
        }

        private void button1_ControlAdded(object sender, ControlEventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            button1.Visible = false;
            label6.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
        }
    }
}
