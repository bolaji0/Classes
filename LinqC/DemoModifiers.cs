using System;
namespace LinqC
{
	public class DemoModifiers
	{
		public void publicvoid()
		{
			privatevoid();
			protectedvoid();
		}

		private void privatevoid()
		{
			Console.WriteLine("I am from the private");
		}

        protected void protectedvoid()
        {
            Console.WriteLine("He is a boy");
        }

       public virtual void protectedvoidss()
		{
			Console.WriteLine("He is a boy DemoModifiersClasss");
	    }

		internal void internalVoid()
		{

		}
	}
}

