using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaFormativaCSV
{
    class ListaArticoli
    {

        List<Articolo> ListaDiArticoli = new List<Articolo>();

        public List<Articolo> LeggiDati()
        {
            bool intestazione = true;
            int rigaCorrente = 0;

            try
            {
                string percorsoAssoluto = "C:\\Users\\Utente\\Desktop\\VerificaFormativaCSV\\data.csv";

                using (FileStream stream = new FileStream(percorsoAssoluto, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        while(reader.EndOfStream == false)
                        {
                            rigaCorrente++;
                            string riga = reader.ReadLine();

                            if (intestazione)
                            {
                                intestazione = false;
                                continue; 
                            }
                            if (riga == "")
                            {
                                continue; 
                            }

                            Articolo articolo = new Articolo();
                            string[] celle = riga.Split(',');

                            articolo.Id = int.Parse(celle[0]);
                            articolo.Nome = celle[1];
                            articolo.Prezzo = decimal.Parse(celle[2]) / 100 ;
                            articolo.Quantita = int.Parse(celle[3]);

                            ListaDiArticoli.Add(articolo); 

                        }
                        return ListaDiArticoli; 
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }


        }

    }



}
