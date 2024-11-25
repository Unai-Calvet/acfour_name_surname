using System;
namespace ACFour {
    public class Program {
        public static void WriteArray(int[] array) {
            for (int i = 0; i < array.Length; i++) {
                Console.Write($"{array[i]} ");
            }
            Console.Write("\n");
        }
        public static void Main() {
            const string WriteAmountOfNumbers = "Introduiex caunts nombre vols emmagatzemar";
            const string WriteANumber = "Introdueix un número";
            const string SavedNumsAre = "Els nombres emmagatzemats són: ";
            const string Error = "Error";
            int num;

            Console.WriteLine(WriteAmountOfNumbers);
            try {
                num = Convert.ToInt32(Console.ReadLine());
                int[] savedNumbers = new int[num];
                for (int i = 0; i < num; i++) {
                    Console.WriteLine(WriteANumber);
                    try {
                        savedNumbers[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    catch(Exception) {
                        Console.WriteLine(Error);
                    }
                }
                Console.WriteLine(SavedNumsAre);
                WriteArray(savedNumbers);
            }
            catch (Exception) {
                Console.WriteLine(Error);
            }
        }
    }
}