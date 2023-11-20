// Важное при описании рекурсии:
// Описать условие выхода!

// Собрать строку с числами от a до b, a <= b (итеративный подход)

// string NumbersFor (int a, int b)
// {
//     string result = String.Empty;
//     for (int i = a; i <= b; i++)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

// string NumbersRec(int a, int b)
// {
//     if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
//     else return String.Empty;
// }

// Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
// Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10

// Собрать строку с числами от a до b, a >= b (итеративный подход)

// string NumbersFor (int a, int b)
// {
//     string result = String.Empty;
//     for (int i = a; i >= b; i--)  // декримент счетчика
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

// Рекурсивный подход

// string NumbersRec(int a, int b)
// {
//     if (a <= b) return NumbersRec (a + 1, b) + $"{a} ";
//     else return String.Empty;
// }

// Console.WriteLine(NumbersFor(1, 10));
// Console.WriteLine(NumbersRec(1, 10));

// Найти сумму чисел от 1 до n (итеративный способ)

// int SumFor(int n)
// {
//     int result = 0;
//     for (int i = 1; i <= n; i++) result += i;
//     return result;
// }

// Рекурсивный подход

// int SumRec (int n)
// {
//     if (n == 0) return 0;
//     else return n + SumRec(n - 1);
// }

// Console.WriteLine(SumFor(10)); // 55
// Console.WriteLine(SumRec(10)); // 55

// Факториал числа (итеративный подход)

// int FactorialFor(int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *=i;
//     return result;
// }

// Рекурсивный подход

// int FactorialRec(int n)
// {
//     if (n == 1) return 1;
//     else return n * FactorialRec( n - 1);
// }

// Console.WriteLine(FactorialFor(10)); // 3628800
// Console.WriteLine(FactorialRec(10)); // 3628800

// Вычислить a в степени n (итеративный метод)

// int PowerFor(int a, int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= a;
//     return result;
// }

// Рекурсивный подход

// int PowerRec(int a, int n)
// {
//     return n == 0 ? 1 : PowerRec (a, n - 1) * a; // тернарный оператор, замена двух строчек: if (n == 0) return 1;
//                                                                         //   else return PowerRec( a, n - 1) * a
// }

// Математический подход

// int PowerRecMath(int a, int n)
// {
//     if (n == 0) return 1;
//     else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
//     else return PowerRecMath(a, n - 1) * a;
// }

// Console.WriteLine(PowerFor(2, 10)); // 1024
// Console.WriteLine(PowerRec(2, 10)); // 1024
// Console.WriteLine(PowerRecMath(2, 10)); // 1024

// Перебор слов
// В некотором машинном алфавите имеются четыре буквы "а", "и", "с" и "в".
// Покажите все слова, состоящие из Т букв, которые можно построить из букв
// этого алфавита

// Итеративный метод

// char [] s = { 'а', 'и', 'с', 'в'};
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
//     for (int j = 0; j < count; j++)
//     {
//         Console.WriteLine($"{n++,-5} {s[i]} {s[j]}");
//     }
// }

// цикл в цикле - и так далее

// Рекурсивный метод

// int n = 1;
// void FindWords(string alphabet, char[] word, int length = 0)
// {
//     if (length == word.Length)
//     {
//         Console.WriteLine($"{n++} {new String(word)}"); return;
//     }
//     for (int i = 0; i < alphabet.Length; i++)
//     {
//         word[length] = alphabet[i];
//         FindWords (alphabet, word, length + 1);
//     }
// }

// FindWords("аисв", new char[4]);

// Алгоритм обхода директория - обойти все папки, которые находятся внутри этой папки, 
// и все файлы, находящиеся внутри этой папки 

// string path = @"C:\Users\Дина\OneDrive\Рабочий стол\Examples\Example001_HelloConsole"; // код заработал, когда @ после = добавила
// DirectoryInfo di = new DirectoryInfo(path);
// System.Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles();

// for (int i = 0; i < fi.Length; i++)
// {
//     System.Console.WriteLine(fi[i].Name);
// }

