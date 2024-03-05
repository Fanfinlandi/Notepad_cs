using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;


namespace Notatnik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private string sciezkaPliku;
        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void exit(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Pobierz tekst z TextBox
            string tekstDoWydruku = textBox1.Text;

            // Ustawienia do rysowania tekstu
            Font czcionka = new Font("Arial", 12);
            Brush pêdzel = Brushes.Black;

            // Rysuj tekst z TextBox na stronie
            e.Graphics.DrawString(tekstDoWydruku, czcionka, pêdzel, 10, 10);
        }
        private void button1_Click(object sender, EventArgs e)
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



        private void druk(object sender, EventArgs e)
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

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                sciezkaPliku = openFileDialog.FileName;
                WyswietlZawartoscPliku();
            }





        }

        private void button4_Click(object sender, EventArgs e)
        {

            colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();



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


    }
}