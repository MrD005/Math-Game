﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AppAdvisory.MathGame
{
	public class gotoMD18 : ButtonHelper
	{
		public GameObject level;
		override public void OnClicked()
		{
			menuManager.backtonormal();
			Destroy(level);
			menuManager.GoToMD18();
			RemoveListener();
		}

	}
}
