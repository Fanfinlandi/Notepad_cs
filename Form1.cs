using System.Data;
using System.Drawing.Printing;
using System.Timers;
using System.Windows.Forms;



namespace Notatnik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //ELO

        }

        private string sciezkaPliku;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
        


        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            string tekstDoWydruku = textBox1.Text;


            Font czcionka = new Font("Arial", 12);
            Brush pêdzel = Brushes.Black;
            e.Graphics.DrawString(tekstDoWydruku, czcionka, pêdzel, 10, 10);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }



        private void druk()
        {
            using (PrintDialog printDialog = new PrintDialog())
            {
                printDialog.Document = printDocument1;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {

                    printDocument1.Print();
                }
            }
        }


        private void WyswietlZawartoscPliku()
        {
            if (!string.IsNullOrEmpty(sciezkaPliku))
            {
                try
                {
                    string zawartoscPliku = File.ReadAllText(sciezkaPliku);
                    textBox1.Text = zawartoscPliku;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"B³¹d podczas wczytywania pliku: {ex.Message}", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {






        }

        private void button2_Click(object sender, EventArgs e)
        {

           




        }

        private void button4_Click(object sender, EventArgs e)
        {

            using (FontDialog fontDialog = new FontDialog())
            {
                fontDialog.Font = textBox1.Font;


                using (ColorDialog colorDialog = new ColorDialog())
                {
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {

                        textBox1.ForeColor = colorDialog.Color;
                    }
                }


            }




        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Left;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Right;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string tekst = textBox1.Text;
            string podkreslonyTekst = $"_{tekst}_";
            textBox1.Text = podkreslonyTekst;
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);

        }
        private void wybcz(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                fontDialog.Font = textBox1.Font;

                if (fontDialog.ShowDialog() == DialogResult.OK)
                {

                    textBox1.Font = fontDialog.Font;
                }


            }
        }
        private void savefile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            saveFileDialog.Title = "Zapisz plik";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        string dane = textBox1.Text;
                        sw.Write(dane);



                    }

                    MessageBox.Show("Plik zosta³ zapisany pomyœlnie.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wyst¹pi³ b³¹d podczas zapisywania pliku: {ex.Message}", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }
        private void openfile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                sciezkaPliku = openFileDialog.FileName;
                WyswietlZawartoscPliku();
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = comboBox1.SelectedItem.ToString();

            
            if (selectedOption == "Save")
            {
                savefile();
                
            }
            if(selectedOption=="Open")
            {



                openfile();
            }
            if (selectedOption == "Print")
            {
                druk();
            }
               
            
            
               
               
            



        }
    }
}