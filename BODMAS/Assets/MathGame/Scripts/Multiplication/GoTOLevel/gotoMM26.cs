using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AppAdvisory.MathGame
{

	public class gotoMM26 : ButtonHelper
	{
		public GameObject level;
		override public void OnClicked()
		{
			menuManager.backtonormal();
			Destroy(level);
			menuManager.GoToMM26();
			RemoveListener();
		}
	}
}
