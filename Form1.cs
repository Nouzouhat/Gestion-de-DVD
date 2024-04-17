using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Gestion_de_dvd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //remplissage de lstDVD//
            ConnexionSql connexion = new ConnexionSql("server=localhost;database=gestiondvd;uid=root;pwd=\"\"");
            connexion.reqSelect("select TITRE from dvd"); 
            while (!connexion.fin()) 
            {
                this.lstDvd.Items.Add(connexion.champ("TITRE").ToString());
                connexion.suivant();

                
            }
            connexion.fin();
            connexion.close();

            //remplissage de cboGenre//

            ConnexionSql lst_genre = new ConnexionSql("server=localhost;database=gestiondvd;uid=root;pwd=\"\"");
            lst_genre.reqSelect("select LIBELLE from genre");
            while (lst_genre.fin() == false)
            {
                this.cboGenre.Items.Add(lst_genre.champ("LIBELLE").ToString());
                lst_genre.suivant();
            }
            lst_genre.fin();
            lst_genre.close();

            //remplissage de CboActeur

            ConnexionSql lst_acteur = new ConnexionSql("server=localhost;database=gestiondvd;uid=root;pwd=\"\"");
            lst_acteur.reqSelect("select NOM from acteur");
            while (lst_acteur.fin() == false)
            {
                this.cboActeur.Items.Add(lst_acteur.champ("NOM").ToString() );
                lst_acteur.suivant();
            }
            lst_acteur.fin();
            lst_acteur.close();

            // Selection dvd dans lstDvd

            if(lstDvd.Items.Count != 0)
            {
                lstDvd.SelectedIndex = 0;
            }
            



             
        }
        


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstDvd_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dvd = lstDvd.SelectedItem.ToString();

            //Afficher un dvd sur txtTitre

            ConnexionSql numdvd = new ConnexionSql("server=localhost;database=gestiondvd;uid=root;pwd=\"\"");
            numdvd.reqSelect("select NUMDVD from dvd where TITRE='"+dvd+"'");
        }

        private void btnAjoutDvd_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprDvd_Click(object sender, EventArgs e)
        {

        }

        private void btnModifDvd_Click(object sender, EventArgs e)
        {

        }

        private void txtTitre_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnAjoutActeur_Click(object sender, EventArgs e)
        {

        }
    }
    class ConnexionSql
    {
        // propriétés
        private bool finCurseur = true; // fin du curseur atteinte
        private MySqlConnection connection; // chaine de connexion
        private MySqlCommand command; // envoi de la requête à la base de données
        private MySqlDataReader reader; // gestion du curseur

        // constructeur 
        public ConnexionSql(string chaineConnection) 
        {
            this.connection = new MySqlConnection(chaineConnection);
            this.connection.Open(); 
        }

        // execution d'une requete select
        public void reqSelect(string chaineRequete) 
        {
            this.command = new MySqlCommand(chaineRequete, this.connection);
            this.reader = this.command.ExecuteReader();
            this.finCurseur = false;
            this.suivant();
        }

        // execution d'une requete update
        public void reqUpdate(string chaineRequete)
        {
            this.command = new MySqlCommand(chaineRequete, this.connection);
            this.command.ExecuteNonQuery();
            this.finCurseur = true;
        }

        // récupération d'un champ
        public Object champ(string nomChamp)
        {
            return this.reader[nomChamp];
        }

        // passage à la ligne suivante du curseur
        public void suivant()
        {
            if (!this.finCurseur)
            {
                this.finCurseur = !this.reader.Read();
            }
        }

        // test de la fin du curseur
        public Boolean fin()
        {
            return this.finCurseur;
        }

        // fermeture de la connexion
        public void close()
        {
            this.connection.Close();
        }
      
    }
  
}
