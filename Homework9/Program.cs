
// // ----------------------------------  Task 1  -----------------------------------
//
// Console.Write("Listdagi sonlarning sig'imini kiriting: ");
// int a = int.Parse(Console.ReadLine());
// List<int> numbers = new List<int>(a);
// int sum = 0;
// for (int i = 0; i < a; i++)
// {
//     Console.Write($"{i+1}-son: ");
//     numbers.Add(int.Parse(Console.ReadLine()));
//     sum += numbers[i];
// }
// Console.WriteLine($"Listdagi sonlarning yig'indisi: {sum}");

// // ----------------------------------  Task 2  -----------------------------------
//
// Console.Write("Listdagi so'zlarning sig'imini kiriting: ");
// int b = int.Parse(Console.ReadLine());
// List<string> words = new List<string>(b);
// for (int i = 0; i < b; i++)
// {
//     Console.Write($"{i+1}-So'z: ");
//     words.Add(Console.ReadLine());
// }
// Console.WriteLine($"So'zlarning birlashtirilgani: {string.Join(" ", words)}");

// // ----------------------------------  Task 3  -----------------------------------
//
// Console.Write("Listdagi sanalarning sig'imini kiriting: ");
// int c = int.Parse(Console.ReadLine());
// List<DateTime> date = new List<DateTime>(c);
// for (int i = 0; i < c; i++)
// {
//     Console.Write($"{i + 1}-Sana: ");
//     date.Add(DateTime.Parse(Console.ReadLine()));
// }
// date.Sort();
// foreach (DateTime d in date)
// {
//     Console.WriteLine(d);
// }

// // ----------------------------------  Task 4  -----------------------------------
//
// Console.Write("Listdagi sonlarning sig'imini kiriting: ");
// int d = int.Parse(Console.ReadLine());
// List<double> date = new List<double>(d);
// double sum2 = 0;
// for (int i = 0; i < d; i++)
// {
//     Console.Write($"{i + 1}-Sana: ");
//     date.Add(double.Parse(Console.ReadLine()));
//     sum2 += date[i];
// }
// Console.WriteLine($"Sonlarning o'rtacha qiymati: {sum2/d}");

// // ----------------------------------  Task 5  -----------------------------------
//
// Console.Write("Listdagi sonlarning sig'imini kiriting: ");
// int e = int.Parse(Console.ReadLine());
// List<int> even = new List<int>(e);
// for (int i = 0; i < e; i++)
// {
//     Console.Write($"{i+1}-son: ");
//     even.Add(int.Parse(Console.ReadLine()));
// }
// Console.Write("Listdagi juft sonlar: ");
// foreach (var item in even)
// {
//     if (item % 2 == 0)
//     {
//         Console.Write(item+ "  ");
//     }
// }

// // ----------------------------------  Task 6  -----------------------------------
//
// Console.Write("Listdagi boolenlarning sig'imini kiriting: ");
// int f = int.Parse(Console.ReadLine());
// List<bool> allTrue = new List<bool>(f);
// for (int i = 0; i < f; i++)
// {
//     Console.Write($"{i+1}-boolen: ");
//     allTrue.Add(bool.Parse(Console.ReadLine()));
// }
//
// if (allTrue.All(x => x == true))
// {
//     Console.WriteLine("Listdagi barcha element true. ");
// }
// else
// {
//     Console.WriteLine("Listdagi barcha element true emas. ");
// }

// // ----------------------------------  Task 7  -----------------------------------
//
// Console.Write("Listdagi elementlarning sig'imini kiriting: ");
// int g = int.Parse(Console.ReadLine());
// List<string> elements = new List<string>(g);
// for (int i = 0; i < g; i++)
// {
//     Console.Write($"{i+1}-element: ");
//     elements.Add(Console.ReadLine());
// }
// Console.Write("Qaysi elementni o'chirmoqchisiz: ");
// string s = Console.ReadLine();
// elements.Remove(s);
// Console.WriteLine("Qolgan elementlar: ");
// foreach (string element in elements)
// {
//     Console.WriteLine(element);
// }

// // ----------------------------------  Task 8  -----------------------------------
//
// Console.Write("Listdagi elementlarning sig'imini kiriting: ");
// int h = int.Parse(Console.ReadLine());
// List<string> elements2 = new List<string>(h);
// for (int i = 0; i < h; i++)
// {
//     Console.Write($"{i+1}-element: ");
//     elements2.Add(Console.ReadLine());
// }
// Console.Write("Qaysi elementni qidirmoqchisiz: ");
// string t = Console.ReadLine();
// bool isFinding;
// if (isFinding = elements2.Contains(t))
// {
//     Console.WriteLine("Bu element listda bor.");
// }
// else
// {
//     Console.WriteLine("Bu element listda yo'q.");
// }

// // ----------------------------------  Task 9  -----------------------------------
//
// Console.Write("Listdagi elementlarning sig'imini kiriting: ");
// int h = int.Parse(Console.ReadLine());
// List<string> items = new List<string>(h);
// for (int i = 0; i < h; i++)
// {
//     Console.Write($"{i+1}-item: ");
//     items.Add(Console.ReadLine());
// }
// Console.Write("Qaysi elementni qo'shishni xohlaysiz: ");
// string v= Console.ReadLine();
// items.Add(v);
// Console.WriteLine("Listdagi elementlar: ");
// foreach (var item in items)
// {
//     Console.WriteLine(item);
// }

// // ----------------------------------  Task 10  -----------------------------------
//
// Console.Write("Listdagi sonlarning sig'imini kiriting: ");
// int k = int.Parse(Console.ReadLine());
// List<int> numbers3 = new List<int>(k);
// for (int i = 0; i < k; i++)
// {
//     numbers3.Add(new Random().Next(1,1000));
// }
// Console.Write("Lisdagi sonlar: ");
// foreach (int number in numbers3)
//     {
//         Console.Write(number+"  ");
//     }
