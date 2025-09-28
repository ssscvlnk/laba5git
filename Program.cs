//void sayhello() => Console.WriteLine("hello");
//void SayHello() {
//    Console.WriteLine("hello");
//}
//SayHello();
//Console.WriteLine("Введите ваше имя: ");
//string name = Console.ReadLine();
//Console.WriteLine("Введите ваш язык (русский, немецкий или английский): ");
//string language = Console.ReadLine().ToLower();
//void sayhelloru() => Console.WriteLine($"Привет, {name}");
//void sayhelloen() => Console.WriteLine($"Hello, {name}");
//void sayhellode() => Console.WriteLine($"Guten Tag, {name}");
//switch (language)
//{
//    case "русский":
//        sayhelloru();
//        break;
//    case "английский":
//        sayhelloen();
//        break;
//    case "немецкий":
//        sayhellode();
//        break;
//    default:
//        Console.WriteLine("Язык не найден");
//        break;
//}
//void Game()
//{
//    string mygame = "minecraft";
//    Console.WriteLine(mygame);
//}
//Game();
//void Print(string message)
//{
//    Console.WriteLine(message);
//}
//Print("Hello");
//void Sum(int x, int y)
//{
//    int res = x + y;
//    Console.WriteLine(res);
//}
//Sum(12, 12);
//int x = int.Parse(Console.ReadLine());
//int y = int.Parse(Console.ReadLine());
//Sum(x, y);
//void PrintPerson(string personName = "Неизвестно", int age = 18, string vuz = "Неизвестно")
//{
//    Console.WriteLine($"Имя: {personName}, возраст: {age}, вуз: {vuz}");
//}
//PrintPerson("Polina", 17, "ВФ ВолГУ");
//PrintPerson(vuz: "ВФ ВолГУ", age: 17, personName: "Polina");
//PrintPerson();
//string GetMessage()
//{
//    return "Hello";
//}
//int GetNumber() => 10;
//var res = GetMessage();
//Console.WriteLine(res);
//Console.WriteLine(GetMessage());

//int Sum(int a, int b) => a + b;
//Console.WriteLine(Sum(10,20));
//Console.WriteLine("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//void CheckValue(int number)
//{
//    if (number<0)
//    {
//        Console.WriteLine("Число отрицательное");
//        return;
//    }
//    Console.WriteLine("Число положительное");
//}
//CheckValue(number);
//Random random = new Random();
//int number = random.Next(1,100);
//Console.WriteLine(number);
//void ShowWelcomeMessage()
//{
//    Console.WriteLine("Здравствуйте!");
//}
//void ShowGoodbyeMessage()
//{
//    Console.WriteLine("Хорошего дня!");
//}
//string GetWeather()
//{
//    string[] weathers = ["Солнечно", "Пасмурно", "Снег", "Дождь", "Ураган"];
//    Random random = new();
//    int index = random.Next(weathers.Length);
//    return weathers[index];
//}
//ShowWelcomeMessage();
//Console.WriteLine(GetWeather());
//ShowGoodbyeMessage();
int Factorial(int n)
{
    if (n == 1) return 1;
    return n * Factorial(n - 1);
}
//int factorial = Factorial(4);
//int factorial2 = Factorial(5);
//int factorial3 = Factorial(6);
//Console.WriteLine($"Факториал числа 4 = {factorial}");
//Console.WriteLine($"Факториал числа 5 = {factorial2}");
//Console.WriteLine($"Факториал числа 6 = {factorial3}");

//void Compare(int[] numbers1, int[] numbers2)
//{
//    int numbers1Sum = Sum(numbers1);
//    int numbers2Sum = Sum(numbers2);
//    if (numbers1Sum >numbers2Sum) Console.WriteLine("сумма чисел из массива numbers1 больше");
//    else if (numbers1Sum < numbers2Sum) Console.WriteLine("сумма чисел из массива numbers2 больше");
//    else Console.WriteLine("суммы массивов равны");
//        int Sum(int[] numbers)
//        {
//            int res = 0;
//            foreach (int num in numbers)
//                res += num;
//            return res;
//        }
//}
//int[] numbers1 = [1, 2, 3];
//int[] numbers2 = [3,4,5,6,7];
//Compare(numbers1, numbers2);
int Sum(int[] numbers)
{
    int limit = 0;
    int result = 0;
    foreach (int num in numbers)
    {
        if (IsPassed(num,limit)) result += num;
    }
    return result;
    static bool IsPassed(int num, int lim)
    {
        return num > lim;
    }
}
int[] numbers1 = [-3, -2, -1, 0, 1, 2, 3];
int[] numbers2 = [3,-4,5,-6,7];
Console.WriteLine(Sum(numbers1));
Console.WriteLine(Sum(numbers2));