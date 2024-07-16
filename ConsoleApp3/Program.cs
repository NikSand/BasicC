using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        string dayOfWeek;

        Random rand = new Random();
        int value = rand.Next(0, 10); //первое значение захватывается, второе - нет

        int[,] array = new int[3, 5]; //многомерный массив

        int[,] array3 = new int[2, 3] {
                { 9, 8, 7 },
                { 6, 5, 4}
            };

        for (int i = 0; i < array3.GetLength(0); i++) // измерение для перехода по строкам
        {
            for (int j = 0; j < array3.GetLength(1); j++) //измерение перехода по столбцам
            {
                Console.WriteLine(array3[i, j] + " ");
            }
        }

        foreach (int number in array3) // цикл foreach
        {
            Console.WriteLine(number + " ");
        }


        dayOfWeek = Console.ReadLine();

        if (dayOfWeek == "понедельник")
        {
            Console.WriteLine("Study courses");
        }
        else if (dayOfWeek == "вторник")
        {
            Console.WriteLine("Do homeworck");
        }

        int sum = 0;
        int x = 1;
        int y = 5;

        Add(ref sum, x, y);

        Console.WriteLine(sum);

    }
    static void Add(ref int sum, int x, int y) // ref - ссылка на область памяти, out - функция сама создает область в памяти; когда переменную нечем инициализировать - int sum;
    {
        sum = x + y;
    }

    List<int> myList = new List<int>(); // .Count - размер , .Insert(1, 56) - вставка элемента в любую позицию
    Queue<string> myQueue = new Queue<string>(); // .Enqueue() - добавить в очередь, Dequeue() - получить из очереди - посмотреть, .Peek() - кто первый в очереди
    
    // public Knight (int health, int armor, int damage) : base (heaslth, armor, damage) {}
    //вызов конструктора родительского класса
}