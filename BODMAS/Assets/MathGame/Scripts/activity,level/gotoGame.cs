 
using UnityEngine;
using System.Collections;
using UnityEngine.UI;



namespace AppAdvisory.MathGame
{


	public class gotoGame : ButtonHelper
	{
		public Text Level;

		
		override public void OnClicked()
		{
			print("OnClicked : " + gameObject.name);
			menuManager.GoToMA1();

			RemoveListener();

		}
		
	}
}





