/* 1/5
 * 
 * 
 * Spørgsmål 1: Udfra klasserne til venstre, og med det arve hierakri som klasserne implementer, 
 * hvilket af følgende 6 istantiering forneden vil IKKE vise fejl når implementeres
 * 
 * 
 * 1.//MotorKøretøjmotorKøretøj= new MotorKøretøj();
 * 2.//MotorKøretøjmotorKøretøj= new Bil();
 * 3.//MotorKøretøjmotorKøretøj= new Audi();
 * 4.//Audi audi= new Audi();
 * 5.//Audi audi= new Bil();
 * 6.//Audi audi= new MotorKøretøj()
 * 
 * 
 * Svar: 
 * Det er nr 1 og nr 4 som vil virker når vi instantiere dem.
 * 
 * 
 * Spørgsmål 2: Hvis man instantuere Audi klassen. 
 * Kan man igennem audi klassenes instans se Mærke og HesteKræfter property'erne
 * 
 * 
 * Svar: 
 * Vi kan kun se hestekræfter. Vi kan ikke se mærke.
 * 
 * 
 * Spørgsmål 3: Hvis man istantiere MotorKøretøj klassen. Kan man igennem motorkøretøj instans se Mærke og Model property'erne.
 * 
 * 
 * Svar: 
 * Man kan kun se HesteKræfter.
 * 
 * 
 * 2/5
 * 
 * 
 * Spørgsmål 1: Vis med de 3 bil data til højre, hvordan i kan, 
 * indkapsle bil dataerne i et objekt og indkapsle flere bil data objekter i en List af bil objekter i MotorKøreTøj klassen.
 * 
 * 
 * Svar: 
 * List<Bil> bil = new()
 *{
    new Bil { Mærke = "Toyota", Model = "Aygo", HesteKræfter = 60 },
    new Bil { Mærke = "Fiat", Model = "Punto", HesteKræfter = 90 },
    new Bil { Mærke = "Audi", Model = "A6", HesteKræfter = 175 }
 *};
 * 
 * 
 *Spørgsmål 2: Vis med LinQ hvordan i kan udskrive alle bilers info ud i konsollen for biler som har hestekræfter over 60. 
 * 
 * 
 * Svar: 
 * Bil b1 = bil.FirstOrDefault(a => a.HesteKræfter == 90);
 * Bil b2 = bil.FirstOrDefault(a => a.HesteKræfter == 175);
 *
 * Console.WriteLine($"{b1.Mærke} {b1.Model}");
 * Console.WriteLine($"{b2.Mærke} {b2.Model}");
 * 
 * 
 * Spørgsmål 3: Vis med LinQ hvordan i kan udtræk en enkelt bil objekt ud af mærket Audi og udskriv alle den info i konsollen
 * 
 * 
 * Svar:
 * Bil b = Biler.FirstOrDefault(a => a.Mærke == "Audi");
 * Console.WriteLine($"{b.Mærke}{b.Model}{b.HesteKræfter}");
 * 
 * 
 * 3/5
 * 
 * 
 * Spørgsmål 1: Hvilet af de 3 kode linjer foroven returner en List<Bil>
 * 
 * 
 * Svar:
 * ?? = Biler.Where(...);
 * 
 * 
 * Spørgsmål 2: Hvilket af de 3 kode linjer foroven returnere en enkel bil objekt
 * 
 * 
 * Svar:
 * ?? = Biler.FirstOrDefault(...);
 * ?? = Biler.First(...)
 * 
 * 
 * Spørgsmål 3: Hvilket af de 3 kode linjer foroven returne null værdi hvis søge kondition ikke matcher med noget af data i listen
 * 
 * 
 * Svar:
 * ?? = Biler.Where(...);
 * 
 * 
 * Spørgsmål 4: Hvilket af de 3 kode linjer foroven vil CRASH applikationen hvis ingen match fundet i søge kondition
 * 
 * 
 * Svar:
 * ?? = Biler.FirstOrDefault(...);
 * ?? = Biler.First(...);
 * 
 * 
 * 4/5
 * 
 * 
 * Spørgsmål: Alle bil skal have vægtafgift, derfor bør den ligge i Bil klassen. 
 * Men man ved ikke hvordan man skal implementer kode til udregning af vægt afgift i Bil klassen fordi det er afhængigt af bilens mærke og model.
 * Som parentklasse kan Bil klasse ikke se data i childklassen. Hvad skal man gøre her?
 * 
 * 
 * Svar:
 * Brug abstract?
 * 
 * 
 * 5/5
 * 
 * 
 * Spørgsmål: Angiv hvilken metode til venstre er overloaded.
 * 
 * 
 * Svar:
 * SetSyn er overloaded. Det er fordi den består af 2 metoder.
 * 
 * */










