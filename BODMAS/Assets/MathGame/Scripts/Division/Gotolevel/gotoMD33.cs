using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AppAdvisory.MathGame
{
	public class gotoMD33 : ButtonHelper
	{
		override public void OnClicked()
		{
			print("OnClicked : " + gameObject.name);
			menuManager.GoToMD33();
			RemoveListener();
		}

	}
}
