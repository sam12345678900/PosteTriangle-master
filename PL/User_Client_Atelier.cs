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
namespace PosteTriangle.PL
//this apps made by khalid djazi et ouissal allam soufiane halloumi please don't change this comment or delete it and don't change the names in the menu forms 
//you can add change add delete upgrade this app for better performance for the user experience FOR IMS promo 2021
//contact me khalid djazi by my mail adress khalid.djazi@esith.net 
{

    public partial class User_Client_Atelier : UserControl
    {

        private static User_Client_Atelier Userclient;
        //Creer un instance pour le usercontrole Atelier 
        public static User_Client_Atelier Instance
        {
            get
            {
                if (Userclient == null)
                {
                    Userclient = new User_Client_Atelier();
                }
                return Userclient;
            }
        }
        int value;
        public User_Client_Atelier()
        {
            InitializeComponent();

        }
        private int a = 0;
        private int b = 0;


        private void User_Client_Atelier_Load(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
        }



        private void TxtidAtelier_TextChanged(object sender, EventArgs e)
        {

        }



        private void TxtH_Debut_Enter(object sender, EventArgs e)
        {
            //Pour vider le textBox
            if (TxtH_Debut.Text == "Heure Début")
            {
                TxtH_Debut.Text = "";
                TxtH_Debut.ForeColor = Color.DarkGray;



            }

        }

        private void TxtH_Debut_Leave(object sender, EventArgs e)
        {
            if (TxtH_Debut.Text == "")
            {
                TxtH_Debut.Text = "Heure Début";
                TxtH_Debut.ForeColor = Color.Silver;
            }

        }





        private void TxtH_Fin_Enter(object sender, EventArgs e)
        {
            //Pour vider le textBox
            if (TxtH_Fin.Text == "Heure de Fin ")
            {
                TxtH_Fin.Text = "";
                TxtH_Fin.ForeColor = Color.DarkGray;



            }
        }

        private void TxtH_Fin_Leave(object sender, EventArgs e)
        {
            if (TxtH_Fin.Text == "")
            {
                TxtH_Fin.Text = "Heure de Fin ";
                TxtH_Fin.ForeColor = Color.Silver;
            }
        }

        private void TxtStockEc_Nominale_Enter(object sender, EventArgs e)
        {
            //Pour vider le textBox
            if (TxtStockEc_Nominale.Text == "Stock en Cours*")
            {
                TxtStockEc_Nominale.Text = "";
                TxtStockEc_Nominale.ForeColor = Color.DarkGray;



            }

        }

        private void TxtStockEc_Nominale_Leave(object sender, EventArgs e)
        {
            if (TxtStockEc_Nominale.Text == "")
            {
                TxtStockEc_Nominale.Text = "Stock en Cours*";
                TxtStockEc_Nominale.ForeColor = Color.Silver;
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



        private void TxtTKT_Time_Enter(object sender, EventArgs e)
        {
            //Pour vider le textBox
            if (TxtTKT_Time.Text == "Takt time")
            {
                TxtTKT_Time.Text = "";
                TxtTKT_Time.ForeColor = Color.DarkGray;

            }
        }

        private void TxtTKT_Time_Leave(object sender, EventArgs e)
        {
            if (TxtTKT_Time.Text == "")
            {
                TxtTKT_Time.Text = "Takt time";
                TxtTKT_Time.ForeColor = Color.Silver;
            }
        }

        private void TxtP_Conforme_Enter(object sender, EventArgs e)
        {
            //Pour vider le textBox
            if (TxtP_Conforme.Text == "Piéces Conformes")
            {
                TxtP_Conforme.Text = "";
                TxtP_Conforme.ForeColor = Color.DarkGray;

            }
        }

        private void TxtP_Conforme_Leave(object sender, EventArgs e)
        {
            if (TxtP_Conforme.Text == "")
            {
                TxtP_Conforme.Text = "Piéces Conformes";
                TxtP_Conforme.ForeColor = Color.Silver;
            }
        }

        private void TxtEffectif_Enter(object sender, EventArgs e)
        {
            //Pour vider le textBox
            if (TxtEffectif.Text == "Effectif")
            {
                TxtEffectif.Text = "";
                TxtEffectif.ForeColor = Color.DarkGray;

            }
        }

        private void TxtEffectif_Leave(object sender, EventArgs e)
        {
            if (TxtEffectif.Text == "")
            {
                TxtEffectif.Text = "Effectif";
                TxtEffectif.ForeColor = Color.Silver;
            }
        }

        private void TxtP_N_Conformes_Enter(object sender, EventArgs e)
        {
            //Pour vider le textBox
            if (TxtP_N_Conformes.Text == "Piéces Non Conformes")
            {
                TxtP_N_Conformes.Text = "";
                TxtP_N_Conformes.ForeColor = Color.DarkGray;

            }
        }

        private void TxtP_N_Conformes_Leave(object sender, EventArgs e)
        {
            if (TxtP_N_Conformes.Text == "")
            {
                TxtP_N_Conformes.Text = "Piéces Non Conformes";
                TxtP_N_Conformes.ForeColor = Color.Silver;
            }
        }

        private void TxtStock_EC_Enter(object sender, EventArgs e)
        {
            //Pour vider le textBox
            if (TxtStock_EC.Text == "Stock en Cours")
            {
                TxtStock_EC.Text = "";
                TxtStock_EC.ForeColor = Color.DarkGray;

            }
        }

        private void TxtStock_EC_Leave(object sender, EventArgs e)
        {

            if (TxtStock_EC.Text == "")
            {
                TxtStock_EC.Text = "Stock en Cours";
                TxtStock_EC.ForeColor = Color.Silver;
            }
        }


        private void TxtHeure_Leave(object sender, EventArgs e)
        {















        }

        private void TxtLead_Time_Nominal_Enter_1(object sender, EventArgs e)
        {

        }

        private void Btn_Commencer_Click(object sender, EventArgs e)
        {


        }

        private void TxtP_N_Conformes_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtP_Conforme_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNomAtelier_Enter(object sender, EventArgs e)
        {
            //Pour vider le textBox
            if (TxtNomAtelier.Text == "Nom Atelier")
            {
                TxtNomAtelier.Text = "";
                TxtNomAtelier.ForeColor = Color.DarkGray;

            }
        }

        private void TxtNomAtelier_Leave(object sender, EventArgs e)
        {
            if (TxtNomAtelier.Text == "")
            {
                TxtNomAtelier.Text = "Nom Atelier";
                TxtNomAtelier.ForeColor = Color.Silver;
            }
        }

        private void checkBoxPC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPC.Checked)
            {
                checkBoxPNC.Checked = false;
            }

            comboBox1.Visible = false;
            comboBoxPosteSuivant.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            

            try
            {
                


                //auto_increment pour PC et PNC et stocke 
                int s = Convert.ToInt32(TxtStockEc_Nominale.Text);
                if (s > 0)
                {
                    if (checkBoxPC.Checked && comboBoxPosteSuivant.Text != "Poste Suivant") 
                    {
                        a++;
                        TxtP_Conforme.Text = a.ToString();
                        checkBoxPC.Checked = false;


                        TxtStockEc_Nominale.Text = Convert.ToString(s - 1);
                        TxtStock_EC.Text = TxtStockEc_Nominale.Text;


                        


                        BL.CDB db = new BL.CDB();
                        MySqlCommand command = new MySqlCommand("UPDATE stock_poste SET Svague=@s WHERE Date=@dt ", db.getConnection());

                        // update stock  

                        command.Parameters.Add("@dt", MySqlDbType.VarChar).Value = TxtDate.Text;
                        command.Parameters.Add("@s", MySqlDbType.Int32).Value = TxtStockEc_Nominale.Text;



                        

                        //open the onnection       

                        db.openConnection();



                        //envoie OF a PF
                        if (comboBoxPosteSuivant.SelectedItem.Equals("PF"))
                        {
                            MySqlCommand command_1 = new MySqlCommand("UPDATE stock_poste SET PF=PF+1 WHERE Date=@dt ", db.getConnection());
                            command_1.Parameters.Add("@dt", MySqlDbType.VarChar).Value = TxtDate.Text;
                            command_1.ExecuteNonQuery();


                        }
                        //envoie OF au poste croix
                        if (comboBoxPosteSuivant.SelectedItem.Equals("Croix"))
                        {
                            MySqlCommand command_2 = new MySqlCommand("UPDATE stock_poste SET Scroix=Scroix+1 WHERE Date=@dt ", db.getConnection());
                            command_2.Parameters.Add("@dt", MySqlDbType.VarChar).Value = TxtDate.Text;
                            command_2.ExecuteNonQuery();


                        }
                        //envoie OF au poste vague
                        if (comboBoxPosteSuivant.SelectedItem.Equals("Vague"))
                        {
                            MySqlCommand command_3 = new MySqlCommand("UPDATE stock_poste SET Svague=Svague+1 WHERE Date=@dt ", db.getConnection());
                            command_3.Parameters.Add("@dt", MySqlDbType.VarChar).Value = TxtDate.Text;
                            command_3.ExecuteNonQuery();


                        }
                        //envoie OF au poste Etoile
                        if (comboBoxPosteSuivant.SelectedItem.Equals("Etoile"))
                        {
                            MySqlCommand command_4 = new MySqlCommand("UPDATE stock_poste SET Setoile=Setoile+1 WHERE Date=@dt ", db.getConnection());
                            command_4.Parameters.Add("@dt", MySqlDbType.VarChar).Value = TxtDate.Text;
                            command_4.ExecuteNonQuery();


                        }

                        //envoie OF au poste Ovale
                        if (comboBoxPosteSuivant.SelectedItem.Equals("Ovale"))
                        {
                            MySqlCommand command_5 = new MySqlCommand("UPDATE stock_poste SET Sovale=Sovale+1 WHERE Date=@dt ", db.getConnection());
                            command_5.Parameters.Add("@dt", MySqlDbType.VarChar).Value = TxtDate.Text;
                            command_5.ExecuteNonQuery();


                        }
                        //envoie OF au poste Rect
                        if (comboBoxPosteSuivant.SelectedItem.Equals("Rect"))
                        {
                            MySqlCommand command_6 = new MySqlCommand("UPDATE stock_poste SET Srect=Srect+1 WHERE Date=@dt ", db.getConnection());
                            command_6.Parameters.Add("@dt", MySqlDbType.VarChar).Value = TxtDate.Text;
                            command_6.ExecuteNonQuery();


                        }
                        //envoie OF au poste Triangle
                        if (comboBoxPosteSuivant.SelectedItem.Equals("Triangle"))
                        {
                            MySqlCommand command_7 = new MySqlCommand("UPDATE stock_poste SET Striangle=Striangle+1 WHERE Date=@dt ", db.getConnection());
                            command_7.Parameters.Add("@dt", MySqlDbType.VarChar).Value = TxtDate.Text;
                            command_7.ExecuteNonQuery();


                        }




                        //execute Query
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("sortie de produit");
                        }
                        else
                        {
                            MessageBox.Show("erreur lors sortie de produit ");
                        }

                        //close the connection
                        db.closeConnection();




                    }


                    // si la piece non conforme envoie au poste suivant 
                    if (checkBoxPNC.Checked && comboBox1.Text != "Poste Suivant ")
                    {

                        b++;
                        TxtP_N_Conformes.Text = b.ToString();
                        checkBoxPNC.Checked = false;

                        TxtStockEc_Nominale.Text = Convert.ToString(s - 1);
                        TxtStock_EC.Text = TxtStockEc_Nominale.Text;

                        BL.CDB db = new BL.CDB();
                        MySqlCommand command8 = new MySqlCommand("UPDATE stock_poste SET Striangle=@s WHERE Date=@dt ", db.getConnection());

                        // update stock  

                        command8.Parameters.Add("@dt", MySqlDbType.VarChar).Value = TxtDate.Text;
                        command8.Parameters.Add("@s", MySqlDbType.Int32).Value = TxtStockEc_Nominale.Text;

                        //open the onnection       

                        db.openConnection();

                        //envoie OF a PF
                        if (comboBox1.SelectedItem.Equals("PncPF"))
                        {
                            MySqlCommand command_12 = new MySqlCommand("UPDATE stock_poste SET PF=PF+1 WHERE Date=@dt ", db.getConnection());
                            command_12.Parameters.Add("@dt", MySqlDbType.VarChar).Value = TxtDate.Text;
                            command_12.ExecuteNonQuery();


                        }
                        //envoie OF au poste croix
                        if (comboBox1.SelectedItem.Equals("PncCroix"))
                        {
                            MySqlCommand command_23 = new MySqlCommand("UPDATE stock_poste SET Scroix=Scroix+1 WHERE Date=@dt ", db.getConnection());
                            command_23.Parameters.Add("@dt", MySqlDbType.VarChar).Value = TxtDate.Text;
                            command_23.ExecuteNonQuery();


                        }
                        //envoie OF au poste vague
                        if (comboBox1.SelectedItem.Equals("PncVague"))
                        {
                            MySqlCommand command_34 = new MySqlCommand("UPDATE stock_poste SET Svague=Svague+1 WHERE Date=@dt ", db.getConnection());
                            command_34.Parameters.Add("@dt", MySqlDbType.VarChar).Value = TxtDate.Text;
                            command_34.ExecuteNonQuery();


                        }
                        //envoie OF au poste Etoile
                        if (comboBox1.SelectedItem.Equals("PncEtoile"))
                        {
                            MySqlCommand command_45 = new MySqlCommand("UPDATE stock_poste SET Setoile=Setoile+1 WHERE Date=@dt ", db.getConnection());
                            command_45.Parameters.Add("@dt", MySqlDbType.VarChar).Value = TxtDate.Text;
                            command_45.ExecuteNonQuery();


                        }

                        //envoie OF au poste Ovale
                        if (comboBox1.SelectedItem.Equals("PncOvale"))
                        {
                            MySqlCommand command_56 = new MySqlCommand("UPDATE stock_poste SET Sovale=Sovale+1 WHERE Date=@dt ", db.getConnection());
                            command_56.Parameters.Add("@dt", MySqlDbType.VarChar).Value = TxtDate.Text;
                            command_56.ExecuteNonQuery();


                        }
                        //envoie OF au poste Rect
                        if (comboBox1.SelectedItem.Equals("PncRect"))
                        {
                            MySqlCommand command_67 = new MySqlCommand("UPDATE stock_poste SET Srect=Srect+1 WHERE Date=@dt ", db.getConnection());
                            command_67.Parameters.Add("@dt", MySqlDbType.VarChar).Value = TxtDate.Text;
                            command_67.ExecuteNonQuery();


                        }
                        //envoie OF au poste Triangle
                        if (comboBox1.SelectedItem.Equals("PncTriangle"))
                        {
                            MySqlCommand command_78 = new MySqlCommand("UPDATE stock_poste SET Striangle=Striangle+1 WHERE Date=@dt ", db.getConnection());
                            command_78.Parameters.Add("@dt", MySqlDbType.VarChar).Value = TxtDate.Text;
                            command_78.ExecuteNonQuery();


                        }







                        //execute Query
                        if (command8.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("sortie de produit");
                        }
                        else
                        {
                            MessageBox.Show("erreur lors sortie de produit ");
                        }

                        //close the connection
                        db.closeConnection();




                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Entrer la Date d'aujourd'hui d'abord et cliquer sur le button ouverture ", "Lire le Guide ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    






        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                TxtNomAtelier.Text = "Vague";
                TxtEffectif.Text = Convert.ToString(1);
                TxtTKT_Time.Text = Convert.ToString(16);

                BL.CDB db = new BL.CDB();
                db.openConnection();

                // a modifer pour chaque Poste 

                MySqlDataAdapter asdf = new MySqlDataAdapter("SELECT * from stock_poste WHERE Date = '" + TxtDate.Text + "'", db.getConnection());
                DataTable ss = new DataTable();
                asdf.Fill(ss);
                TxtStockEc_Nominale.Text = ss.Rows[0][6].ToString();






                //close the connection
                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Entrer la Date d'aujourd'hui d'abord et cliquer sur le button ouverture ", "Lire le Guide ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timer1.Stop();
                timer2.Stop();
            }




        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
                if (TxtDate.Text == "Date")
                {
                    MessageBox.Show("Entrer la Date d'aujourd'hui d'abord et cliquer sur le button ouverture ", "Lire le Guide ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {

                    if (int.TryParse(TxtTimer.Text, out value))
                    {
                        timer1.Start();
                    }
                    TxtH_Debut.Text = DateTime.Now.ToString("HH:mm:ss");

                    timer2.Start();
                    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                    timer.Interval = 3000;
                    timer.Tick += new EventHandler(timer2_Tick);
                }
           


        }

        private void BtnFermeture_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxtH_Debut.Text=="Heure Début")
                {
                    MessageBox.Show("cliquer sur le button ouverture d'abord", "Lire le Guide ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    timer1.Stop();
                    TxtH_Fin.Text = DateTime.Now.ToString("HH:mm:ss"); ;
                }

                if(TxtP_Conforme.Text== "Piéces Conformes" )
                {
                    TxtP_Conforme.Text ="0";
                   

                }
                if(TxtP_N_Conformes.Text == "Piéces Non Conformes")
                {
                    TxtP_N_Conformes.Text = "0";
                }
            }

               
            catch (Exception ex)
            {
                MessageBox.Show("Entrer la *Date d'aujourd'hui* d'abord et cliquer sur le button *Ouverture* aprés button *Suivant*  ", "Lire le Guide ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timer2.Stop();
                timer1.Stop();
            }

        }

        private void comboBoxPosteSuivant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Supprimer_Click(object sender, EventArgs e)
        {
            TxtNomAtelier.Text = "Nom Atelier";
            TxtDate.Text = "Date";
            TxtStockEc_Nominale.Text = "Stock en Cours*";
            TxtP_N_Conformes.Text = "Piéces Non Conformes";
            TxtP_Conforme.Text = "Piéces Conformes";
            TxtH_Debut.Text = "Heure Début";
            TxtEffectif.Text = "Effectif";
            TxtH_Fin.Text = "Heure de Fin ";
            TxtStock_EC.Text = "Stock en Cours";
            TxtTKT_Time.Text = "Takt time";
            comboBoxPosteSuivant.Text = "Poste Suivant";
            TxtTimer.Text = "0";
            timer2.Stop();
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)

        {
            if (TxtDate.Text== "Date")
            {
                MessageBox.Show("Entrer la *Date d'aujourd'hui* d'abord et cliquer sur le button *Ouverture* aprés button *Suivant*  ", "Lire le Guide ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                TxtTimer.Text = (value++).ToString();
            }
        }

        private void Btn_Sauvegarder_Click(object sender, EventArgs e)
        {
            try
            {

                BL.CDB db = new BL.CDB();
                MySqlCommand command = new MySqlCommand("INSERT INTO `saisie_poste`( `Nom_Atelier`, `Date`, `Piece_C`, `Piece_NC`, `Effectif`, `TKT`, `H_debut`, `H_fin`, `time`) VALUES (@nm, @dt, @pc, @pnc, @ef, @tkt, @hd, @hf, @t)", db.getConnection());

                // fill table saisie_poste 
                command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = TxtNomAtelier.Text;
                command.Parameters.Add("@dt", MySqlDbType.VarChar).Value = TxtDate.Text;
                command.Parameters.Add("@pc", MySqlDbType.Int32).Value = TxtP_Conforme.Text;
                command.Parameters.Add("@pnc", MySqlDbType.Int32).Value = TxtP_N_Conformes.Text;
                command.Parameters.Add("@tkt", MySqlDbType.Int32).Value = TxtTKT_Time.Text;
                command.Parameters.Add("@hd", MySqlDbType.VarChar).Value = TxtH_Debut.Text;
                command.Parameters.Add("@hf", MySqlDbType.VarChar).Value = TxtH_Fin.Text;
                command.Parameters.Add("@t", MySqlDbType.Int32).Value = TxtTimer.Text;
                command.Parameters.Add("@ef", MySqlDbType.Int32).Value = TxtEffectif.Text;


                //open the onnection       

                db.openConnection();

                //execute Query
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Fin de Journeé  MERCI ");
                }
                else
                {
                    MessageBox.Show("Données fin journeé NON enregistrées");
                }

                //close the connection
                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Entrer la *Date d'aujourd'hui* d'abord et cliquer sur le button *Ouverture* aprés button *Suivant* apres button*fermeture* et assurer que tous les champs sont remplis  ", "Lire le Guide ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (TxtDate.Text == "Date")
            {
                MessageBox.Show("Entrer la *Date d'aujourd'hui* d'abord et cliquer sur le button *Ouverture* aprés button *Suivant*  ", "Lire le Guide ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                button1.PerformClick();

            }
        }

        private void TxtStock_EC_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxPNC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPNC.Checked)
            {
                checkBoxPC.Checked = false;
            }
            


            comboBox1.Visible = true;
            comboBoxPosteSuivant.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }
    }
}
