
using UnityEngine;
using System.Collections;

namespace AppAdvisory.MathGame
{
	public class gotoMA2 : ButtonHelper
	{
		public GameObject level;
		override public void OnClicked()
		{
			menuManager.backtonormal();
			Destroy(level);

			menuManager.GoToMA2();
			RemoveListener();
		}
	}
}



