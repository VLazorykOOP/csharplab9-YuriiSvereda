// See https://aka.ms/new-console-template for more information
using Lab9_10CharpT;
using System.Collections;
using System.Text;

Console.WriteLine("Lab#9  or  Lab#10");
//За бажанням студента для задач можна створювати консольний проект або WinForm
// Бажано для задач лаб. робіт створити окремі класи
// Виконання  виконати в стилі багатозаданості :
//   Lab9T2 lab9task2 = new Lab9T2; lab9task2.Run();
//При бажанні можна створити багатозадачний режим виконання 
static void Task1()
{
    string filePath = "t.txt";
    Console.OutputEncoding = Encoding.Latin1;
    using (StreamReader reader = new StreamReader(filePath))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in line)
            {
                stack.Push(c);
            }
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}

static void Task2()
{
    // Читаємо текстовий файл і розділяємо його на слова
    string[] words = File.ReadAllText("input.txt").Split(new[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

    Queue<string> vowelWords = new Queue<string>();
    Queue<string> consonantWords = new Queue<string>();

    // Розподіляємо слова за гласними та приголосними
    foreach (string word in words)
    {
        char firstChar = char.ToLower(word[0]);
        if (firstChar == 'a' || firstChar == 'e' || firstChar == 'i' || firstChar == 'o' || firstChar == 'u' || firstChar == 'y')
        {
            vowelWords.Enqueue(word);
        }
        else
        {
            consonantWords.Enqueue(word);
        }
    }

    // Друкуємо слова у вказаному порядку
    while (vowelWords.Count > 0)
    {
        Console.WriteLine(vowelWords.Dequeue());
    }

    while (consonantWords.Count > 0)
    {
        Console.WriteLine(consonantWords.Dequeue());
    }
}

static void Task3()
{
    Console.WriteLine("Task1:");
    string filePath = "t.txt";
    Console.OutputEncoding = Encoding.Latin1;
    using (StreamReader reader = new StreamReader(filePath))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            ArrayList list = new ArrayList();
            foreach (char c in line)
            {
                list.Add(c);
            }
            list.Reverse();
            foreach (char c in list)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine("\nTask2:");
    ArrayList wordsList = new ArrayList(File.ReadAllText("input.txt").Split(new[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries));
    ArrayList vowelWords = new ArrayList();
    ArrayList consonantWords = new ArrayList();

    // Розподіляємо слова за гласними та приголосними
    foreach (string word in wordsList)
    {
        char firstChar = char.ToLower(word[0]);
        if (firstChar == 'a' || firstChar == 'e' || firstChar == 'i' || firstChar == 'o' || firstChar == 'u' || firstChar == 'y')
        {
            vowelWords.Add(word);
        }
        else
        {
            consonantWords.Add(word);
        }
    }

    // Друкуємо слова у вказаному порядку
    foreach (string word in vowelWords)
    {
        Console.WriteLine(word);
    }

    foreach (string word in consonantWords)
    {
        Console.WriteLine(word);
    }
}

static void Task4()
{
    MusicCatalog catalog = new MusicCatalog();

    catalog.AddDisk("Disk 1");
    catalog.AddSong("Disk 1", "Artist 1", "Song 1");
    catalog.AddSong("Disk 1", "Artist 1", "Song 2");
    catalog.AddSong("Disk 1", "Artist 2", "Song 3");

    catalog.AddDisk("Disk 2");
    catalog.AddSong("Disk 2", "Artist 1", "Song 4");
    catalog.AddSong("Disk 2", "Artist 2", "Song 5");

    catalog.DisplayCatalog();

    catalog.SearchByArtist("Artist 1");
}
Task4();
