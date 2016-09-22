using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08_Orange_Tree;

namespace Interface {
	static class Program {
		static OrangeTree OT;

		static void Main(string[] args) {
			OT = new OrangeTree(0, 6);
			Menu();
		}

		static void Menu() {
			Console.Clear();

			Console.WriteLine("1. See Status");
			Console.WriteLine("2. Eat Oranges");
			Console.WriteLine("3. Grow Tree a Year");

			Console.WriteLine("\nX. Exit");
			Console.WriteLine("- - - - - - - - - - - - - - -");
			Console.WriteLine("Write Menu number below:");

			char KeyPressed = Console.ReadKey().KeyChar;

			switch (Char.ToLower(KeyPressed)) {
				case '1': TreeStatus(); break;
				case '2': EatOranges(); break;
				case '3': GrowTree(); break;

				case 'x': System.Environment.Exit(1); break;

			}
		}

		static void TreeStatus() {
			Console.Clear();

			Console.WriteLine("Your tree is " + OT.Age + " years old,");
			Console.WriteLine("and it is " + OT.Height + "m. tall.");

			WaitForKey();
			Menu();
		}

		static void EatOranges() {
			Console.WriteLine("How many Oranges do you want to eat?");
			int EatOranges = int.Parse(Console.ReadLine());
			OT.EatOrange(EatOranges);

			WaitForKey();
			Menu();
		}

		static void GrowTree() {
			OT.OneYearPasses();
			Menu();
		}

		static void WaitForKey() {
			Console.WriteLine("\nPress any key to continue...");
			Console.ReadKey();
		}
	}
}
