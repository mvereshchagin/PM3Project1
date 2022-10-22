using System.Drawing;
using Classes;
using PM3Project1;
using Utils;

public class Program
{
    public static void Main()
    {
        // WorkWithQuestion();
        // WorkWithFunctionArguments();
        // WorkWithLoops();
        // WorkwithEnums();
        // WorkWithTuples();
        // WorkWithClasses();
        // WorkWithInheritance();
        // WorkWithOtherProject();
        // WorkWithStructures();
        WorkWithRecords();
    }

    #region Work with enums

    private static void WorkwithEnums()
    {
        var gender = GetGender();
        Console.WriteLine($"Ваш пол: {(gender == 1 ? "м" : "ж")}");

        var gender2 = GetGender2();
        Console.WriteLine($"Ващ пол: {(gender2 == Gender.Male ? "мужчина" : "женщина")}");

        var gender3 = GetGender2();
        Console.WriteLine($"Ваш пол: {GetGenderName(gender3)}");
        
        SetFileAccess("ppp.txt", MyFileAccess.Read | MyFileAccess.Write);
        // FileAccess.Read = 1 => 0b00000001
        // FileAccess.Write = 2 => 0b00000010
        // FileAccess.Read | FileAccess.Write = 0b00000001 | 0b00000010 = 0b00000011 = 3
    }
    
    private static void SetFileAccess(string filePath, MyFileAccess fileAccess)
    {
        Console.WriteLine($"{filePath} has access {fileAccess}");
        
        // fileAccess = MyFileAccess.Read | MyFileAccess.Write = 3 = 0b00000011
        // fileAccess & MyFileAccess.Read = 0b00000011 & 0b00000001 = 0b00000001 = 1 = MyFileAccess.Read
        if(fileAccess == (fileAccess & MyFileAccess.Read))
            Console.WriteLine("Can read");
        
        // fileAccess = MyFileAccess.Read | MyFileAccess.Write = 3 = 0b00000011
        // fileAccess & MyFileAccess.Write = 0b00000011 & 0b00000010 = 0b00000010 = 2 = MyFileAccess.Write
        if(fileAccess == (fileAccess & MyFileAccess.Write))
            Console.WriteLine("Can write");
        
        // fileAccess = MyFileAccess.Read | MyFileAccess.Execute = 0x00000001 | 0x00000100 = 0x00000101 = 5
        // fileAccess & MyFileAccess.Execute = 0b00000101 & 0b00000100 = 0b00000100 = 4 = MyFileAccess.Execute
        if(fileAccess == (fileAccess & MyFileAccess.Execute))
            Console.WriteLine("Can execute");
        
        // 0 = 0b00000000
        // 1 = 0b00000001
        // 2 = 0b00000010
        // 3 = 0b00000011
        // 4 = 0b00000100
        // 5 = 0b00000101
        // 6 = 0b00000110
        // 7 = 0b00000111
        // 8 = 0b00001000
        // 9 = 0b00001001
        // 10 = 0b00001010
        // 11 = 0b00001011

    }
    
    private static void SetFileAccess2(string filePath, MyFileAccess fileAccess)
    {
        Console.WriteLine($"{filePath} has access {fileAccess}");
        
        // fileAccess = MyFileAccess.Read | MyFileAccess.Write = 3 = 0b0000011
        // fileAccess & MyFileAccess.Read = 0b0000011 & 0b0000001 = 0b0000001 = 1 = MyFileAccess.Read
        if(fileAccess == MyFileAccess.Read)
            Console.WriteLine("Can read");
        
        // fileAccess = MyFileAccess.Read | MyFileAccess.Write = 3 = 0b0000011
        // fileAccess & MyFileAccess.Write = 0b0000011 & 0b0000010 = 0b0000010 = 2 = MyFileAccess.Write
        if(fileAccess == MyFileAccess.Write)
            Console.WriteLine("Can write");
        
        // fileAccess = MyFileAccess.Read | MyFileAccess.Execute = 0b0000001 | 0b0000100 = 0b0000101 = 5
        // fileAccess & MyFileAccess.Execute = 0b0000101 & 0b0000100 = 0b0000100 = 4 = MyFileAccess.Execute
        if(fileAccess == MyFileAccess.Execute)
            Console.WriteLine("Can execute");
        
        // 0 = 0000
        // 1 = 0001
        // 2 = 0010
        // 3 = 0011
        // 4 = 0100
        // 5 = 0101
        // 6 = 0110
        // 7 = 0111
        // 8 = 1000
        // 9 = 1001
        // 10 = 1010
        // 11 = 1011

    }
    
    private static int GetGender()
    {
        bool gender;
        do
        {
            Console.WriteLine("Укажите свой пол (м / ж)");
            var strGender = Console.ReadLine();
            if (strGender == "м")
                return 1;

            if (strGender == "ж")
                return 0;
            
            Console.WriteLine("Некорректный формат");

        } while (true);
    }
    
    private static Gender GetGender2()
    {
        bool gender;
        do
        {
            Console.WriteLine("Укажите свой пол (м / ж)");
            var strGender = Console.ReadLine();
            if (strGender == "м")
                return Gender.Male;

            if (strGender == "ж")
                return Gender.Female;
            
            Console.WriteLine("Некорректный формат");

        } while (true);
    }

    private static string GetGenderName(Gender gender)
    {
        switch (gender)
        {
            case Gender.Male:
                return "мужчина";
            case Gender.Female:
                return "женщина";
            default:
                return "Неведома зверушка";
        }
    }

    private static string GetGenderName2(Gender gender) => gender switch
    {
        Gender.Male => "мужчина",
        Gender.Female => "женщина",
        _ => "Неведома зверушка",
    };

    #endregion
    
    #region Work with functions
    
    private static void WorkWithQuestion()
    {
        Console.WriteLine("What is your age?");
        var strAge = Console.ReadLine();

        var strAge2 = strAge ?? "18"; 
        // var strAge = strAge is not null ? strAge : "18";
        
        int age;
        if (!Int32.TryParse(strAge, out age))
            return;
        
        if(age < 18)
            Console.WriteLine("You are too young to use my program");
        else
            Console.WriteLine("Your age is Ok to use my program");

        var msg = age < 18 ? "You are too young to use my program" : "Your age is Ok to use my program";
        Console.WriteLine(msg);
        
        Console.WriteLine(age < 18 ? "You are too young to use my program" : "Your age is Ok to use my program");

        var a = new A();

        var propValue = a.BProp.CProp.Prop;
        if(a is not null)
            if(a.BProp is not null)
                if (a.BProp.CProp is not null)
                {
                    var val = a.BProp.CProp.Prop;
                }

        var value2 = a?.BProp?.CProp?.Prop;
    }

    private static void PrintHello(string? name)
    {
        name = name ?? GenerateDefaultName();
        Console.WriteLine(name);
    }

    private static string GenerateDefaultName()
    {
        return "Mr. unknown";
    }

    private static void ChangeValueIfLargerThan18(int value)
    {
        if (value > 18) value = 18;
    }
    
    /// <summary>
    /// Передача по ссылке
    /// </summary>
    /// <param name="value">значение</param>
    private static void ChangeValueIfLargerThan18ver2(ref int value)
    {
        if (value > 18) value = 18;
    }
    
    /// <summary>
    /// Обязательнство инициализировать переменную типа out внутри метода
    /// </summary>
    /// <param name="value"></param>
    private static void ChangeValueIfLargerThan18ver3(int inputValue, out int value)
    {
        value = inputValue < 18 ? inputValue : 18;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="inputAge"></param>
    /// <param name="outputAge"></param>
    /// <returns></returns>
    private static bool TryChangeAge(int inputAge, out int outputAge)
    {
        if (inputAge < 18)
        {
            outputAge = inputAge;
            return true;
        }

        outputAge = 18;
        return false;
    }

    /// <summary>
    /// Объект передается по ссылке, но внутри функции не может изменяться
    /// </summary>
    /// <param name="a"></param>
    private static void Change(in A a)
    {
        // a = new A();
        // a = null;
    }
    private static void WorkWithFunctionArguments()
    {
        int value = 32;
        ChangeValueIfLargerThan18(value);
        Console.WriteLine(value);
        
        ChangeValueIfLargerThan18ver2(ref value);
        Console.WriteLine(value);

        int outValue;
        ChangeValueIfLargerThan18ver3(value, out outValue);
        Console.WriteLine(outValue);

        int outAge;
        var res = TryChangeAge(value, out outAge);
        Console.WriteLine(res ? "We have changed the age" : "Tha age can not be changed");
    }

    private static void WorkWithLoops()
    {
        // Сначала проеряем условие,Ю потом заходим в тело
        // while (condition)
        // {
        //     body of loop
        // }

        {
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine(counter);
                counter++;
            }
        }

        {
            int counter = 0;
            Console.WriteLine("Start infinite loop");
            while (true)
            {
                counter++;

                if (counter > 4 && counter < 7)
                    continue; // завершаем итерацию

                if (counter > 10)
                    break; // завершаем цикл
                
                Console.WriteLine(counter);
            }
        }

        {
            // сначала выполняем, потом проверяем условие
            // do
            // {
            //      body of loop
            // }
            // while(condition);
            
            
            var age = GetAge();
            Console.WriteLine($"Your age is {age}");
        }

        {
            Console.WriteLine("Start for loop");
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            string[] names = {"Полина", "Акстися", "Милена", "Карина", "Есения"};
            for (var i = 0; i < names.Length; i++)
            {
                var name = names[i];
                Console.WriteLine(name);
            }

            for (var i = names.Length - 1; i >= 0; i--)
            {
                var name = names[i];
                Console.WriteLine(name);
            }
        }

        {
            Console.WriteLine("Foreach loop");
            string[] names = {"Полина", "Акстися", "Милена", "Карина", "Есения"};
            foreach (var name in names)
                Console.WriteLine(name);
        }
    }

    private static int GetAge()
    {
        int age;
        do
        {
            Console.WriteLine("Please specify your age");
            var strAge = Console.ReadLine();
            if (Int32.TryParse(strAge, out age))
                break;
            
            Console.WriteLine("The age is incorrect");

        } while (true);

        return age;
    }

    

    #endregion
    
    #region Work with tuples
    /// <summary>
    /// Функция для экспериментов с кортежами
    /// </summary>
    private static void WorkWithTuples()
    {
        float[] array = { 3.4f, 2.3f, 12.5f, 10.0f, 6.7f, 8.8f };
        float valueToSearch = 6.0f;
        var res = FindClosestItemInArray(array, valueToSearch);
        Console.WriteLine($"Closest value for {valueToSearch} is {res.Value} with index {res.Index}");
        
        valueToSearch = 12.2f;
        (var value, var index) = FindClosestItemInArray(array, valueToSearch);
        Console.WriteLine($"Closest value for {valueToSearch} is {value} with index {index}");
        
        valueToSearch = 8.2f;
        var (value2, index2) = FindClosestItemInArray(array, valueToSearch);
        Console.WriteLine($"Closest value for {valueToSearch} is {value2} with index {index2}");
    }

    /// <summary>
    /// Находит ближайший элемент в массиве
    /// </summary>
    /// <param name="array">Массив</param>
    /// <param name="value">Значение для поиска</param>
    /// <returns>знфчение, индекс</returns>
    static (float Value, int Index) FindClosestItemInArray(float[] array, float value)
    {
        var valueToReturn = float.MaxValue;
        var index = -1;
        for (var i = 0; i < array.Length; i++)
        {
            var diff = MathF.Abs(valueToReturn - value);
            var curDiff = MathF.Abs(array[i] - value);
            if (curDiff < diff)
            {
                index = i;
                valueToReturn = array[i];
            }
        }

        return (valueToReturn, index);
    }
    #endregion
    
    #region Work with classes

    private static void WorkWithClasses()
    {
        // создание объекта (new)
        // new запускает конструктор
        // выделяется память для объекта
        var person = new Person();
        // var person1 = new Person("Валерий");
        // var person2 = new Person("Анастасия", "Суша");

        string name3 = person.Name2;

        var (name, surName) = person;

        var (name2, surName2, datOfBirth2) = person;

        var nm = person.Name;
        // person.Name = "dsadsadsa"; нельзя, т.к. свойства только get

        person.Name6 = "Дарья";
        person.Name6 = "";
        Console.WriteLine(person.Name6);
    }
    #endregion
    
    #region Work with inheritance

    public static void WorkWithInheritance()
    {
        // создание с иницициализатором
        Student student1 = new Student()
        { // инициализатор
            Name = "Анастасия",
            Surname = "Суша",
            Gender = Gender.Female,
            Program = "Прикладная математика и информатика",
            Direction = "Что-то с геймдевом)",
            Course = 3
        };
        
        var student2 = new Student(); // сохдание. Свойства не инициализирпованы
        student2.Name = "Дарья"; // отдельно присваиваем каждое свойство
        student2.Surname = "Зайцева";
        student2.Gender = Gender.Female;
        student2.Program = "Прикладная математика и информатика";
        student2.Direction = "Что-то с геймдевом)";
        student2.Course = 3;

        var teacher = new Teacher()
        {
            Name = "Михаил",
            Surname = "Верещагин",
            Gender = Gender.Male,
            Degree = "PhD",
            Title = "доцент",
            Occupation = "директор Высшей школы компьютерных наук и прикладной математики",
            Comment = "Преподаватель \"Языки семейства С (С++ / С#)\"",
        };

        Human h1 = student1; // upcasting

        // абстрактный класс нельзя создавать, но от него можно наследоваться
        // Human human = new()
        // {
        //     Name = "Марья",
        //     Surname = "Ивановна",
        //     Gender = Gender.Female,
        // };

        // Student st = human; // нельзя downcastiung

        Student st1 = (Student) h1; // explicit downcasting

        Human[] humans =
        {
            student1, student2, teacher,
            new Student()
            {
                Name = "Алан",
                Surname = "Газиев",
                Gender = Gender.Male,
                Program = "Прикладная математика и информатика",
                Course = 3
            }
        };
        foreach (var h in humans)
        {
            if (h is Student) // если h студент
            {
                var st3 = h as Student;
                var program = st3.Program;
                Console.WriteLine($"{h.Name} {h.Surname} {st3.Direction}");
            }

            if (h is Student st4) // одновременно is и as
            {
                var program = st4.Program;
                Console.WriteLine($"{h.Name} {h.Surname} {st4.Direction}");
            }
        }

        Console.WriteLine("=============================================");
        foreach (var h in humans)
        {
            Console.WriteLine(h);
        }
        
        Console.WriteLine("=============================================");
        foreach (var h in humans)
        {
            Console.WriteLine(h.SayHello());
        }

        var st5 = new Student();
    }
    #endregion
    
    #region Work With Other Project

    public static void WorkWithOtherProject()
    {
        MyClass myClass = new();
        Console.WriteLine(myClass);

        ConsoleUtils.ReadString();
        ConsoleUtils.ReadInt();
    }
    #endregion
    
    #region Work With structures

    public static void WorkWithStructures()
    {
        Point3d point = new() { X = 100, Y = 100, Z = 100 };
        Console.WriteLine(point);
        ShiftPoint(point: point, x: 20, y: 30, z: 40);
        Console.WriteLine(point);
    }

    public static void ShiftPoint(Point3d point, int x = 0, int y = 0, int z = 0)
    {
        point.X += x;
        point.Y += y;
        point.Z += z;
    }
    #endregion
    
    #region Work with records

    public static void WorkWithRecords()
    {
        Car lada = new Car(Producer: "Lada", Model: "Sedan", Year: 2000, Color: "Baklazhan", Price: 2000000);
        // car.Price = 100; // нельзя
        Console.WriteLine(lada.Price);
        Console.WriteLine(lada);
        
        Car ladaCopy = new Car(Producer: "Lada", Model: "Sedan", Year: 2000, Color: "Baklazhan", Price: 2000000);
        Console.WriteLine(lada == ladaCopy); // Сравниваем по своствам.
                                             // Если все свойства одинкаовы, то считается, что это одини тот же объект
        
        Car bmw = new Car(Producer: "BMW", Model: "X6", Year: 2000, Color: "Green", Price: 6000000);
        if (lada == bmw)
        {
            Console.WriteLine("Different cars");
        }

        // lada2 копирует все свойства lada кроме цвета
        Car lada2 = lada with { Color = "Yellow"};
        
        CarAnalog ladaAnalog = 
            new CarAnalog(producer: "Lada", model: "Sedan", year: 2000, color: "Baklazhan", price: 2000000);
        
        CarAnalog ladaAnalog2 = 
            new CarAnalog(producer: "Lada", model: "Sedan", year: 2000, color: "Baklazhan", price: 2000000);

        Console.WriteLine(ladaAnalog == ladaAnalog2); // Сравниваются ссылки, а не поля

        var (producer, model, year, color, price) = lada;
        
        
        var car2 = new Car2(Producer: "Lada", Model: "Sedan", Year: 2000, Color: "Baklazhan", Price: 2000000);
        car2.Price = 1500000;

        var color1 = new MyRGBA() { Red = 100, Green = 200, Blue = 300, Alpha = 0.5f };
        color1.Alpha = 0.8f;

        var color2 = color1 with { Alpha = 1.0f };
    }
    #endregion
}

public class A
{
    public B BProp;
        
    public class B
    {
        public C CProp;
        public class C
        {
            public int Prop;
        }
    }
}