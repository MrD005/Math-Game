using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AppAdvisory.MathGame
{

    public class gotoMS16 : ButtonHelper
    {
		public GameObject level;
		override public void OnClicked()
		{
			menuManager.backtonormal();
			Destroy(level);
			menuManager.GoToMS16();
			RemoveListener();
		}

	}
}
