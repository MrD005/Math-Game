﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace AppAdvisory.MathGame
{
	public class AnswerMS15 : ButtonHelper
	{
		Text text;

		//do the state for mobile normal on highlightened
		void Awake()
		{
			if (Application.isMobilePlatform)
				GetComponent<Button>().animationTriggers.highlightedTrigger = "Normal";
			else
				GetComponent<Button>().animationTriggers.highlightedTrigger = "Highlighted";
		}

		override public void OnClicked()
		{
			if (text == null)
				text = GetComponentInChildren<Text>();

			MS15.OnClicked(text);


		}
	}
}