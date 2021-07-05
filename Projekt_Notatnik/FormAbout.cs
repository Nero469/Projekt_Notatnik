using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Notatnik
{
    
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Funkcja wyjścia z aplikacji po kliknięciu przycisku "Wyjdz "
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
