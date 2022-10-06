Console.WriteLine("Введите ваше имя ");
string name = Convert.ToString(Console.ReadLine());

switch (name)
    {
    case "Bob":
        Console.WriteLine("Здарова, Bob");
        break;
    case "Tom":
        Console.WriteLine("Привет, Tom");
        break;
    case "Sam":
        Console.WriteLine("Как дела, Sam?");
        break;
    default:
        Console.WriteLine("Приятно познакомиться, " + name);
        break;
    }
