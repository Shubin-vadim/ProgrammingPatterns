// See https://aka.ms/new-console-template for more information
using Fasad.WashingMachine;
using Fasad.WashingMachine.SubSystems;

Console.WriteLine("Hello, World!");
var water = new waterManagingSubsystem();
var thermo = new Thermo();
var engine = new Engine();
var dryer = new Dryer();

var washingMachine = new WashingMachine(dryer, engine, thermo, water);

Console.WriteLine("Cotton");
washingMachine.WashCotton();

Console.WriteLine("Wool");
washingMachine.WashCotton();

Console.ReadLine();
