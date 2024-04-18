using System.Data;
using System.Drawing.Printing;
using System.Reflection.Emit;
using System.Timers;
using System.Windows.Forms;



namespace Notatnik
    //NOTATNIK  
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            


            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Start();
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

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Right;
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
        private void wybcz()
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

        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = DateTime.Now.ToString();


        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {






        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {


            textBox1.TextAlign = HorizontalAlignment.Center;


        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            savefile();

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openfile();

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            druk();

        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wybcz();
        }

        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString();
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Left;

        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Right;

        }

        private void zg³oœProblemToolStripMenuItem_Click(object sender, EventArgs e)
        {







        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}

