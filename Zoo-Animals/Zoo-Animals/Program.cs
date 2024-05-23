// See https://aka.ms/new-console-template for more information
using Zoo_Animals;

List<Animal> animals = new List<Animal>
{
    new Bird{Name = "Tweety"},
    new Elephant{Name = "Dumbo"},
    new Lion{Name = "Simba"}
};
foreach (var animal in animals)
{
    Console.WriteLine($"{animal.Name} says:");
    animal.Speak();
}
