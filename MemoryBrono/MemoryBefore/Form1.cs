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

namespace MemoryBefore
{
    public partial class MemoryForm : Form
    {
        private GameSettings settings;

        public MemoryForm()
        {
            InitializeComponent();
            settings = new GameSettings();
            UstawKontrolki();
            GenerujKarty();
        }

        private void UstawKontrolki()
        {
            panelKart.Width = settings.Bok * settings.Kolumny+100;
            panelKart.Height = settings.Bok * settings.Wiersze;

            Width = panelKart.Width;
            Height = panelKart.Height + 150;


            lblStartInfo.Text = $"Początek gry za {settings.CzasPodgladu}";
            lblPunktyWartosc.Text = settings.AktualnePunkty.ToString();
            lblCzasWartosc.Text = settings.CzasGry.ToString();


        }

        private void GenerujKarty()
        {
            string[] memories = Directory.GetFiles(settings.FolderObrazki);

            settings.MaxPunkty = memories.Length;

            List<MemoryCard> buttons = new List<MemoryCard>();

            foreach (string img in memories)
            {

                Guid id = Guid.NewGuid();
                //sprawdź ctor
                MemoryCard b1 = new MemoryCard(id, settings.PlikLogo, img);
                buttons.Add(b1);

                MemoryCard b2 = new MemoryCard(id, settings.PlikLogo, img);
                buttons.Add(b2);
            }

            // tworzymy generator liczb pseudolosowych
            // wykorzystamy go do losowego rozmieszczania kart na panelu
            Random random = new Random();

            // czyściemy panel z wszystkich kart
            // mogę się w nim jakieś znajdować, ponieważ tą samą metodę
            // wykorzystujemy do restartowania gry
            panelKart.Controls.Clear();

            // robimy pętlę po wszystkich kolumnach
            for (int x = 0; x < settings.Kolumny; x++)
            {
                // robimy pętlę po wszystkich wierszach
                // w ten sposób stworzy nam się siatka 2D z rozmieszczonymi kartami
                for (int y = 0; y < settings.Wiersze; y++)
                {
                    // losujemy indeks kolejnej karty z zakresu od zera 
                    // do ilości wszystkich pozostałych do rozlosowania kart
                    int index = random.Next(0, buttons.Count);

                    // pobieramy z listy kartę o wylosowanym indeksie
                    MemoryCard b = buttons[index];

                    // dodajemy zmienną na niewielki margines 
                    // - odstęp pomiedzy sąsiednimi kartami
                    int margines = 2;

                    // obliczamy pozycję x i y na panelu pod którą zostanie umieszczona karta
                    // x wyznaczamy mnożąc wiersz w którym jesteśmy przez długość boku
                    // dodając dwa razy margines (po lewej i po prawej)
                    // y wyznaczamy mnoząc kolumnę w której jesteśmy przez długość boku 
                    //dodając dwa razy margines (u góry i u dołu)
                    b.Location = new Point((x * settings.Bok) + (margines * x), (y * settings.Bok) + (margines * y));

                    // ustawiamy wielkość karty
                    b.Width = settings.Bok;
                    b.Height = settings.Bok;

                    // ta linijska do zdarzenia kliknięcia przypisuje metodę btnClicked
                    // jest to analogiczne do przypisanie zdarzenia z designera
                    //b.Click += BtnClicked;

                    // odkrywamy startowo kartę
                    b.Odkryj();

                    // dodajemy przygotowaną kartę do panelu gry
                    panelKart.Controls.Add(b);

                    // na samym końcu usuwamy z listy kartę, aby nie została ponowanie dodana
                    buttons.Remove(b);
                }

            }


        }


    
    }
}
