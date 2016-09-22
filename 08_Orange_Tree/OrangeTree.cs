using System;

namespace _08_Orange_Tree {
	internal class OrangeTree {
		private int age = 0;
		private int height = 0;
		private int numOranges = 0;
		private int orangesEaten = 0;
		private bool alive = true;

		public int Age { get { return this.age; } set { this.age = value; } }
		public int Height { get { return this.height; } set { this.height = value; } }
		public bool TreeAlive { get { return this.alive; } set { this.alive = value; } }
		public int NumOranges { get { return this.numOranges; } set { this.NumOranges = value; } }
		public int OrangesEaten { get { return this.orangesEaten; } set { this.orangesEaten = value; } }

		public OrangeTree(int age, int height) {
			this.Age = age;
			this.Height = height;
		}

		internal void OneYearPasses() {
			Age++;
		}

		public void EatOrange(int v1) {

		}
	}
}