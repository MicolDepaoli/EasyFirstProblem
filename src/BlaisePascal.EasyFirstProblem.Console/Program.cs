public class Program
{
    public enum TipoConsegna
    {
        consegnato,
        ritirato
    }
    public static void Main()
    {
        Console.WriteLine("inserisci il nome del cliente");
        string nomeCliente = Console.ReadLine();

        Console.WriteLine("inserisci il numero di libri che ha acquistato");
        int numeroLibri = int.Parse(Console.ReadLine());

        Console.WriteLine("Dimmi quanto costa ogni singolo libro");
        double costoSingolo = double.Parse(Console.ReadLine());

        Console.WriteLine("il cliente è uno studente? Inserisci true o false");
        bool isStudente = bool.Parse(Console.ReadLine());

        Console.WriteLine("il tipo di consegna, consegnato o ritirato?");
        string tipoConsegna = Console.ReadLine();

        double subTotale = numeroLibri * (double)costoSingolo;
        int spedizione=5;
        double totale = subTotale + spedizione;

        Console.WriteLine($"Il cliente {nomeCliente} ha acquistato {numeroLibri} libri,ogni libro costa {costoSingolo}, il tipo di consegna è {tipoConsegna}, il subtotale è {subTotale}, le spese di spedizione sono {spedizione} euro, infine il totale è {totale} euro");
        if (subTotale == 0)
        {
            Console.WriteLine("Ordine non valido!");
        }
        if (totale < 20)
        {
            Console.WriteLine("Ordine di piccolo importo");

        }
        else { 
            Console.WriteLine("grazie per il tuo ordine! ");
        }
        


    }
}