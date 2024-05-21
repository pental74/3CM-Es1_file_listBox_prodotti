
namespace _3CM_Es1_file_listBox_prodotti
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMediaPrezzi = new System.Windows.Forms.Label();
            this.numericUpDownPrezzo = new System.Windows.Forms.NumericUpDown();
            this.textBoxDescrizioneProdotto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonInserisci = new System.Windows.Forms.Button();
            this.listBoxVisualizzazioneProdotti = new System.Windows.Forms.ListBox();
            this.buttonModifica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrezzo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMediaPrezzi
            // 
            this.labelMediaPrezzi.AutoSize = true;
            this.labelMediaPrezzi.Location = new System.Drawing.Point(519, 80);
            this.labelMediaPrezzi.Name = "labelMediaPrezzi";
            this.labelMediaPrezzi.Size = new System.Drawing.Size(79, 15);
            this.labelMediaPrezzi.TabIndex = 0;
            this.labelMediaPrezzi.Text = "Media prezzi: ";
            // 
            // numericUpDownPrezzo
            // 
            this.numericUpDownPrezzo.DecimalPlaces = 2;
            this.numericUpDownPrezzo.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownPrezzo.Location = new System.Drawing.Point(43, 129);
            this.numericUpDownPrezzo.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPrezzo.Name = "numericUpDownPrezzo";
            this.numericUpDownPrezzo.Size = new System.Drawing.Size(100, 23);
            this.numericUpDownPrezzo.TabIndex = 1;
            this.numericUpDownPrezzo.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDownPrezzo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // textBoxDescrizioneProdotto
            // 
            this.textBoxDescrizioneProdotto.Location = new System.Drawing.Point(43, 80);
            this.textBoxDescrizioneProdotto.Name = "textBoxDescrizioneProdotto";
            this.textBoxDescrizioneProdotto.Size = new System.Drawing.Size(100, 23);
            this.textBoxDescrizioneProdotto.TabIndex = 3;
            this.textBoxDescrizioneProdotto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Descrizione";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prezzo";
            // 
            // buttonInserisci
            // 
            this.buttonInserisci.Location = new System.Drawing.Point(177, 103);
            this.buttonInserisci.Name = "buttonInserisci";
            this.buttonInserisci.Size = new System.Drawing.Size(75, 23);
            this.buttonInserisci.TabIndex = 6;
            this.buttonInserisci.Text = "Inserisci";
            this.buttonInserisci.UseVisualStyleBackColor = true;
            this.buttonInserisci.Click += new System.EventHandler(this.buttonInserisci_Click);
            // 
            // listBoxVisualizzazioneProdotti
            // 
            this.listBoxVisualizzazioneProdotti.FormattingEnabled = true;
            this.listBoxVisualizzazioneProdotti.ItemHeight = 15;
            this.listBoxVisualizzazioneProdotti.Location = new System.Drawing.Point(310, 80);
            this.listBoxVisualizzazioneProdotti.Name = "listBoxVisualizzazioneProdotti";
            this.listBoxVisualizzazioneProdotti.Size = new System.Drawing.Size(188, 274);
            this.listBoxVisualizzazioneProdotti.TabIndex = 7;
            this.listBoxVisualizzazioneProdotti.SelectedIndexChanged += new System.EventHandler(this.listBoxVisualizzazioneProdotti_SelectedIndexChanged);
            // 
            // buttonModifica
            // 
            this.buttonModifica.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.buttonModifica.Location = new System.Drawing.Point(52, 171);
            this.buttonModifica.Name = "buttonModifica";
            this.buttonModifica.Size = new System.Drawing.Size(75, 23);
            this.buttonModifica.TabIndex = 8;
            this.buttonModifica.Text = "Modifica";
            this.buttonModifica.UseVisualStyleBackColor = true;
            this.buttonModifica.Visible = false;
            this.buttonModifica.Click += new System.EventHandler(this.buttonModifica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonModifica);
            this.Controls.Add(this.listBoxVisualizzazioneProdotti);
            this.Controls.Add(this.buttonInserisci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDescrizioneProdotto);
            this.Controls.Add(this.numericUpDownPrezzo);
            this.Controls.Add(this.labelMediaPrezzi);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrezzo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMediaPrezzi;
        private System.Windows.Forms.NumericUpDown numericUpDownPrezzo;
        private System.Windows.Forms.TextBox textBoxDescrizioneProdotto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonInserisci;
        private System.Windows.Forms.ListBox listBoxVisualizzazioneProdotti;
        private System.Windows.Forms.Button buttonModifica;
    }
}

