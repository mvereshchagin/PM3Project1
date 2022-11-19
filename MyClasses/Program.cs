using System.Drawing;
using MyClasses;
using Utils;

var capybara1 = new Capybara("Пусик") { Cuteness = 100 };
capybara1.Feed(100);
capybara1.PropertyChanged += (sender, args) => Console.WriteLine($"Property {args.PropertyName} has changed");
capybara1.PropertyChanging += (sender, args) => Console.WriteLine($"Property {args.PropertyName} has changing");
capybara1.PropertyChangedEx += (sender, args) => 
    Console.WriteLine($"Property '{args.PropertyName}' has changed its value to '{args.Value}'");
capybara1.Name = "Всадник апокалипсиса";
capybara1.Name = "Пушок";
capybara1.Name = "Пушок";
capybara1.Weight = 100;
capybara1.Weight = 50;


var msg = "хорошо в деревне летом";
var updatedStr = StringUtils.FirstLetterToUpper(msg);
Console.WriteLine(updatedStr);

var updatedStr2 = msg.FirstLetterToUpper();
Console.WriteLine(updatedStr2);

int[] numbers = {12, 34, 56, 11, 22, 132, 5, 7, 23, 55};
var filteredNumbers = numbers.Filter((item) => item < 30);
filteredNumbers.Print();

string[] names = { "Маша", "Даша", "Аркаша"};
names.Print();

var block = new Block();
block.Name = "Block 1";
block.Size = new Size(100, 100);



