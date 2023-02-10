using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce2_lavendetta
{
    public partial class Form1 : Form
    {

        string id;
        string nome;
        string produttore;
        string descrizione;
        string prezzo;
        Prodotto p;
        Carrello c = new Carrello("1234");
        DateTime data;
        string ingredienti;
        string modello;
        string grammatura;
        string funzionamento;
        bool first = true;




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (first)//solo la prima volta che apro il programma
            {
                listView1.View = View.Details;
                listView1.FullRowSelect = true;
                first = false;

                listView1.Columns.Add("ID", 60);
                listView1.Columns.Add("NOME", 80);
                listView1.Columns.Add("PRODUTTORE", 100);
                listView1.Columns.Add("DESCRIZIONE", 200);
                listView1.Columns.Add("PREZZO", 100);

            }

        }

        public void Controlla()
        {
            if (TxtID.Text == "")
            {
                throw new Exception("Completa il campo ID");
            }
            if (TxtNome.Text == "")
            {
                throw new Exception("Completa il campo NOME");
            }
            if (TxtProduttore.Text == "")
            {
                throw new Exception("Completa il campo PRODUTTORE");
            }
            if (TxtDescri.Text == "")
            {
                throw new Exception("Completa il campo DESCRIZIONE");
            }
            if (TxtPrezzo.Text == "")
            {
                throw new Exception("Completa il campo PREZZO");
            }
            if (comboBox.Text == "")
            {
                throw new Exception("Completa il campo TIPO");
            }
            if (comboBox.Text == "ALIMENTARE")
            {
                if(dateTime.Value == null)
                {
                    throw new Exception("Completa il campo DATA");
                }
            }



        }


        private void butnInserisci_Click(object sender, EventArgs e)
        {
            id = TxtID.Text;
            nome = TxtNome.Text;
            produttore = TxtProduttore.Text;
            descrizione = TxtDescri.Text;
            prezzo = TxtPrezzo.Text;
            ingredienti = txtIngredienti.Text;
            string[] ingre = ingredienti.Split(';');
            modello = TxtModello.Text;
            grammatura = Txtgrammatura.Text;
            funzionamento = TxtFunzionamento.Text;

            if (comboBox.Text == "ALIMENTARE")
            {
                data = dateTime.Value; 
                
            }

            Controlla();


            if(comboBox.Text == "ALIMENTARE")
            {
                p = new Alimentare(ingre, data, id, nome, produttore, descrizione, float.Parse(prezzo)); 
            }

            if(comboBox.Text == "ELETTRONICA")
            {
                p = new Elettronica(id, nome, produttore, descrizione, float.Parse(prezzo), modello);
            }

            if(comboBox.Text == "FOGLI")
            {
                p = new Fogli(float.Parse(grammatura), id, nome, produttore, descrizione, float.Parse(prezzo));
            }

            if (comboBox.Text == "PENNE")
            {
                p = new Penne(funzionamento,id,nome,produttore,descrizione,float.Parse(prezzo));
            }


            c.Aggiungi(p);
            float b = p.getPrezzo();
            string prezzos = Convert.ToString(b);

            label_PREZZO.Text = "PREZZO SCONTATO: "+prezzos;

            StampaElementi(listView1, c);

        }


        public static void StampaElementi(ListView listino, Carrello carr)
        {
            listino.Items.Clear();
            Prodotto[] prod = carr.Prodotti;
 

            for (int i = 0; i < prod.Length; i++)
            {

                string[] temp = new string[] { prod[i].Id, prod[i].Nome, prod[i].Produttore, prod[i].Descrizione, $"{prod[i].Prezzo}" };
                ListViewItem item = new ListViewItem(temp);
                listino.Items.Add(item);
                i++;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id;
            id = listView1.SelectedItems[0].SubItems[0].Text;
            MessageBox.Show(id);
            c.Eliminadaid(id);
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }

        }
        public Prodotto CreaProdTemp(string id, string nome, string prod, string descr, float prezz)
        {
            Prodotto p = new Prodotto(id, nome, prod, descr, prezz);
            return p;
        }

        private void butnProddefault_Click(object sender, EventArgs e)
        {
            p = new Elettronica("123", "iphone", "apple", "iphone14 pro max", 1200, "hcpvlsm");
            c.Aggiungi(p);
            StampaElementi(listView1, c);
        }
    }
}
