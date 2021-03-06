using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace PosteTriangle.PL
{
    public partial class User_Client_Affichage : UserControl
    {
       


        private static User_Client_Affichage UserAffichage;
        //Creer un instance pour le usercontrole Affichage 
        public static User_Client_Affichage Instance1
        {
            get
            {
                if (UserAffichage == null)
                {
                    UserAffichage = new User_Client_Affichage();
                }
                return UserAffichage;
            }
        }
        public User_Client_Affichage()
        {
            InitializeComponent();
           


        }

        private void User_Client_Affichage_Load(object sender, EventArgs e)
        {
            // hide labels 
            labelCT.Visible = false;
            labelQt.Visible = false;
            labelSec.Visible = false;
            labelTC.Visible = false;
            labelTKTCT.Visible = false;
            labelTrg.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;

            solidGaugeTRG.Visible = false;
            label3.Visible = false;
            solidGaugeTC.Visible = false;
            label2.Visible = false;
            chart1.Visible = false;
        }
        






        private void TxtPer_LT_Enter(object sender, EventArgs e)
        {
            
        }

        private void TxtPer_LT_Leave(object sender, EventArgs e)
        {
            
        }

        private void Btn_Performance_Click(object sender, EventArgs e)
        {
            solidGaugeTRG.Visible = true;
            label3.Visible = true;
            solidGaugeTC.Visible = true;
            label2.Visible = true;
            chart1.Visible = true;

            if (TxtDate.Text== "Date")
            {
                MessageBox.Show("Entrer la Date d'aujourd'hui d'abord et cliquer sur le button Performance  ", "Lire le Guide ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {


                BL.CDB db = new BL.CDB();
                db.openConnection();

             



                // a modifer pour chaque Poste 

                MySqlDataAdapter asdf = new MySqlDataAdapter("SELECT * from saisie_poste WHERE Date = '" + TxtDate.Text + "' AND Nom_Atelier='Vague'", db.getConnection());
                DataTable ss = new DataTable();
                asdf.Fill(ss);
                TxtNomAtelier.Text = ss.Rows[0][1].ToString();
                string v = ss.Rows[0][3].ToString(); // get PC from saisie_poste
                string w = ss.Rows[0][4].ToString();//get PNC from saisie_poste
                string tk = ss.Rows[0][6].ToString();// get TKT from saisie_poste

                int sum = int.Parse(w) + int.Parse(v); //calcule de la QT 
                TxtQteProduite.Text = sum.ToString(); //set QT dans TXTBOX

                string t = ss.Rows[0][9].ToString(); // get time from saisie_poste

                decimal ct = (decimal)int.Parse(t) / (sum); // calcule de cycle time
                decimal ctr = Math.Round(ct, 2);
                TxtCycleTime.Text = ctr.ToString(); // set cycle time dans TXTBOX



                decimal tkct = Math.Abs(int.Parse(tk) - ct); //calcule de TKTvsCT
                decimal tktctr = Math.Round(tkct, 2);

                if (tktctr <= 3)
                {
                    TxtPer_TKTCT.Text = tktctr.ToString(); //set TKTCT dans txtbox
                    TxtPer_TKTCT.ForeColor = Color.DarkGreen;
                    button3.Visible = true;
                }
                else
                {
                    TxtPer_TKTCT.Text = tktctr.ToString(); //set TKTCT dans txtbox
                    TxtPer_TKTCT.ForeColor = Color.Crimson;
                    button4.Visible = true;

                }







                decimal Trg = (decimal)(int.Parse(v) * ct) * 100 / 1207;  // calcule TRG
                decimal Trgr = Math.Round(Trg, 2); // round with two number

                solidGaugeTRG.Uses360Mode = false;
                solidGaugeTRG.From = 0;
                solidGaugeTRG.To = 100;
                solidGaugeTRG.Value = (double)(decimal)Trgr;
                

                if (Trgr >= 70)
                {
                    TxtPer_TRG.Text = Trgr.ToString(); //  set %TRG to TXTBOX
                    TxtPer_TRG.ForeColor = Color.DarkGreen;
                    button8.Visible = true;
                    





                }
                else
                {
                    TxtPer_TRG.Text = Trgr.ToString(); //  set %TRG to TXTBOX
                    TxtPer_TRG.ForeColor = Color.Crimson;
                    button7.Visible = true;

                }










                decimal tc = (decimal)(int.Parse(v) * 100 / sum); // calcule TC
                decimal tcr = Math.Round(tc, 2); // round with two number

                solidGaugeTC.Uses360Mode = false;
                solidGaugeTC.From = 0;
                solidGaugeTC.To = 100;
                solidGaugeTC.Value = (double)(decimal)tcr;




                if (tcr > 80)
                {
                    TxtPer_TauxConfor.Text = tcr.ToString(); // set %CONFORMITe to TXTBOX

                    TxtPer_TauxConfor.ForeColor = Color.DarkGreen;
                    button6.Visible = true;


                } else
                {
                    TxtPer_TauxConfor.Text = tcr.ToString(); // set %CONFORMITe to TXTBOX

                    TxtPer_TauxConfor.ForeColor = Color.Crimson;
                    button5.Visible = true;
                }
                
                
                












                //close the connection
                db.closeConnection();



                db.openConnection();

                // get valeur de stock triangle 

                MySqlDataAdapter asdf1 = new MySqlDataAdapter("SELECT * from stock_poste WHERE Date = '" + TxtDate.Text + "'", db.getConnection());
                DataTable ss1 = new DataTable();
                asdf1.Fill(ss1);
                string s = ss1.Rows[0][5].ToString(); // a modifier pour chaque poste 
                if (int.Parse(s) <= 4)
                {
                    TxtPer_StockEC_Atelier.Text = s.ToString();
                    TxtPer_StockEC_Atelier.ForeColor = Color.DarkGreen;
                    button10.Visible = true;
                }
                else
                {
                    TxtPer_StockEC_Atelier.Text = s.ToString();
                    TxtPer_StockEC_Atelier.ForeColor = Color.Crimson;
                    button9.Visible = true;

                }
                //--------------------------------------------------------------------------------------------------------------------
                MySqlDataAdapter asdf2 = new MySqlDataAdapter("SELECT Striangle ,Date from stock_poste ", db.getConnection());
                DataSet ds = new DataSet();

                asdf2.Fill(ds, "Striangle");
                chart1.DataSource = ds.Tables["Striangle"];
                Series series1 = chart1.Series["Series1"];
                series1.ChartType = SeriesChartType.Column;

                series1.Name = "Stock Poste Triangle";

                var chart = chart1;
                chart.Series[series1.Name].XValueMember = "Date";
                chart.Series[series1.Name].YValueMembers = "Striangle";

                chart.Series[0].IsValueShownAsLabel = true;
                chart.Series[0]["pieLabelStyle"] = "outside";
                chart.Series[0].BorderWidth = 1;
                chart.Series[0].BorderColor = Color.Black;
                chart.ChartAreas[0].Area3DStyle.Enable3D = true;













                db.closeConnection();
                





                //show labels 

                labelCT.Visible = true;
                labelQt.Visible = true;
                labelSec.Visible = true;
                labelTC.Visible = true;
                labelTKTCT.Visible = true;
                labelTrg.Visible = true;



            }


        }

        private void TxtDate_Enter(object sender, EventArgs e)
        {
            //Pour vider le textBox
            if (TxtDate.Text == "Date")
            {
                TxtDate.Text = "";
                TxtDate.ForeColor = Color.DarkGray;



            }
        }

        private void TxtDate_Leave(object sender, EventArgs e)
        {
            if (TxtDate.Text == "")
            {
                TxtDate.Text = "Date";
                TxtDate.ForeColor = Color.Silver;
            }
        }

        private void BtnSuvegarderp_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtPer_TRG.Text == "TRG ")
                {
                    MessageBox.Show("cliquer sur le button Performance ET vérifier si les champs sont remplis", "Lire le Guide ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {



                    BL.CDB db = new BL.CDB();
                    MySqlCommand command = new MySqlCommand("INSERT INTO `affichage_poste`(`Date`, `Stock`, `TRG`, `Taux_conformité`, `Cycle_Time`, `TKT_VS_CT`, `Nom_Atelier`) VALUES (@dt, @st, @trg, @tc, @ct, @tktct, @nat)", db.getConnection());

                    // fill table affichage_poste    
                    command.Parameters.Add("@dt", MySqlDbType.VarChar).Value = TxtDate.Text;
                    command.Parameters.Add("@st", MySqlDbType.VarChar).Value = TxtPer_StockEC_Atelier.Text;
                    command.Parameters.Add("@trg", MySqlDbType.VarChar).Value = TxtPer_TRG.Text;
                    command.Parameters.Add("@tc", MySqlDbType.VarChar).Value = TxtPer_TauxConfor.Text;
                    command.Parameters.Add("@ct", MySqlDbType.VarChar).Value = TxtCycleTime.Text;
                    command.Parameters.Add("@tktct", MySqlDbType.VarChar).Value = TxtPer_TKTCT.Text;
                    command.Parameters.Add("@nat", MySqlDbType.VarChar).Value = TxtNomAtelier.Text;




                    //open the onnection       

                    db.openConnection();

                    //execute Query
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Données de votre poste est transférée au poste Pilote ");
                    }
                    else
                    {
                        MessageBox.Show("Données NON enregistrées");
                    }

                    //close the connection
                    db.closeConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("vérifier si les champs sont remplis ", "Lire le Guide ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void elementHost2_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void solidGaugeTC_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("c:\\Users\\khalis\\Desktop\\visual studio projects\\KPI Triangle.pbix");
        }

        private void solidGaugeTRG_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
