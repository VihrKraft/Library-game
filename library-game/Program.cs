﻿string filePath = "GameLibrary.txt";
Console.Write("Сколько игр хотите добавить? ");
int gamesCount = 0;
gamesCount = Console.ReadLine();
for (int num = 1; num<=gamesCount; num++) {
    Console.Write("\nВведите жанр игры: ");
    string genre = Console.ReadLine();
    Console.Write("Введите название игры: ");
    string gameName = Console.ReadLine();
    Console.Write("Введите название студии разработчика: ");
    string studioName = Console.ReadLine();
    string game = $"Игра {genre}: {{Название: {gameName}, Разработчик: {studioName}}}";
    File.AppendAllText(filePath, game + "\n"); 
}
Console.WriteLine("\nИгры добавлены в бибилиотеку!");
string[] lines = File.ReadAllLines(filePath);
Console.WriteLine("\nОбновленный текст файла:");
foreach (string line in lines) {
    Console.WriteLine(line);
}