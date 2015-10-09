using System;

namespace GarbageCollectSample
{
	public class GarbageClass
	{

		public void createGarbage(int limit)
		{
			Garbage gb;
			for (int i = 0; i < limit; i++) 
			{
				gb = new Garbage ();
				//gb = new MoreGarbage ();
			}
		}
	}
}

