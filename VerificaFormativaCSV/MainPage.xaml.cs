namespace VerificaFormativaCSV
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }


        private void BtnCaricaDati_Clicked(object sender, EventArgs e)
        {

            ListaArticoli listaArticoli = new ListaArticoli();

            try
            {
                List<Articolo> ListaDiArticoli2 = listaArticoli.LeggiDati(); 
                ListaElementi.ItemsSource = ListaDiArticoli2;
                DisplayAlert("Caricamento completato", "Caricate " +  " canzoni", "OK");

            }
            catch (Exception eccezione)
            {
                DisplayAlert("Errore", eccezione.Message, "OK");
            }
        }

        private void OnAzione1Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var articolo = button.BindingContext as Articolo;

            DisplayAlert("Azione 1", "Hai cliccato su: " + articolo.Nome, "OK");
        }

        private void OnAzione2Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var articolo = button.BindingContext as Articolo;

            DisplayAlert("Azione 2", "Hai cliccato su: " + articolo.Nome, "OK");
        }

    }

}
