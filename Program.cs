// See https://aka.ms/new-console-template for more information
using System;

class Bai1
{
    static void Main()
    {
        Console.Write("Nhap ho ten: ");
        string name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Chuoi rong hoac null!");
            return;
        }

        // Xoa khoang trang dau/cuoi
        name = name.Trim();

        // Tach cac tu
        string[] words = name.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        // Chuan hoa tung tu
        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            words[i] = char.ToUpper(word[0]) + word.Substring(1).ToLower();
        }

        // Noi lai thanh chuoi
        string result = string.Join(" ", words);
        Console.WriteLine("Ho ten sau chuan hoa: " + result);
    }
}