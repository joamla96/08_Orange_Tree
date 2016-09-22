using System;

namespace _08_Orange_Tree {
	public class OrangeTree {
		private int age = 0;
		private int height = 0;
		private int numOranges = 0;
		private int orangesEaten = 0;
		private bool treeAlive = true;

		public int Age { get { return this.age; } /*set { this.age = value; }*/ }
		public int Height { get { return this.height; } /*set { this.height = value; }*/ }
		public bool TreeAlive { get { return this.treeAlive; } /*set { this.alive = value; }*/ }
		public int NumOranges { get { return this.numOranges; } /*set { this.numOranges = value; }*/ }
		public int OrangesEaten { get { return this.orangesEaten; } /*set { this.orangesEaten = value; }*/ }

		public OrangeTree(int age, int height) {
			this.age = age;
			this.height = height;
		}

		public void OneYearPasses() {
			this.age++;
			this.height += 2;

			if(this.age > 1)
				this.numOranges += 5;

			if (this.age == 80)
				this.treeAlive = false;
		}

		public void EatOrange(int eating) {
			if (this.numOranges > eating) {
				this.orangesEaten += eating;
				this.numOranges -= eating;
			} else throw new IndexOutOfRangeException("You can't eat an orange that isn't there!  There are 0 oranges available to eat");
		}
	}
}