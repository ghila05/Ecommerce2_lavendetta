namespace Ecommerce2_lavendetta
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.butnSvuota = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.butnProddefault = new System.Windows.Forms.Button();
            this.butnInserisci = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPrezzo = new System.Windows.Forms.TextBox();
            this.TxtDescri = new System.Windows.Forms.TextBox();
            this.TxtProduttore = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIngredienti = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtModello = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Txtgrammatura = new System.Windows.Forms.TextBox();
            this.TxtFunzionamento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butnSvuota
            // 
            this.butnSvuota.Location = new System.Drawing.Point(596, 508);
            this.butnSvuota.Name = "butnSvuota";
            this.butnSvuota.Size = new System.Drawing.Size(203, 54);
            this.butnSvuota.TabIndex = 29;
            this.butnSvuota.Text = "SVUOTA";
            this.butnSvuota.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(805, 508);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 54);
            this.button3.TabIndex = 28;
            this.button3.Text = "ELIMINA [SELEZIONANARE]";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(472, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(536, 411);
            this.listView1.TabIndex = 27;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // butnProddefault
            // 
            this.butnProddefault.Location = new System.Drawing.Point(9, 523);
            this.butnProddefault.Name = "butnProddefault";
            this.butnProddefault.Size = new System.Drawing.Size(203, 54);
            this.butnProddefault.TabIndex = 26;
            this.butnProddefault.Text = "INSERIMENTO RAPIDO [PRODOTTI DEFAULT]";
            this.butnProddefault.UseVisualStyleBackColor = true;
            // 
            // butnInserisci
            // 
            this.butnInserisci.Location = new System.Drawing.Point(9, 450);
            this.butnInserisci.Name = "butnInserisci";
            this.butnInserisci.Size = new System.Drawing.Size(138, 54);
            this.butnInserisci.TabIndex = 25;
            this.butnInserisci.Text = "INSERISCI";
            this.butnInserisci.UseVisualStyleBackColor = true;
            this.butnInserisci.Click += new System.EventHandler(this.butnInserisci_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "PREZZO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "DESCRIZIONE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "PRODUTTORE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "NOME:";
            // 
            // TxtPrezzo
            // 
            this.TxtPrezzo.Location = new System.Drawing.Point(12, 244);
            this.TxtPrezzo.Name = "TxtPrezzo";
            this.TxtPrezzo.Size = new System.Drawing.Size(80, 20);
            this.TxtPrezzo.TabIndex = 19;
            // 
            // TxtDescri
            // 
            this.TxtDescri.Location = new System.Drawing.Point(135, 156);
            this.TxtDescri.Name = "TxtDescri";
            this.TxtDescri.Size = new System.Drawing.Size(80, 20);
            this.TxtDescri.TabIndex = 18;
            // 
            // TxtProduttore
            // 
            this.TxtProduttore.Location = new System.Drawing.Point(12, 156);
            this.TxtProduttore.Name = "TxtProduttore";
            this.TxtProduttore.Size = new System.Drawing.Size(80, 20);
            this.TxtProduttore.TabIndex = 17;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(135, 73);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(80, 20);
            this.TxtNome.TabIndex = 16;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(15, 73);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(80, 20);
            this.TxtID.TabIndex = 15;
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(134, 244);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(192, 20);
            this.dateTime.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "DATA:";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "ALIMENTARE",
            "FOGLI",
            "PENNE",
            "ELETTRONICA"});
            this.comboBox.Location = new System.Drawing.Point(250, 73);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "TIPO:";
            // 
            // txtIngredienti
            // 
            this.txtIngredienti.Location = new System.Drawing.Point(250, 156);
            this.txtIngredienti.Multiline = true;
            this.txtIngredienti.Name = "txtIngredienti";
            this.txtIngredienti.Size = new System.Drawing.Size(162, 45);
            this.txtIngredienti.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "INGREDIENTI:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "MODELLO:";
            // 
            // TxtModello
            // 
            this.TxtModello.Location = new System.Drawing.Point(15, 323);
            this.TxtModello.Name = "TxtModello";
            this.TxtModello.Size = new System.Drawing.Size(80, 20);
            this.TxtModello.TabIndex = 36;
            this.TxtModello.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(132, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "GRAMMATURA:";
            // 
            // Txtgrammatura
            // 
            this.Txtgrammatura.Location = new System.Drawing.Point(132, 323);
            this.Txtgrammatura.Name = "Txtgrammatura";
            this.Txtgrammatura.Size = new System.Drawing.Size(80, 20);
            this.Txtgrammatura.TabIndex = 38;
            // 
            // TxtFunzionamento
            // 
            this.TxtFunzionamento.Location = new System.Drawing.Point(264, 323);
            this.TxtFunzionamento.Name = "TxtFunzionamento";
            this.TxtFunzionamento.Size = new System.Drawing.Size(75, 20);
            this.TxtFunzionamento.TabIndex = 40;
            this.TxtFunzionamento.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(259, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "FUNZIONAMENTO:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 577);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtFunzionamento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Txtgrammatura);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtModello);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIngredienti);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.butnSvuota);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.butnProddefault);
            this.Controls.Add(this.butnInserisci);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPrezzo);
            this.Controls.Add(this.TxtDescri);
            this.Controls.Add(this.TxtProduttore);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.TxtID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butnSvuota;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button butnProddefault;
        private System.Windows.Forms.Button butnInserisci;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPrezzo;
        private System.Windows.Forms.TextBox TxtDescri;
        private System.Windows.Forms.TextBox TxtProduttore;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIngredienti;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtModello;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txtgrammatura;
        private System.Windows.Forms.TextBox TxtFunzionamento;
        private System.Windows.Forms.Label label11;
    }
}

