using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AppAdvisory.MathGame
{

    public class gotoMS44 : ButtonHelper
    {
		public GameObject level;
		override public void OnClicked()
		{
			menuManager.backtonormal();
			Destroy(level);
			menuManager.GoToMS44();
			RemoveListener();
		}

	}
}
