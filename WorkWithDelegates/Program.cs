using WorkWithDelegates;

int Add(int a, int b)
{
    Console.WriteLine("Add");
    return a + b;
}

int Mult(int a, int b)
{
    Console.WriteLine("Mult");
    return a * b;
}

int Divide(int a, int b)
{
    Console.WriteLine("Divide");
    return a / b;
}

int Subtract(int a, int b)
{
    Console.WriteLine("Subtract");
    return a - b;
}

void ExecAndPrintResult(Method method, int a, int b)
{
    var c = method(a, b);
    Console.WriteLine($"The result is {c}");
}

ExecAndPrintResult(Add, 1, 2);
ExecAndPrintResult(Mult, 1, 2);
ExecAndPrintResult(Divide, 1, 2);
ExecAndPrintResult(Subtract, 1, 2);

Console.WriteLine("========================================");
Method m = Add;
m += Subtract;
m += Add;
m(3, 4);

Console.WriteLine("========================================");
m -= Add;
m(5, 6);

Console.WriteLine("========================================");
m -= Add;
m -= Subtract;
m?.Invoke(5, 7);

double F1(double x) => x * x;
double F2(double x) => Math.Sin(x);

void SayHello(string name) => Console.WriteLine($"Привет, {name}");
void SayBye(string name) => Console.WriteLine($"Пока, {name}");

var i = MathUtils.Trapz(F1, 0, 3, 100000);
Console.WriteLine(i);

var ii = MathUtils.Trapz(F2, 0, Math.PI, 100000);
Console.WriteLine(ii);

MathUtils.Say(SayHello, "Вася");
MathUtils.Say(SayBye, "Вася");

Console.WriteLine("=======================================================");
bool NamesFilter(string name) => name.Length > 5;
string[] names = { "Оля", "Инна", "Влада", "Анастасия", "Евгения"};
var filteredNames = ArrayUtills.Filter<string>(names, NamesFilter);
foreach(var name in filteredNames)
    Console.WriteLine(name);

Console.WriteLine("=======================================================");
int[] numbers = { 4, 67, 23, 45, 12, 90, 32, 11, 54};
var filteredNumbers = ArrayUtills.Filter(numbers, number => number > 30);
foreach(var number in filteredNumbers)
    Console.WriteLine(number);

Console.WriteLine("=======================================================");
var ii3 = MathUtils.Trapz(x => 1 / x, Math.E, Math.E * Math.E, N: 10000);
Console.WriteLine(ii3);


var broadCaster = new Broadcaster();
broadCaster.Subscribe((msg) => Console.WriteLine($"Subscriber 1: {msg}"));
broadCaster.Subscribe((msg) => Console.WriteLine($"Subscriber 2: {msg}"));
broadCaster.Subscribe((msg) => Console.WriteLine($"Subscriber 3: {msg}"));
broadCaster.Run();



delegate int Method(int a, int b);


