using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationBigData;

namespace ApplicationBigData
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ajoutAuteur_Click(object sender, EventArgs e)
        {
            var nom=txtName.Text;
            var prenom = txtPrenom.Text;
            var domicile = txtDomicile.Text;
            var numero = (txtNum.Text);
            int num=int.Parse(numero);

            // insert into table(auteurs) collection
            MongoCrud db = new MongoCrud("GestionBibliotheque");
            db.Insert("auteurs", new Auteur { nom = nom, prenom =prenom, domicile =domicile, numero =num});
            MessageBox.Show("Auteur ajouté avec sucées !");
        }

        private void ajoutLivre_Click(object sender, EventArgs e)
        {
            var titre=txtTitre.Text;
            var prix = txtPrix.Text;
            double prixDouble = Convert.ToDouble(prix);
            var numero = txtNumLivre.Text;
           int num = int.Parse(numero);

            // insert into table(livres) collection
            MongoCrud db = new MongoCrud("GestionBibliotheque");
            db.Insert("livres", new Livre { titre =titre, prix =prixDouble, numero =num});
            MessageBox.Show("Livre ajouté avec sucées !");
        }

        private void ajoutRelation_Click(object sender, EventArgs e)
        {
            var titre = txtTitreR.Text;
            var nom = txtAuteur.Text;

            // insert into table (relation)
            MongoCrud db = new MongoCrud("GestionBibliotheque");
            db.Insert("Relation", new Relation { titre = titre, nom = nom });
            MessageBox.Show("Relation ajoutée avec sucées !");
        }

        private void listeLivres_Click(object sender, EventArgs e)
        {
            MongoCrud db = new MongoCrud("GestionBibliotheque");
            var listeLivres = db.Affiche<Livre>("livres");

            foreach (var listliv in listeLivres)
            {
                string[] row = { listliv.titre,listliv.prix.ToString(), listliv.numero.ToString() };
                var ListItem = new ListViewItem(row);
                listView1.Items.Add(ListItem);
            }
        }

        private void listeAuteurs_Click(object sender, EventArgs e)
        {
            MongoCrud db = new MongoCrud("GestionBibliotheque");
            var listeAuteurs = db.Affiche<Auteur>("auteurs");

            foreach (var listAut in listeAuteurs)
            {
                string[] row = { listAut.nom, listAut.prenom, listAut.domicile,listAut.numero.ToString() };
                var ListItem = new ListViewItem(row);
                listView1.Items.Add(ListItem);
            }
        }
    }
}
