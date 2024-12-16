using Class;

Console.WriteLine("Välj en av alternativen: ");
Console.WriteLine("1. Lägg til en ny bill");
Console.WriteLine("2. Visa alla tillgängliga bilar");
Console.WriteLine("3.Lägg till en ny kund");
Console.WriteLine("4. Hyra ut en ny bil");
Console.WriteLine("5. Visa alla uthyrningar");
Console.WriteLine("6. Återlämna en bil");
Console.WriteLine("7. Avsluta");

int val = Convert.ToInt32(Console.ReadLine());

if( val == 1){
    List <Bil> bilar = new List<Bil>();
    Nybil(bilar);
}

void Nybil(List<Bil> bilar){
    Console.WriteLine("Skriv in märke, modell, årsmodell, dagshyra och tillgänglighetsstatus:");
    string märke = Console.ReadLine();
    string modell = Console.ReadLine();
    int årsmodell = Convert.ToInt32(Console.ReadLine());
    double dagshyra = Convert.ToDouble(Console.ReadLine());
    bool tillgänglighetsstatus = bool.Parse(Console.ReadLine());
    Bil nyBil = new Bil(märke, modell, årsmodell, dagshyra, tillgänglighetsstatus);
    bilar.Add(nyBil);
}