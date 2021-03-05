using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace AppAdvisory.MathGame
{
	public class PlayButton : ButtonHelper 
	{
		
		override public void OnClicked()
		{

			FindObjectOfType<MenuBarouch.MenuManager>().gototype();
			
		}

		
	
		
	}
}