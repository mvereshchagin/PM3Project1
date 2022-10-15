using System.Runtime.InteropServices;

namespace PM3Project1; // пространство имен

// модификатор_доступа дополнительные_модификаторы class название_класса
// пример: internal abstract class 
// модификаторы доступа класса:
// public - виден всем
// private - не виден снаружи
// protected (не применяется к классам)
// internal - public для классов в данном проекте и private для других проектов
// дополнительные модификаторы:
// static - экземпляр такого класса создать нельзя, все методы у него тоже static. ConsoleUtils.GetString()
// фактически, такие классы логичски объединяют некий набор методов
// sealed - класс нельзя наследовать
// abstract - экземпляр такого класса создать нельзя, но от него можно унаследоваться и создлать экзхемпляры потомков
public class Person
{
    // public - виден всем
    // private - виден только внутри класса
    // protected - виден внутри класса и его потомков
    // internal - public для классов в данном проекте и private для других проектов
    // private protected - внутри класса и потомокв, но только из той же сборки
    // protected internal - из любого места текущей сборки и из потомков в люой другой сборке

    // поля
    // модификатор_досутупа дополнительные_модификаторы тип_переменной название;
    // дополнительные модификаторы
    // readonly - может быть изменена только в конструкторе
    // const - не может меняться (должна быть инициализирована при объявлении)
    // static - поле не привязано к экземепляру класса
    // называем с маленькой буквы
    // если private или protected то с префиксом _
    private string _name;
    private string _surName;
    private DateTime? _dateOfBirth;
    private const double Pi = 3.141529; // static подразумевается
    public string Name2;

    private Gender _gender;

    public Gender GetGender()
    {
        return _gender;
    }

    public void SetGender(Gender gender)
    {
        if (_dateOfBirth is not null)
        {
            var age = DateTime.Now - _dateOfBirth.Value;
        }
        _gender = gender;
    }

    public string GetName() => _name;

    public void SetName(string name)
    {
        if (String.IsNullOrEmpty(name))
            return;

        _name = name;
    }

    

    // свойства
    public string Name
    {
        get; // возвращаем переменную (реализация по умолчанию)
        // set; // присваиваем переменную (реализация по умолчанию)
    }

    public string Name3 => _name; // свойства только на get

    public string Name4
    {
        get
        {
            return _name;
        }
    }

    public string Name5
    {
        get => _name;
    }

    public string Name6
    {
        get => _name;
        set
        {
            if (String.IsNullOrEmpty(value))
                return;

            _name = value;
        }
    }
    
    // методы
    // модификатор_доступа дополнительные_модификаторы возвращаемое_значение название(тип_параметра название_параметра, ...)
    // дополнительные модификаторы:
    // static - функция не привязаны к конкретному экземпляру класса, а существует одна для всего класса
    // abstract - только кнутри абстрактных классов. Метод, который должне быть реализован потомком

    public void Test()
    {
        _name = "Владимир";
    }
    
    // конструктор
    // модификатор_доступа азвание_класса
    // если конктсруктор не указанн, то он подразмевается
    // public название_класса() {}
    // при создании объекта вызвается конструктор
    // если указали конструктор, то конструктор по умолчанию пропалдает
    public Person(string name, string surName, DateTime? dateOfBirth = null)
    {
        Console.WriteLine("ctor with name and surname");
        name = name;
        _surName = surName;
        _dateOfBirth = dateOfBirth;
    }
    
    public Person(string name) : this(name, "Пупкин")
    {
        Console.WriteLine("ctor with name");
    }

    // при помощи this выстраиваем цепочку конструкторлв
    public Person() : this("Вася")
    {
        Console.WriteLine("ctor empty");
    }

    // деконструктор
    public void Deconstruct(out string name, out string surName)
    {
        name = _name;
        surName = _surName;
    }

    public void Deconstruct(out string name, out string surName, out DateTime? dateOfBirth)
    {
        name = _name;
        surName = _surName;
        dateOfBirth = _dateOfBirth;
    }

    // деструктор?
    // ~название_класса
    // не используем
    // вместо этого чаще всего реализуем IDisposable
    ~Person()
    {
    }
}