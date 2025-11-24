namespace consolStudent;

public class Karakter
{
    public Student Student { get; set; }
    public Fag Fag { get; set; }
    public string Karakterverdi { get; set; }

    
    public Karakter(Student student, Fag fag, string karakterverdi)
    {
        
        Student = student;
        Fag = fag;
        Karakterverdi = karakterverdi;
    }

    public void SkrivUtInfo()
    {
        
        Console.WriteLine($"Karakter: {Student.Name} fikk {Karakterverdi} i faget {Fag.Fagkode}");
    }
}