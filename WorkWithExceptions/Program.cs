using System.Security;
using WorkWithExceptions;

var res = ReadInt();
Console.WriteLine($"Вы ввели число {res}");

var res2 = ReadInt2();
Console.WriteLine($"Вы ввели число {res2}");

int ReadInt()
{
    do
    {
        Console.WriteLine("Веедите число");
        var strValue = Console.ReadLine();
        try
        {
            var value = Convert.ToInt32(strValue);
            return value;
        }
        catch 
        {
            Console.WriteLine("Неправильный ввод");
        }
    } while (true);
}

int ReadInt2()
{
    do
    {
        Console.WriteLine("Веедите число");
        var strValue = Console.ReadLine();

        int answer;

        if (Int32.TryParse(strValue, out answer))
            return answer;
        
        Console.WriteLine("Неправильный ввод");

    } while (true);
}

void ReadFile()
{
    string filePath = "котики.txt";
    
    try
    {
        string text = File.ReadAllText(filePath);
        Console.WriteLine("Текст после исключения");
    }
    catch (ArgumentNullException)
    {
        Console.WriteLine("Пусть к файлу не может быть пустым");
    }
    catch (ArgumentException)
    {
        Console.WriteLine("неправильный аргумент функции");
    }
    catch (DirectoryNotFoundException)
    {
        Console.WriteLine("Не найдена директория");
    }
    catch (PathTooLongException)
    {
        Console.WriteLine("Слишком длинный путь");
    }
    catch (IOException e)
    {
        Console.WriteLine($"Не удается считать файл: {e.Message}");
    }
    catch (SecurityException e)
    {
        Console.WriteLine($"У вас нет прав доступа для ссчитывания файла: {e.Message}");
    }
    catch (Exception e)
    {
        Console.WriteLine($"Что-то пошло не так: {e.StackTrace}");
    }
    finally // попадаем сюда в любом случае и в случае, если исключение произогшло, и в случае если нет
    {
        Console.WriteLine("Текст в блоке finally");
    }
    
    try
    {
        string text = File.ReadAllText(filePath);
    }
    catch
    {
        Console.WriteLine("Что-то пошло не так");
    }
}

void PlayCat()
{
    Cat cat = new (name: "Сыч")
    {   
        Breed = "Бродяга",
        Description = "Самый смешной кот в мире",
        DayOfBirth = new DateTime(year: 2019, month: 10, day: 7),
    };

// cat.Name = String.Empty;

// Обработка исключения
    try // засовываем в try потенциально опасный код
    {
        cat.Name = String.Empty;
    }
    catch (Exception e) // сюда попадаем в случае, если исключение произойдет
    {
        Console.WriteLine(e);
    }



    cat.Scratch();
    Thread.Sleep(20000);
    try
    {
        cat.Play();
    }
    catch (MyCatException e)
    {
        Console.WriteLine($"Кот {e.Cat} не захотел играть по причине: {e.Message}");
    }
}

Console.WriteLine("The end of app");

