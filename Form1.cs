using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 Realizzare un'app windows form che permetta di inserire, visualizzare e modificare dei prodotti (descrizione e prezzo). 
    - Calcolare la media dei prezzi dei prodotti e visualizzarla in un'apposita label.

 */
namespace _3CM_Es1_file_listBox_prodotti
{
    public struct Prodotto
    {
        public string descrizione;
        public float prezzo;
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public const string STRINGA_MEDIA = "Media: ";

        // Strutture dati per conservare i dati in locale
        public Prodotto [] array_prodotti = new Prodotto[25];
        public int indice = 0;

        // Evento Click Inserisci
        private void buttonInserisci_Click(object sender, EventArgs e)
        {
            Inserimento('i', indice);

            labelMediaPrezzi.Text = STRINGA_MEDIA + MediaPrezzi(array_prodotti, indice);
            indice++;
        }

        // Prende l'invio senza dovere premere il tasto
        // NON RICHIESTO DAL TESTO DELL'ESERCIZIO
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonInserisci.PerformClick();
            }
        }

        // Procedura che consente l'inserimento e la modifica degli elementi
        public void Inserimento(char tipo, int posizione) // 'm' - modifica 'i' inserimento
        {
            // Preleva i valori dal numeric e textbox ed inserisce nell'array e nella listbox
            Prodotto prodotto_da_inserire;
            prodotto_da_inserire.descrizione = textBoxDescrizioneProdotto.Text;
            prodotto_da_inserire.prezzo = Convert.ToSingle(numericUpDownPrezzo.Value);

            switch (tipo)
            {
                case 'i':   // inserisce nuovo prodotto nell'array e nella listbox
                    array_prodotti[posizione] = prodotto_da_inserire;
                    listBoxVisualizzazioneProdotti.Items.Add(prodotto_da_inserire.descrizione + " " + prodotto_da_inserire.prezzo.ToString());
                    break;
                case 'm':   // cambia la listbox e il valore dell'array
                    array_prodotti[posizione] = prodotto_da_inserire;
                    listBoxVisualizzazioneProdotti.Items[posizione]=prodotto_da_inserire.descrizione + " " + prodotto_da_inserire.prezzo.ToString();
                    listBoxVisualizzazioneProdotti.ClearSelected();
                    break;
            }
            PuliziaCampi();
        }

        public void PuliziaCampi()
        {
            textBoxDescrizioneProdotto.Text = "";
            numericUpDownPrezzo.Value = 150;
        }


        // Funzione che restituisce la media convertita in stringa (return media.ToString())
        string MediaPrezzi(Prodotto [] array, int totale)
        {
            float media=0;
            for (int i = 0; i < totale+1; i++) media += array[i].prezzo;
            media = media / (totale + 1); //tenere conto indice vettore parte da zero, quindi totale deve essere aumentato di 1 
            return media.ToString();
        }

        // Gestione dell'evento della selezione con il mouse di un elemento della listBox (già visto in laboratorio)
        private void listBoxVisualizzazioneProdotti_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelezionato = listBoxVisualizzazioneProdotti.SelectedIndex;
            if (indiceSelezionato != -1)     // evita che gestisca anche quando nessun elemento selezionato (SelectedIndex = -1)
            {
                textBoxDescrizioneProdotto.Text = array_prodotti[indiceSelezionato].descrizione;
                numericUpDownPrezzo.Value = (decimal)array_prodotti[indiceSelezionato].prezzo;
                buttonInserisci.Enabled = false;
                buttonModifica.Visible = true;
            }
        }

        // Evento Click Modifica
        private void buttonModifica_Click(object sender, EventArgs e)
        {
            Inserimento('m', listBoxVisualizzazioneProdotti.SelectedIndex);
            buttonInserisci.Enabled = true;
            buttonModifica.Visible = false;

            labelMediaPrezzi.Text = STRINGA_MEDIA + MediaPrezzi(array_prodotti, indice-1); // indice-1 - Per compensare l'incremento di indice
        }
    }
}
