using consolStudent;

public class Program 
{
    
    private static List<Student> studenter = new List<Student>();
    private static List<Fag> fag = new List<Fag>();
    private static List<Karakter> karakterer = new List<Karakter>();

    
    public static void Main(string[] args)
    {
        InitialiserDatabase();
        MainLoop();
    }

    

    private static void MainLoop()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("--- Hovedmeny Skoleadministrasjon ---");
            Console.WriteLine("1. Vis alle studenter og karakterer");
            Console.WriteLine("2. Registrer ny karakter for student");
            Console.WriteLine("3. Rediger eksisterende karakter");
            Console.WriteLine("4. Legg til ny student");
            Console.WriteLine("5. Avslutt");
            Console.Write("Velg et alternativ: ");

            var input = Console.ReadLine();

            switch (input)
            
            {
                case "1":
                    VisStudenterOgKarakterer();
                    break;
                case "2":
                    RegistrerNyKarakter();
                    break;
                case "3":
                    RedigerKarakter();
                    break;
                case "4":
                    LeggTilStudent();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Ugyldig valg. Trykk enter for å fortsette.");
                    Console.ReadLine();
                    break;
            }
        }
    }

    private static void LeggTilStudent()
    {
        Console.Clear();
        Console.WriteLine("--- legg til student ---");
        Console.Write("Skriv inn navn: ");
        string navn = Console.ReadLine();
        Console.Write("Skriv inn alder: ");
        int alder = int.Parse(Console.ReadLine());
        Console.Write("Skriv inn studieprogram: ");
        string studieprogram = Console.ReadLine();
        Console.Write("Skriv inn student ID: ");
        int studentID = int.Parse(Console.ReadLine());
        Student nyStudent = new Student(navn, alder, studieprogram, studentID);
        studenter.Add(nyStudent);
    }

    private static void VisStudenterOgKarakterer()
    {
        Console.Clear();
        Console.WriteLine("--- Registrerte Studenter ---");
        foreach (var student in studenter)
        {
            student.SkrivUtInfo();
        }
        Console.WriteLine("\nTrykk enter for å gå tilbake til menyen.");
        Console.ReadLine();
    }

    private static void RegistrerNyKarakter()
    {
        Console.Clear();
        Console.WriteLine("--- Registrer Ny Karakter ---");

        Console.Write("Skriv inn Student ID (eks: 1001): ");
        if (!int.TryParse(Console.ReadLine(), out int studentId)) { Console.WriteLine("Ugyldig ID."); return; }

        Console.Write("Skriv inn Fagkode (eks: PROG101): ");
        string fagkode = Console.ReadLine().ToUpper();

        Console.Write("Skriv inn Karakter (A-F): ");
        string karakterverdi = Console.ReadLine().ToUpper();

        var student = studenter.FirstOrDefault(s => s.StudentID == studentId);
        var fagObjekt = fag.FirstOrDefault(f => f.Fagkode == fagkode);

        if (student != null && fagObjekt != null)
        {
            Karakter nyKarakter = new Karakter(student, fagObjekt, karakterverdi);
            karakterer.Add(nyKarakter);
            Console.WriteLine($"\nKarakter '{karakterverdi}' lagt til for {student.Name} i {fagObjekt.Fagnavn}!");
        }
        else
        {
            Console.WriteLine("\nFant ikke student eller fag med oppgitt ID/kode. Sjekk input og prøv igjen.");
        }

        Console.WriteLine("\nTrykk enter for å fortsette.");
        Console.ReadLine();
    }

    private static void RedigerKarakter()
    {
        Console.Clear();
        Console.WriteLine("--- Rediger Karakter ---");

        Console.WriteLine("Oversikt over alle karakterer (for redigering):");
        for (int i = 0; i < karakterer.Count; i++)
        {
            Console.WriteLine($"[{i}] {karakterer[i].Student.Name} i {karakterer[i].Fag.Fagkode}: {karakterer[i].Karakterverdi}");
        }

        Console.Write($"\nSkriv inn indeksnummeret for karakteren du vil redigere (0 til {karakterer.Count - 1}): ");
        if (!int.TryParse(Console.ReadLine(), out int indeks) || indeks < 0 || indeks >= karakterer.Count)
        {
            Console.WriteLine("Ugyldig indeks.");
            return;
        }

        Karakter karakterSomSkalRedigeres = karakterer[indeks];
        Console.Write($"Skriv inn ny karakter: ");
        string nyVerdi = Console.ReadLine().ToUpper();

        karakterSomSkalRedigeres.Karakterverdi = nyVerdi;
        Console.WriteLine($"\nKarakter oppdatert til '{nyVerdi}'.");

        Console.WriteLine("\nTrykk enter for å fortsette.");
        Console.ReadLine();
    }


    private static void InitialiserDatabase()
    {
        Student student1 = new Student("kul mckuli", 22, "IT Drift", 1001);
        Student student2 = new Student("jan teigen", 24, "Programmering", 1002);
        studenter.Add(student1);
        studenter.Add(student2);

        Fag fag1 = new Fag("PROG101", "Introduksjon til C#", 10);
        Fag fag2 = new Fag("DAT100", "Databasegrunnlag", 5);
        fag.Add(fag1);
        fag.Add(fag2);

        Karakter karakter1 = new Karakter(student1, fag1, "A");
        Karakter karakter2 = new Karakter(student2, fag1, "C");
        Karakter karakter3 = new Karakter(student1, fag2, "B");
        karakterer.Add(karakter1);
        karakterer.Add(karakter2);
        karakterer.Add(karakter3);

        Console.WriteLine("Startdata lastet inn.");
    }
}