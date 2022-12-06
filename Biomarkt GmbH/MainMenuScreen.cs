﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biomarkt_GmbH
{
    public partial class MainMenuScreen : Form
    {
        public MainMenuScreen()
        {
            InitializeComponent();
        }

        private void btnProdukt_Click(object sender, EventArgs e)
        {
            ProduktScreen produktScreen = new ProduktScreen();
            produktScreen.Show();

            this.Hide();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            RechnungsErstellen rechnungsErstellen = new RechnungsErstellen();
            rechnungsErstellen.Show();
            this.Hide();
        }
    }
}
