using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Projekt_Notatnik
{
    public partial class Form1 : Form
    {
        //string sciezka;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
        private FontDialog czcionkaDialog;


        public Form1()
        {
            InitializeComponent();
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nowyplik();
            //sciezka = string.Empty;
            //richTextBox1.Clear();
        }

        private void Nowyplik()
        {
            try
            {
                if (!string.IsNullOrEmpty(this.richTextBox1.Text))
                {
                    MessageBox.Show("Najpierw zapisz plik !");
                }
                else
                {
                    this.richTextBox1.Text = string.Empty;
                    this.Text = "Brak nazwy";
                }
            }
            catch
            {

            }
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtworzPlik();
        }

        private void OtworzPlik()
        {
            try
            {
                openFileDialog = new OpenFileDialog();

                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
                    this.Text = openFileDialog.FileName;
                }
            }
            catch
            {
                MessageBox.Show("Błąd podczas próby otwarcia pliku !");
            }
            finally
            {
                openFileDialog = null; 
            }
        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZapiszPlik();

        }

        private void ZapiszPlik()
        {
            try
            {
                if(!string.IsNullOrEmpty(this.richTextBox1.Text))
                {
                    saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Text File (*.txt)| *.txt";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, this.richTextBox1.Text);
                        this.Text = saveFileDialog.FileName;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Plik jest pusty");
                }
            }
            catch
            {

            }
            finally
            {

            }
        }

        private void zapiszJakoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ZapiszJako();
        }

        private void ZapiszJako()
        {
            try
            {
                if (!string.IsNullOrEmpty(this.richTextBox1.Text))
                {
                    saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Text File (*.txt)| *.txt! All Files (*.*)| *.*";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, this.richTextBox1.Text);
                        this.Text = saveFileDialog.FileName;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Plik jest pusty");
                }
            }
            catch
            {

            }
            finally
            {

            }
        }

        private void wyjdźToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(!string.IsNullOrEmpty(this.richTextBox1.Text))
                {
                    ZapiszPlik();
                }
                else
                {
                    this.Close();
                }
            }
            catch
            {

            }
            finally
            {

            }
        }

        private void czcionkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            czcionkaDialog = new FontDialog();
            if(czcionkaDialog.ShowDialog()==DialogResult.OK)
            {
                this.richTextBox1.Font = czcionkaDialog.Font;
            }
        }

        private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout win = new FormAbout();
            win.Show();
            //FormAbout.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kolorCzcionkiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /*
        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

            if (toolStripComboBox1.SelectedItem == "Zielony")
            {
                richTextBox1.ForeColor = Color.Green;
            }
            if (toolStripComboBox1.SelectedItem == "Czerwony")
            {
                richTextBox1.ForeColor = Color.Red;
            }
            if (toolStripComboBox1.SelectedItem == "Jasnozielony")
            {
                richTextBox1.ForeColor = Color.Cyan;
            }
            if (toolStripComboBox1.SelectedItem == "Szary")
            {
                richTextBox1.ForeColor = Color.Gray;
            }
            if (toolStripComboBox1.SelectedItem == "Pomarańczowy")
            {
                richTextBox1.ForeColor = Color.Orange;
            }
            if (toolStripComboBox1.SelectedItem == "Czarny")
            {
                richTextBox1.ForeColor = Color.Black;
            }
        }
        */

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Zielony")
            {
                richTextBox1.ForeColor = Color.Green;
            }
            if (comboBox1.SelectedItem == "Czerwony")
            {
                richTextBox1.ForeColor = Color.Red;
            }
            if (comboBox1.SelectedItem == "Jasnozielony")
            {
                richTextBox1.ForeColor = Color.Cyan;
            }
            if (comboBox1.SelectedItem == "Szary")
            {
                richTextBox1.ForeColor = Color.Gray;
            }
            if (comboBox1.SelectedItem == "Pomarańczowy")
            {
                richTextBox1.ForeColor = Color.Orange;
            }
            if (comboBox1.SelectedItem == "Czarny")
            {
                richTextBox1.ForeColor = Color.Black;
            }
        }
    }
}

/*
            using (OpenFileDialog onp = new OpenFileDialog() { Filter = "Dokument Tekstowy|*.txt", ValidateNames = true, Multiselect = false })
            {
                if(onp.ShowDialog()==DialogResult.OK)
                {
                    using (StreamReader sd = new StreamReader(onp.FileName))
                    {
                        sciezka = onp.FileName;
                        Task<string> tekst = sd.ReadToEndAsync();
                        richTextBox1.Text = tekst.Result;



                    }
                }
            }
*/
