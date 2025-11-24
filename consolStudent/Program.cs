
using consolStudent;

Console.WriteLine("--- Oppretter Studenter ---");
// Bruker konstruktørene for å sette verdier
Student student1 = new Student("Nora Dahl", 22, "IT Drift", 1001);
Student student2 = new Student("Espen Ask", 24, "Programmering", 1002);

student1.SkrivUtInfo();
student2.SkrivUtInfo();
Console.WriteLine();

// --- 2. Opprett Fag-objekter ---
Console.WriteLine("--- Oppretter Fag ---");
Fag fag1 = new Fag("PROG101", "Introduksjon til C#", 10);
Fag fag2 = new Fag("DAT100", "Databasegrunnlag", 5);

fag1.SkrivUtInfo();
fag2.SkrivUtInfo();
Console.WriteLine();

// --- 3. Opprett Karakter-objekter ---
Console.WriteLine("--- Registrerer Karakterer ---");
// Sender inn referansene til Student- og Fag-objektene vi nettopp laget
Karakter karakter1 = new Karakter(student1, fag1, "A");
Karakter karakter2 = new Karakter(student2, fag1, "C");
Karakter karakter3 = new Karakter(student1, fag2, "B");

karakter1.SkrivUtInfo();
karakter2.SkrivUtInfo();
karakter3.SkrivUtInfo();
