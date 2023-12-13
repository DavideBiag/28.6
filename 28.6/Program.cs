using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._6
{
   public enum TitoliDiStudio
    {
        LaureaMagistrale,
        Dottorato,
        Master
    }
    public class Persona
    {
        public string nome { get; set; }
        public string cognome { get; set; }
    }
    public class Studente : Persona
    {
        public int matricola { get; set; }
    }
    public class Docente : Persona
    {
        public TitoliDiStudio titoloDiStudio { get; set; }
    }

    public class Aula
    {
        public int capienza { get; set; }
        public string nome { get; set; }
        public List<string> elencoRisorse {get; set; }

        public void aggiungiRisorsa(string risorsa)
        {
            elencoRisorse.Add(risorsa);    
        }
    }
    public class Lezione
    {
        public string descrizione { get; set; } 
        public DateTime data { get; set; }
        public int orarioInizio { get; set; }   
        public int durata { get; set; } 
        public Docente docente { get; set; }    
        public Aula aulaAssegnata { get; set; } 
        public List<Studente> studentiPresenti { get; set; }
       
        public void segnaAssente(Studente studente)
        {
            studentiPresenti.Remove(studente);
        }
    }
    public class Corso
    {
        public string nome { get; set; }    
        public int edizione { get; set;}
        public List<Lezione> lezioni { get; set; }
        public List <Studente> studentiIscritti { get; set; }  

        public void aggiungiLezione(Lezione lezione)
        {
            lezioni.Add(lezione);
        }
        public void aggiungiStudente(Studente studente)
        {
            studentiIscritti.Add(studente);
        }
    }
    public class Elencocorsi
    {
        public List<Corso> corsi { get; set; }
        public void aggiungiCorso(Corso corso)
        {
            corsi.Add(corso);
        }
    }

        internal class Program
    {
        static void Main(string[] args)
        {
        
        }
    }
}
