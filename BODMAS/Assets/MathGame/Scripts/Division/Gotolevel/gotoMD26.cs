﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AppAdvisory.MathGame
{
	public class gotoMD26 : ButtonHelper
	{
		override public void OnClicked()
		{
			print("OnClicked : " + gameObject.name);
			menuManager.GoToMD26();
			RemoveListener();
		}

	}
}
