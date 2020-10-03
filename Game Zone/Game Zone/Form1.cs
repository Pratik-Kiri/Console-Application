using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Zone
{
    public partial class Form1 : Form
    {
        double Xbox360_price = 300;
        double xbox1_price = 450;
        double ps3_price = 300;
        double ps4_price = 500;
        double gamingpc_price = 400;
        int T;
       public string s1, s2;

        public Form1()
        {
            InitializeComponent();
        }
        void time()
        {
            if (rb1.Checked == true)
            {
                T = 1;
            }

            else if (rb2.Checked == true)
            {
                T = 2;
            }
            else if (rb3.Checked == true)
            {
                T = 3;
            }
            else if (rb4.Checked == true)
            {
                T = 4;
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();

            lstconsole.Items.Add("Xbox360");
            lstconsole.Items.Add("Xbox1");
            lstconsole.Items.Add("Ps3");
            lstconsole.Items.Add("Ps4");
            lstconsole.Items.Add("Gaming PC");

            chkfifa.Checked = false;
            chkwwe.Checked = false;
            chknfs.Checked = false;
            chkcallofduty.Checked = false;
            chkgta.Checked = false;

            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = false;
            rb4.Checked = false;

            rtfReceipt.Clear();
            lblPrice.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chkfifa.Checked = false;
            chkwwe.Checked = false;
            chknfs.Checked = false;
            chkcallofduty.Checked = false;
            chkgta.Checked = false;

            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = false;
            rb4.Checked = false;

            rtfReceipt.Clear();
            lblPrice.Text = "";
            lstconsole.ClearSelected();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Do you want to exit","System off",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void btnprice_Click(object sender, EventArgs e)
        {
            if (lstconsole.Text == "")
            {
                MessageBox.Show("You must select a platform", "Platform", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if ((chkfifa.Checked == false) && (chkwwe.Checked == false) && (chknfs.Checked == false) && (chkcallofduty.Checked == false) && (chkgta.Checked == false))
            {
                MessageBox.Show("You must select a Game", "Game", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            if ((rb1.Checked == false) && (rb2.Checked == false) && (rb3.Checked == false) && (rb4.Checked == false))
            {
                MessageBox.Show("You must select Time Period", "Time Period", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            //-------------------------------------
            if (lstconsole.Text == "Xbox1" && chknfs.Checked == true && rb1.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(xbox1_price * 1.3);
                s1 = "NFS";
                s2 = "1 hr";
            }
            else if (lstconsole.Text == "Xbox1" && chknfs.Checked == true && rb2.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(xbox1_price * 2.3);
                s1 = "NFS";
                s2 = "2hr";
            }
            else if (lstconsole.Text == "Xbox1" && chknfs.Checked == true && rb3.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(xbox1_price * 3.3);
                s1 = "NFS";
                s2 = "3 hr";
          }
            else if (lstconsole.Text == "Xbox1" && chknfs.Checked == true && rb4.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(xbox1_price * 4.3);
                s1 = "NFS";
                s2 = "4hr";
            }
            //-----------------------------------------------------------


            //-------------------------------------------
            if (((chkfifa.Checked == true) || (chkwwe.Checked == true) || (chknfs.Checked == true) || (chkcallofduty.Checked == true) || (chkgta.Checked == true)) || ((rb1.Checked == true) || (rb2.Checked == true) || (rb3.Checked == true) || (rb4.Checked == true)) && (lstconsole.Text!=""))
            {
                
                DialogResult confirm = MessageBox.Show("Platform:"+lstconsole.Text+"\nGames:"+s1+"\nTime:"+s2,"Confirmation",MessageBoxButtons.OKCancel);
                if(confirm==DialogResult.Cancel)
                {

                    chkfifa.Checked = false;
                    chkwwe.Checked = false;
                    chknfs.Checked = false;
                    chkcallofduty.Checked = false;
                    chkgta.Checked = false;

                    rb1.Checked = false;
                    rb2.Checked = false;
                    rb3.Checked = false;
                    rb4.Checked = false;
                }
               
            }
           


            //-------------------------------------------------------------------------------------------------------------------------------------------------

            if (lstconsole.Text == "Xbox360" && chkfifa.Checked == true && rb1.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(Xbox360_price * 1.5);
                s1 = "Fifa";
                s1 = "1hr";
            }
            else if (lstconsole.Text == "Xbox360" && chkfifa.Checked == true && rb2.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(Xbox360_price * 2.5);
                s1 = "Fifa";
            }
            else if (lstconsole.Text == "Xbox360" && chkfifa.Checked == true && rb3.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(Xbox360_price * 3.5);
                s1 = "Fifa";
            }
            else if (lstconsole.Text == "Xbox360" && chkfifa.Checked == true && rb4.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(Xbox360_price * 4.5);
                s1 = "Fifa";
            }

            //----------------------------------------------------------------------------------------------------------------------------------------------------


            if (lstconsole.Text == "Xbox360" && chkwwe.Checked == true && rb1.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(Xbox360_price * 1.4);
            }
            else if (lstconsole.Text == "Xbox360" && chkwwe.Checked == true && rb2.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(Xbox360_price * 2.4);
            }
            else if (lstconsole.Text == "Xbox360" && chkwwe.Checked == true && rb3.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(Xbox360_price * 3.4);
            }
            else if (lstconsole.Text == "Xbox360" && chkwwe.Checked == true && rb4.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(Xbox360_price * 4.4);
            }

            //----------------------------------------------------------------------------------------------------------------------------------------------------
            if (lstconsole.Text == "Xbox360" && chknfs.Checked == true && rb1.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(Xbox360_price * 1.3);
                s1 = "NFS";
            }
            else if (lstconsole.Text == "Xbox360" && chknfs.Checked == true && rb2.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(Xbox360_price * 2.3);
                s1 = "NFS";
            }
            else if (lstconsole.Text == "Xbox360" && chknfs.Checked == true && rb3.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(Xbox360_price * 3.3);
                s1 = "NFS";
            }
            else if (lstconsole.Text == "Xbox360" && chknfs.Checked == true && rb4.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(Xbox360_price * 4.3);
                s1 = "NFS";
            }

            //----------------------------------------------------------------------------------------------------------------------------------------------------
            if (lstconsole.Text == "Xbox360" && chkcallofduty.Checked == true && rb1.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(Xbox360_price * 1.2);
                s1 = "Call of Duty";
            }
            else if (lstconsole.Text == "Xbox360" && chkcallofduty.Checked == true && rb2.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(Xbox360_price * 2.2);
                s1 = "Call of Duty";
            }
            else if (lstconsole.Text == "Xbox360" && chkcallofduty.Checked == true && rb3.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(Xbox360_price * 3.2);
                s1 = "Call of Duty";
            }
            else if (lstconsole.Text == "Xbox360" && chkcallofduty.Checked == true && rb4.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(Xbox360_price * 4.2);
                s1 = "Call of Duty";
            }

            //----------------------------------------------------------------------------------------------------------------------------------------------------
            if (lstconsole.Text == "Xbox360" && chkgta.Checked == true && rb1.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(Xbox360_price * 1);
                s1 = "GTA V";
            }
            else if (lstconsole.Text == "Xbox360" && chkgta.Checked == true && rb2.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(Xbox360_price * 2);
                s1 = "GTA V";
            }
            else if (lstconsole.Text == "Xbox360" && chkgta.Checked == true && rb3.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(Xbox360_price * 3);
            }
            else if (lstconsole.Text == "Xbox360" && chkgta.Checked == true && rb4.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(Xbox360_price * 4);
                s1 = "GTA V";
            }

            //----------------------------------------------------------------------------------------------------------------------------------------------------

            //-------------------------------------------------------------------------------------------------------------------------------------------------

            if (lstconsole.Text == "Xbox1" && chkfifa.Checked == true && rb1.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(xbox1_price * 1.5);
                s1 = "Fifa";
            }
            else if (lstconsole.Text == "Xbox1" && chkfifa.Checked == true && rb2.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(xbox1_price * 2.5);
                s1 = "GTA V";
            }
            else if (lstconsole.Text == "Xbox1" && chkfifa.Checked == true && rb3.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(xbox1_price * 3.5);
                s1 = "GTA V";
            }
            else if (lstconsole.Text == "Xbox1" && chkfifa.Checked == true && rb4.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(xbox1_price * 4.5);
                s1 = "GTA V";
            }


            //----------------------------------------------------------------------------------------------------------------------------------------------------

            if (lstconsole.Text == "Xbox1" && chkwwe.Checked == true && rb1.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(xbox1_price * 1.4);
                s1 = "WWE";
            }
            else if (lstconsole.Text == "Xbox1" && chkwwe.Checked == true && rb2.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(xbox1_price * 2.4);
                s1 = "WWE";
            }
            else if (lstconsole.Text == "Xbox1" && chkwwe.Checked == true && rb3.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(xbox1_price * 3.4);
                s1 = "WWE";
            }
            else if (lstconsole.Text == "Xbox1" && chkwwe.Checked == true && rb4.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(xbox1_price * 4.4);
                s1 = "WWE";
            }

            //----------------------------------------------------------------------------------------------------------------------------------------------------
            if (lstconsole.Text == "Xbox1" && chknfs.Checked == true && rb1.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(xbox1_price * 1.3);
                s1 = "NFS";
            }
            else if (lstconsole.Text == "Xbox1" && chknfs.Checked == true && rb2.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(xbox1_price * 2.3);
                s1 = "NFS";
            }
            else if (lstconsole.Text == "Xbox1" && chknfs.Checked == true && rb3.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(xbox1_price * 3.3);
                s1 = "NFS";
            }
            else if (lstconsole.Text == "Xbox1" && chknfs.Checked == true && rb4.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(xbox1_price * 4.3);
                s1 = "NFS";
            }

            //----------------------------------------------------------------------------------------------------------------------------------------------------
            if (lstconsole.Text == "Xbox1" && chkcallofduty.Checked == true && rb1.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(xbox1_price * 1.2);
                s1 = "Call OF Duty";
            }
            else if (lstconsole.Text == "Xbox1" && chkcallofduty.Checked == true && rb2.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(xbox1_price * 2.2);
                s1 = "Call OF Duty";
            }
            else if (lstconsole.Text == "Xbox1" && chkcallofduty.Checked == true && rb3.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(xbox1_price * 3.2);
                s1 = "Call OF Duty";
            }
            else if (lstconsole.Text == "Xbox1" && chkcallofduty.Checked == true && rb4.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(xbox1_price * 4.2);
                s1 = "Call OF Duty";
            }


            //----------------------------------------------------------------------------------------------------------------------------------------------------
            if (lstconsole.Text == "Xbox1" && chkgta.Checked == true && rb1.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(xbox1_price * 1);
            }
            else if (lstconsole.Text == "Xbox1" && chkgta.Checked == true && rb2.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(xbox1_price * 2);
            }
            else if (lstconsole.Text == "Xbox1" && chkgta.Checked == true && rb3.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(xbox1_price * 3);
            }
            else if (lstconsole.Text == "Xbox1" && chkgta.Checked == true && rb4.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(xbox1_price * 4);
            }

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------------------------------------------------------------------

            if (lstconsole.Text == "Ps3" && chkfifa.Checked == true && rb1.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps3_price * 1.5);
            }
            else if (lstconsole.Text == "Ps3" && chkfifa.Checked == true && rb2.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps3_price * 2.5);
            }
            else if (lstconsole.Text == "Ps3" && chkfifa.Checked == true && rb3.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps3_price * 3.5);
            }
            else if (lstconsole.Text == "Ps3" && chkfifa.Checked == true && rb4.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps3_price * 4.5);
            }

            //----------------------------------------------------------------------------------------------------------------------------------------------------

            if (lstconsole.Text == "Ps3" && chkwwe.Checked == true && rb1.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps3_price * 1.4);
            }
            else if (lstconsole.Text == "Ps3" && chkwwe.Checked == true && rb2.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps3_price * 2.4);
            }
            else if (lstconsole.Text == "Ps3" && chkwwe.Checked == true && rb3.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps3_price * 3.4);
            }
            else if (lstconsole.Text == "Ps3" && chkwwe.Checked == true && rb4.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps3_price * 4.4);
            }

            //----------------------------------------------------------------------------------------------------------------------------------------------------
            if (lstconsole.Text == "Ps3" && chknfs.Checked == true && rb1.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps3_price * 1.3);
            }
            else if (lstconsole.Text == "Ps3" && chknfs.Checked == true && rb2.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps3_price * 2.3);
            }
            else if (lstconsole.Text == "Ps3" && chknfs.Checked == true && rb3.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps3_price * 3.3);
            }
            else if (lstconsole.Text == "Ps3" && chknfs.Checked == true && rb4.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps3_price * 4.3);
            }

            //----------------------------------------------------------------------------------------------------------------------------------------------------
            if (lstconsole.Text == "Ps3" && chkcallofduty.Checked == true && rb1.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps3_price * 1.2);
            }
            else if (lstconsole.Text == "Ps3" && chkcallofduty.Checked == true && rb2.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps3_price * 2.2);
            }
            else if (lstconsole.Text == "Ps3" && chkcallofduty.Checked == true && rb3.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps3_price * 3.2);
            }
            else if (lstconsole.Text == "Ps3" && chkcallofduty.Checked == true && rb4.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps3_price * 4.2);
            }

            //----------------------------------------------------------------------------------------------------------------------------------------------------
            if (lstconsole.Text == "Ps3" && chkgta.Checked == true && rb1.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps3_price * 1);
            }
            else if (lstconsole.Text == "Ps3" && chkgta.Checked == true && rb2.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps3_price * 2);
            }
            else if (lstconsole.Text == "Ps3" && chkgta.Checked == true && rb3.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps3_price * 3);
            }
            else if (lstconsole.Text == "Ps3" && chkgta.Checked == true && rb4.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps3_price * 4);
            }

            //----------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------------------------------------------------------------------

            if (lstconsole.Text == "Ps4" && chkfifa.Checked == true && rb1.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps4_price * 1.5);
            }
            else if (lstconsole.Text == "Ps4" && chkfifa.Checked == true && rb2.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps4_price * 2.5);
            }
            else if (lstconsole.Text == "Ps4" && chkfifa.Checked == true && rb3.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps4_price * 3.5);
            }
            else if (lstconsole.Text == "Ps4" && chkfifa.Checked == true && rb4.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps4_price * 4.5);
            }

            //----------------------------------------------------------------------------------------------------------------------------------------------------

            if (lstconsole.Text == "Ps4" && chkwwe.Checked == true && rb1.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps4_price * 1.4);
            }
            else if (lstconsole.Text == "Ps4" && chkwwe.Checked == true && rb2.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps4_price * 2.4);
            }
            else if (lstconsole.Text == "Ps4" && chkwwe.Checked == true && rb3.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps4_price * 3.4);
            }
            else if (lstconsole.Text == "Ps4" && chkwwe.Checked == true && rb4.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps4_price * 4.4);
            }

            //----------------------------------------------------------------------------------------------------------------------------------------------------
            if (lstconsole.Text == "Ps4" && chknfs.Checked == true && rb1.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps4_price * 1.3);
            }
            else if (lstconsole.Text == "Ps4" && chknfs.Checked == true && rb2.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps4_price * 2.3);
            }
            else if (lstconsole.Text == "Ps4" && chknfs.Checked == true && rb3.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps4_price * 3.3);
            }
            else if (lstconsole.Text == "Ps4" && chknfs.Checked == true && rb4.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps4_price * 4.3);
            }

            //----------------------------------------------------------------------------------------------------------------------------------------------------
            if (lstconsole.Text == "Ps4" && chkcallofduty.Checked == true && rb1.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps4_price * 1.2);
                s1 = "Call OF Duty";
            }
            else if (lstconsole.Text == "Ps4" && chkcallofduty.Checked == true && rb2.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps4_price * 2.2);
                s1 = "Call OF Duty";
            }
            else if (lstconsole.Text == "Ps4" && chkcallofduty.Checked == true && rb3.Checked == true)
            {
            
                lblPrice.Text = System.Convert.ToString(ps4_price * 3.2);
                s1 = "Call OF Duty";
            }
            else if (lstconsole.Text == "Ps4" && chkcallofduty.Checked == true && rb4.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps4_price * 4.2);
                s1 = "Call OF Duty";
            }

            //----------------------------------------------------------------------------------------------------------------------------------------------------
            if (lstconsole.Text == "Ps4" && chkgta.Checked == true && rb1.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps4_price * 1);
            }
            else if (lstconsole.Text == "Ps4" && chkgta.Checked == true && rb2.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps4_price * 2);
            }
            else if (lstconsole.Text == "Ps4" && chkgta.Checked == true && rb3.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps4_price * 3);
            }
            else if (lstconsole.Text == "Ps4" && chkgta.Checked == true && rb4.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(ps4_price * 4);
            }

            //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------------------------------------------------------------------

            if (lstconsole.Text == "Gaming PC" && chkfifa.Checked == true && rb1.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(gamingpc_price * 1.5);
            }
            else if (lstconsole.Text == "Gaming PC" && chkfifa.Checked == true && rb2.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(gamingpc_price * 2.5);
            }
            else if (lstconsole.Text == "Gaming PC" && chkfifa.Checked == true && rb3.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(gamingpc_price * 3.5);
            }
            else if (lstconsole.Text == "Gaming PC" && chkfifa.Checked == true && rb4.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(gamingpc_price * 4.5);
            }

            //----------------------------------------------------------------------------------------------------------------------------------------------------

            if (lstconsole.Text == "Gaming PC" && chkwwe.Checked == true && rb1.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(gamingpc_price * 1.4);
            }
            else if (lstconsole.Text == "Gaming PC" && chkwwe.Checked == true && rb2.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(gamingpc_price * 2.4);
            }
            else if (lstconsole.Text == "Gaming PC" && chkwwe.Checked == true && rb3.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(gamingpc_price * 3.4);
            }
            else if (lstconsole.Text == "Gaming PC" && chkwwe.Checked == true && rb4.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(gamingpc_price * 4.4);
            }

            //----------------------------------------------------------------------------------------------------------------------------------------------------
            if (lstconsole.Text == "Gaming PC" && chknfs.Checked == true && rb1.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(gamingpc_price * 1.3);
            }
            else if (lstconsole.Text == "Gaming PC" && chknfs.Checked == true && rb2.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(gamingpc_price * 2.3);
            }
            else if (lstconsole.Text == "Gaming PC" && chknfs.Checked == true && rb3.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(gamingpc_price * 3.3);
            }
            else if (lstconsole.Text == "Gaming PC" && chknfs.Checked == true && rb4.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(gamingpc_price * 4.3);
            }

            //----------------------------------------------------------------------------------------------------------------------------------------------------
            if (lstconsole.Text == "Gaming PC" && chkcallofduty.Checked == true && rb1.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(gamingpc_price * 1.2);
                s1 = "Call OF Duty";
            }
            else if (lstconsole.Text == "Gaming PC" && chkcallofduty.Checked == true && rb2.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(gamingpc_price * 2.2);
                s1 = "Call OF Duty";
            }
            else if (lstconsole.Text == "Gaming PC" && chkcallofduty.Checked == true && rb3.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(gamingpc_price * 3.2);
                s1 = "Call OF Duty";
            }
            else if (lstconsole.Text == "Gaming PC" && chkcallofduty.Checked == true && rb4.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(gamingpc_price * 4.2);
                s1 = "Call OF Duty";
            }

            //----------------------------------------------------------------------------------------------------------------------------------------------------
            if (lstconsole.Text == "Gaming PC" && chkgta.Checked == true && rb1.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(gamingpc_price * 1);
            }
            else if (lstconsole.Text == "Gaming PC" && chkgta.Checked == true && rb2.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(gamingpc_price * 2);
            }
            else if (lstconsole.Text == "Gaming PC" && chkgta.Checked == true && rb3.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(gamingpc_price * 3);
            }
            else if (lstconsole.Text == "Gaming PC" && chkgta.Checked == true && rb4.Checked == true)
            {
                lblPrice.Text = System.Convert.ToString(gamingpc_price * 4);
            }

            //--------------------------------------------------------------------------------------------------------------------------------------------------------


        }

        private void btnreceipt_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();
            time();
            if (chkfifa.Checked == true)
            {
                rtfReceipt.AppendText("\t\t" + "Glued Reloaded" + Environment.NewLine);
                rtfReceipt.AppendText("------------------------------------------------------------------------" + Environment.NewLine);
                rtfReceipt.AppendText("Platform" + "\t\t\t" + lstconsole.Text + Environment.NewLine);
                rtfReceipt.AppendText("Game" + "\t\t\t" + chkfifa.Text + Environment.NewLine);
                rtfReceipt.AppendText("Time" + "\t\t\t" + T + Environment.NewLine);
                rtfReceipt.AppendText("Price" + "\t\t\t" + lblPrice.Text + Environment.NewLine);
            }

            if (chkwwe.Checked == true)
            {
                rtfReceipt.AppendText("\t\t" + "Glued Reloaded" + Environment.NewLine);
                rtfReceipt.AppendText("------------------------------------------------------------------------" + Environment.NewLine);
                rtfReceipt.AppendText("Platform" + "\t\t\t" + lstconsole.Text + Environment.NewLine);
                rtfReceipt.AppendText("Game" + "\t\t\t" + chkwwe.Text + Environment.NewLine);
                rtfReceipt.AppendText("Time" + "\t\t\t" + T + Environment.NewLine);
                rtfReceipt.AppendText("Price" + "\t\t\t" + lblPrice.Text + Environment.NewLine);
            }

            if (chknfs.Checked == true)
            {
                rtfReceipt.AppendText("\t\t" + "Glued Reloaded" + Environment.NewLine);
                rtfReceipt.AppendText("--------------------------------------------------------------------------" + Environment.NewLine);
                rtfReceipt.AppendText("Platform" + "\t\t\t" + lstconsole.Text + Environment.NewLine);
                rtfReceipt.AppendText("Game" + "\t\t\t" + chknfs.Text + Environment.NewLine);
                rtfReceipt.AppendText("Time" + "\t\t\t" + T + Environment.NewLine);
                rtfReceipt.AppendText("Price" + "\t\t\t" + lblPrice.Text + Environment.NewLine);
            }

            if (chkcallofduty.Checked == true)
            {
                rtfReceipt.AppendText("\t\t" + "Glued Reloaded" + Environment.NewLine);
                rtfReceipt.AppendText("-------------------------------------------------------------------------" + Environment.NewLine);
                rtfReceipt.AppendText("Platform" + "\t\t\t" + lstconsole.Text + Environment.NewLine);
                rtfReceipt.AppendText("Game" + "\t\t\t" + chkcallofduty.Text + Environment.NewLine);
                rtfReceipt.AppendText("Time" + "\t\t\t" + T + Environment.NewLine);
                rtfReceipt.AppendText("Price" + "\t\t\t" + lblPrice.Text + Environment.NewLine);
            }

            if (chkgta.Checked == true)
            {
                rtfReceipt.AppendText("\t\t" + "Glued Reloaded" + Environment.NewLine);
                rtfReceipt.AppendText("-----------------------------------------------------------------------" + Environment.NewLine);
                rtfReceipt.AppendText("Platform" + "\t\t\t" + lstconsole.Text + Environment.NewLine);
                rtfReceipt.AppendText("Game" + "\t\t\t" + chkgta.Text + Environment.NewLine);
                rtfReceipt.AppendText("Time" + "\t\t\t" + T + Environment.NewLine);
                rtfReceipt.AppendText("Price" + "\t\t\t" + lblPrice.Text + Environment.NewLine);
            }

            
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Paste();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Copy();

        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Cut();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text File (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                sw.WriteLine(rtfReceipt.Text);
                
            }
      }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    rtfReceipt.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtfReceipt.Text, new Font ("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
