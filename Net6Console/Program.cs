// Top-level statements
///Top-level statements remove unnecessary ceremony from many applications. 

using Net6Console.RecordTypes;
using Net6Console.Structs;

Console.WriteLine("initializing");

// RecordTypes
Console.WriteLine("------------------------------");
Console.WriteLine("RecordTypes");
Person personOlavo = new Person("Olavo", "Neto");
Person personRaquel = new Person("Raquel", "Queiroz");

Console.WriteLine($"{personOlavo.FirstName} - {personOlavo.LastName}");
Console.WriteLine($"{personRaquel.FirstName} - {personRaquel.LastName}");

// Positional Syntax
Console.WriteLine("------------------------------");
Console.WriteLine("Positional Syntax");
Car myCar = new("Caoa Chery", "Tiggo2");
Console.WriteLine(myCar);

// Equals: Record x Class
Console.WriteLine("------------------------------");
Console.WriteLine("Class code comparer");
MusicClass musicClass01 = new("In the End");
MusicClass musicClass02 = new("In the End");

Console.WriteLine(musicClass01.Equals(musicClass02));
Console.WriteLine(musicClass01 == musicClass02);

Console.WriteLine("Record code comparer");
MusicRecord musicRecord01 = new("In the End");
MusicRecord musicRecord02 = new("In the End");

Console.WriteLine(musicRecord01.Equals(musicRecord02));
Console.WriteLine(musicRecord01 == musicRecord02);

Console.WriteLine("Record code comparer - changed value");
musicRecord01.Name = "Dacing Queen";

Console.WriteLine(musicRecord01.Equals(musicRecord02));
Console.WriteLine(musicRecord01 == musicRecord02);

//With Statement
Console.WriteLine("------------------------------");
Console.WriteLine("With Statement");
Car carTiggo2 = new("Caoa Chery", "Tiggo 2");
Car carTiggo5x = carTiggo2 with { Model = "Tiggo 5x" };
Car carTiggo7x = carTiggo2 with { Model = "Tiggo 7x" };
Car carTiggo8 = carTiggo2 with { Model = "Tiggo 8" };

Console.WriteLine(carTiggo2);
Console.WriteLine(carTiggo5x);
Console.WriteLine(carTiggo7x);
Console.WriteLine(carTiggo8);

// Inheritance
Console.WriteLine("------------------------------");
Console.WriteLine("Inheritance");
Motorcycle motorcycleHondaCg125Titan = new("Honda", "CG125Titan");
Motorcycle motorcycleNinja400 = new("Ninja", "400");

Console.WriteLine(motorcycleHondaCg125Titan);
Console.WriteLine(motorcycleNinja400);

Motorcycle motorcycleNinja400_2 = new("Ninja", "400");
Car carNinja400 = new("Ninja", "400");

Console.WriteLine(motorcycleNinja400_2);
Console.WriteLine(carNinja400);

Console.WriteLine(motorcycleNinja400 == motorcycleNinja400_2);
Console.WriteLine(motorcycleNinja400 == carNinja400);

//Pattern matching enhancements
Console.WriteLine("------------------------------");
Console.WriteLine("Pattern matching enhancements");
char c1 = '1';
char c2 = 'a';
char c3 = 'X';
Console.WriteLine($"{nameof(IsLetter)} => {IsLetter(c1)} => {c1}");
Console.WriteLine($"{nameof(IsLetter)} => {IsLetter(c2)} => {c2}");
Console.WriteLine($"{nameof(IsLetter)} => {IsLetter(c3)} => {c3}");
static bool IsLetter(char c) => c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';

Console.WriteLine($"{nameof(IsCar)} => {IsCar(carTiggo2)} => {carTiggo2}");
Console.WriteLine($"{nameof(IsCar)} => {IsCar(carTiggo5x)} => {carTiggo5x}");
Console.WriteLine($"{nameof(IsCar)} => {IsCar(motorcycleNinja400)} => {motorcycleNinja400}");
Console.WriteLine($"{nameof(IsCar)} => {IsCar(motorcycleNinja400_2)} => {motorcycleNinja400_2}");
Console.WriteLine($"{nameof(IsCar)} => {IsCar(carNinja400)} => {carNinja400}");
static bool IsCar(Vehicle v) => v is Car;

Car mustangGT2018 = new("Mustang", "GT2018");
Car mustangRTR2018 = mustangGT2018 with { Model = "RTR Spec 5 2018" };
Car mustangShelby = mustangGT2018 with { Model = "Shelby GT500 2020" };

Console.WriteLine(mustangGT2018);
Console.WriteLine(mustangRTR2018);
Console.WriteLine(mustangShelby);

static bool IsKnowMustang(Vehicle v) => v.Model is "GT2018" or "RTR Spec 5 2018" or "Shelby GT500 2020";
Console.WriteLine($"{nameof(IsKnowMustang)} => {IsKnowMustang(mustangGT2018)} => {mustangGT2018}");
Console.WriteLine($"{nameof(IsKnowMustang)} => {IsKnowMustang(mustangRTR2018)} => {mustangRTR2018}");
Console.WriteLine($"{nameof(IsKnowMustang)} => {IsKnowMustang(mustangShelby)} => {mustangShelby}");
Console.WriteLine($"{nameof(IsKnowMustang)} => {IsKnowMustang(carNinja400)} => {carNinja400}");
Console.WriteLine($"{nameof(IsKnowMustang)} => {IsKnowMustang(carTiggo2)} => {carTiggo2}");

Console.WriteLine("------------------------------");
Console.WriteLine("Structs");
Game gameWithoutParameters = new Game();
Console.WriteLine($"{nameof(gameWithoutParameters)} => {gameWithoutParameters}");

Game GameefaultParameters = default(Game);
Console.WriteLine($"{nameof(GameefaultParameters)} => {GameefaultParameters}");

Game gameForzaHorizon5 = new Game("Forza horizon 5", "Microsoft", new DateTime(2021, 11, 4), 120);
Game gameForzaHorizon4 = gameForzaHorizon5 with { Name = "Forza Horizon 4", ReleaseDate = new DateTime(2018, 9, 28) };
Console.WriteLine($"{nameof(gameForzaHorizon5)} => {gameForzaHorizon5}");
Console.WriteLine($"{nameof(gameForzaHorizon4)} => {gameForzaHorizon4}");

Game gameForzaHorizon4_2 = gameForzaHorizon4;
Console.WriteLine(gameForzaHorizon5.Equals(gameForzaHorizon4));
Console.WriteLine(gameForzaHorizon5.Equals(gameForzaHorizon4));
Console.WriteLine(gameForzaHorizon4.Equals(gameForzaHorizon4_2));
