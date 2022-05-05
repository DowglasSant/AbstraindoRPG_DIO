using AbstraindoRPG_DIO;

Console.WriteLine("Hello, World!");

Character character = new Character("Heroku", 16, "Bárbaro","Homem rústico com porrete.");

Wizzard wizzard = new Wizzard();

wizzard.Name = "Ryze";
wizzard.Level = 11;
wizzard.Class = "Mago de Combate";
wizzard.Description = "Mago azul de médio alcance";

Wizzard wizzard2 = new Wizzard("Veigar", 15);

Console.WriteLine(wizzard.ToString());
Console.WriteLine(wizzard2.ToString());
Console.WriteLine(character.ToString());

Console.WriteLine(character.Attack(200));
Console.WriteLine(wizzard.Attack());
Console.WriteLine(character.Attack());
Console.WriteLine(wizzard2.Attack(2000));

