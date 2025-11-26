namespace consolStudent
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Studieprogram { get; set; }
        public int StudentID { get; set; }
        
        public List<Karakter> Karakterer { get; set; } = new List<Karakter>();

        public Student(string name, int age, string studieprogram, int studentID)
        {
            Name = name;
            Age = age;
            Studieprogram = studieprogram;
            StudentID = studentID;
        }
        /*
        public Student(string name, int age, string studieprogram, int studentID, List<Karakter> startKarakterer)
        {
            Name = name;
            Age = age;
            Studieprogram = studieprogram;
            StudentID = studentID;

            foreach (var k in startKarakterer)
            {
                LeggTilKarakter(k);
            }
        }
        */
        
        public void LeggTilKarakter(Karakter karakter)
        {
            Karakterer.Add(karakter);
        }

        
        public void SkrivUtInfo()
        {
            Console.WriteLine($"\n--- Studentinformasjon: {Name} ---");
            Console.WriteLine($"Alder: {Age}, Student-ID: {StudentID}, Studieprogram: {Studieprogram}");
            if (Karakterer.Count == 0)
            {
                Console.WriteLine("Har ingen registrerte karakterer enda.");
            }
            else
            {
                Console.WriteLine("Registrerte karakterer:");
                foreach (var k in Karakterer)
                {
                    
                    Console.WriteLine($"- Fagkode: {k.Fag.Fagkode}, Fagnavn: {k.Fag.Fagnavn}, Karakter: {k.Karakterverdi}");
                }
            }
        }
    }
}