using System;

namespace _08_Orange_Tree {
	public class OrangeTree {
		private int age = 0;
		private double height = 0;
		private int numOranges = 0;
		private int orangesEaten = 0;
		private bool treeAlive = true;
		private double waterLevel = 100;

		private static Random random = new Random();

		public int Age { get { return this.age; } }
		public double Height { get { return this.height; } }
		public bool TreeAlive { get { return this.treeAlive; } }
		public int NumOranges { get { return this.numOranges; } }
		public int OrangesEaten { get { return this.orangesEaten; } }
		public double WaterLevel { get { return this.waterLevel; } }

		public OrangeTree(int age, double height) {
			this.age = age;
			this.height = height;
		}

		public void OneYearPasses() {
			this.age++;
			this.waterLevel -= random.Next(10, 25);
			this.height += 2;

			if(this.age > 1)
				this.numOranges += 5;

			if (this.age >= 80 || waterLevel <= 0)
				this.treeAlive = false;
		}

		public void WaterTree() {
			this.waterLevel = 100;
		}

		public void EatOrange(int eating) {
			if (this.numOranges > eating) {
				this.orangesEaten += eating;
				this.numOranges -= eating;
			} else throw new IndexOutOfRangeException("You can't eat an orange that isn't there!  There are 0 oranges available to eat");
		}
	}
}