
using UnityEngine;
using System.Collections;

namespace AppAdvisory.MathGame
{
	public class backtomenu : ButtonHelper
	{
		override public void OnClicked()
		{
			print("OnClicked : " + gameObject.name);
			menuManager.Backtomenu();
			RemoveListener();
		}
	}
}


