using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_11_22_Predavanje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void btnCalculateSqrt_Click(object sender, EventArgs e)
        {
            ApplicationException applicationException = new ApplicationException();
            double broj;
            double korijen;
            lblShowReturn1.Text = "";
            try
            {   
                broj = Convert.ToDouble(txtNumberInput.Text);
                if (broj < 0)
                    throw (new ApplicationException("Greška: Broj ne smije biti negativan! \nKorijen iznosi: 0 \n"));
                lblShowReturn1.Text += $"{korijen = Math.Sqrt(broj)} \n";
            }
            catch (FormatException)
            {
                lblShowReturn1.Text += "Unesite broj! \nKorijen iznosi: 0 \n";
            }
            catch (ApplicationException exception)
            {
                 lblShowReturn1.Text += exception.Message;
            }
            
        }
//KNJIGE ZADATAK

        Knjiga[] knjige = new Knjiga[5];
        int counter = 0;

        private void btnInputSave_Click(object sender, EventArgs e)
        {
            try
            {
                knjige[counter] = new Knjiga(txtTitle.Text, txtAuthor.Text, Convert.ToInt32(txtPages.Text), Convert.ToDouble(txtPrice.Text));
            }
            catch (KnjigaException iznimka)
            {
                MessageBox.Show(iznimka.Poruka);
                knjige[counter] = new Knjiga(txtTitle.Text, txtAuthor.Text, 100, 50);
            }

            counter++;
            txtTitle.Clear();
            txtTitle.Focus();
            txtAuthor.Clear();
            txtPages.Clear();
            txtPrice.Clear();

            if(counter == knjige.Length)
            {
                Ispis(knjige);
                txtTitle.Enabled = false;
                txtAuthor.Enabled = false;
                txtPages.Enabled = false;
                txtPrice.Enabled = false;
            }
        }
        void Ispis(params Knjiga[] knjige)
        {
            for (int i = 0; i < knjige.Length; i++)
                lblShowReturn2.Text += $"Knjiga {knjige[i].Naslov} - {knjige[i].Autor} cijena {knjige[i].Cijena:C} - {knjige[i].BrojStranica} stranica \n";
        }
    }
    
}
