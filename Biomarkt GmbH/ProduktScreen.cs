using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biomarkt_GmbH
{
    public partial class ProduktScreen : Form
    {
        DBBio db = new DBBio();
        Produkte TB1 = new Produkte();
        public ProduktScreen()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            produkteDGV.DataSource = db.Produktes.ToList();
            db.SaveChanges();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(produkteDGV.CurrentRow.Cells[0].Value);
            TB1 = db.Produktes.Where(i => i.Id == id).FirstOrDefault();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            textBoxProduktName.Text = TB1.Name;
            textBoxProduktMarke.Text = TB1.Marke;
            comboBoxKategorie.Text = TB1.Kategorie;
            textBoxProduktPreis.Text = TB1.Preis;

        }


        private void btnProduktSpeicher_Click(object sender, EventArgs e)
        {
            if (textBoxProduktName.Text == ""
                || textBoxProduktMarke.Text == ""
                || textBoxProduktPreis.Text == ""
                || comboBoxKategorie.Text == "")

            {
                MessageBox.Show("Bitte fülle die Werte aus ");
                return;
            }
            TB1.Name = textBoxProduktName.Text;
            TB1.Marke = textBoxProduktMarke.Text;
            TB1.Kategorie = comboBoxKategorie.Text;
            TB1.Preis = textBoxProduktPreis.Text;
            db.Produktes.Add(TB1);
            db.SaveChanges();
            MessageBox.Show("Erfolgreich eingefügt");

        }

        private void btnProduktBearbeiter_Click(object sender, EventArgs e)
        {
            TB1.Name = textBoxProduktName.Text;
            TB1.Marke = textBoxProduktMarke.Text;
            TB1.Kategorie = comboBoxKategorie.Text;
            TB1.Preis = textBoxProduktPreis.Text;
            db.Entry(TB1).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            MessageBox.Show("Erfolgreich geändert");

        }

        private void btnProduktFilderLeeren_Click(object sender, EventArgs e)
        {
            textBoxProduktName.Text = "";
            textBoxProduktMarke.Text = "";
            textBoxProduktPreis.Text = "";
            comboBoxKategorie.Text = "";
            comboBoxKategorie.SelectedItem = null;

        }

        private void btnLöschen_Click(object sender, EventArgs e)
        {
            db.Entry(TB1).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            MessageBox.Show("Erfolgreichgelöcht");
        }

    }
}
