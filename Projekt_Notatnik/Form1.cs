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
        /// <summary>
        /// Utworzenie własnych obiektów
        /// </summary>
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
        private FontDialog czcionkaDialog;

        /// <summary>
        /// Konstruktor programu, metoda wymagana do obsługi projektanta
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            Nowyplik();
        }
        /// <summary>
        /// Wywołanie obiektu ToolStripMenuItem oraz funckji utworzenia nowego pliku
        /// </summary>
        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nowyplik();
            //sciezka = string.Empty;
            //richTextBox1.Clear();
        }
        /// <summary>
        /// Utworznie nowego pliku
        /// </summary>
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

        /// <summary>
        /// Funkcja otwarcia pliku i załadowania zawartości tekstowej do obiektu
        /// </summary>
        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.richTextBox1.Text=OtworzPlik();

        }
        /// <summary>
        /// Otwarcie i załadowanie istniejącego pliku tekstowego
        /// </summary>
        public string OtworzPlik()
        {
            try
            {
                openFileDialog = new OpenFileDialog();

                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.Text = openFileDialog.FileName;
                    return File.ReadAllText(openFileDialog.FileName);
                
                }
            }
            catch
            {
                MessageBox.Show("Błąd podczas próby otwarcia pliku !");

            }

                openFileDialog = null;
                return "Pusty string";

            
        }
        /// <summary>
        /// Wywołanie funkcji ZapiszPlik() po wcisnieciu danego działania
        /// </summary>
        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZapiszPlik();

        }
        /// <summary>
        /// Funkcja Zapisu stanu pliku
        /// </summary>
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

        /// <summary>
        /// Wywołanie funkcji zapisu pliku 
        /// </summary>
        private void zapiszJakoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ZapiszJako(this.richTextBox1.Text);
        }
        /// <summary>
        /// Funkcja zapisu pliku wraz z wywołaniem okna, gdzie wyznaczamy lokalizacje zapisywanego pliku
        /// </summary>
        public string ZapiszJako(string text)
        {

                if (!string.IsNullOrEmpty(text))
                {
                    saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, text);
                        this.Text = saveFileDialog.FileName;
                        return saveFileDialog.FileName; //zwrot sciezki
                        //this.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Plik jest pusty");
                }
            
            return null;
        }
        /// <summary>
        /// Funkcja sprawdzeniu zawartości pola tekstowego oraz po spełnieniu/niespełnieniu warunku następuje działanie
        /// </summary>
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

        /// <summary>
        /// Funkcja zmiany czcionki bo wybraniu nowej
        /// </summary>
        private void czcionkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            czcionkaDialog = new FontDialog();
            if(czcionkaDialog.ShowDialog()==DialogResult.OK)
            {
                this.richTextBox1.Font = czcionkaDialog.Font;
            }
        }
        /// <summary>
        /// Utworzenie obiektu rozwijalnego
        /// </summary>
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

        /// <summary>
        /// Funkcja wyboru koloru czcionki w postaci listy rozwijalnej 
        /// </summary>
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


/// <summary>
/// Co robi metoda
/// </summary>
/// <param name="parametr1">co to za parametr</param>
/// <param name="parametr2">co to za parametr</param>
/// <returns>co zwraca</returns>
/// 

/// <param name="sender"></param>
/// <param name="e"></param>
