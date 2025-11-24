namespace consolStudent;

public class Fag
{
    public string Fagkode { get; set; }
    public string Fagnavn { get; set; }
    public int AntallStudiepoeng { get; set; }

    public Fag(string fagkode, string fagnavn, int studiepoeng)
    {
        Fagkode = fagkode;
        Fagnavn = fagnavn;
        AntallStudiepoeng = studiepoeng;
    }

    
    public void SkrivUtInfo()
    {
        Console.WriteLine($"Fag: {Fagkode} - {Fagnavn}, {AntallStudiepoeng} studiepoeng");
    }
}