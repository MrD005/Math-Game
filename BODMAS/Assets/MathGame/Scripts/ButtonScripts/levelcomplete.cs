
using UnityEngine;
using System.Collections;

namespace AppAdvisory.MathGame
{
	public class levelcomplete : ButtonHelper
	{
		override public void OnClicked()
		{
			print("OnClicked : " + gameObject.name);
			menuManager.ADDcomplete();
			RemoveListener();
		}
	}
}

