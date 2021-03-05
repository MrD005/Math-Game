using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AppAdvisory.MathGame
{

	public class divScoreManager : MonoBehaviour
	{
		int b1; int b2; int b3; int b4; int b5; int b6; int b7; int b8; int b9; int b10; int b11; int b12; int b13; int b14;
		int b15; int b16; int b17; int b18; int b19; int b20; int b21; int b22; int b23; int b24; int b25; int b26;
		int b27; int b28; int b29; int b30; int b31; int b32; int b33; int b34; int b35; int b36; int b37; int b38;
		int b39; int b40; int b41; int b42; int b43; int b44; int b45; int b46; int b47; int b48; int b49; int b50;
		public  int Final;
		public Text Score_;
		public void OnEnable()
		{
            b1 = PlayerPrefs.GetInt("MD1", b1);
            b2 = PlayerPrefs.GetInt("MD2", b2);
            b3 = PlayerPrefs.GetInt("MD3", b3);
            b4 = PlayerPrefs.GetInt("MD4", b4);
            b5 = PlayerPrefs.GetInt("MD5", b5);
            b6 = PlayerPrefs.GetInt("MD6", b6);
            b7 = PlayerPrefs.GetInt("MD7", b7);
            b8 = PlayerPrefs.GetInt("MD8", b8);
            b9 = PlayerPrefs.GetInt("MD9", b9);
            b10 = PlayerPrefs.GetInt("MD10", b10);
            b11 = PlayerPrefs.GetInt("MD11", b11);
            b12 = PlayerPrefs.GetInt("MD12", b12);
            b13 = PlayerPrefs.GetInt("MD13", b13);
            b14 = PlayerPrefs.GetInt("MD14", b14);
            b15 = PlayerPrefs.GetInt("MD15", b15);
            b16 = PlayerPrefs.GetInt("MD16", b16);
            b17 = PlayerPrefs.GetInt("MD17", b17);
            b18 = PlayerPrefs.GetInt("MD18", b18);
            b19 = PlayerPrefs.GetInt("MD19", b19);
            b20 = PlayerPrefs.GetInt("MD20", b20);
            b21 = PlayerPrefs.GetInt("MD21", b21);
            b22 = PlayerPrefs.GetInt("MD22", b22);
            b23 = PlayerPrefs.GetInt("MD23", b23);
            b24 = PlayerPrefs.GetInt("MD24", b24);
            b25 = PlayerPrefs.GetInt("MD25", b25);
            b26 = PlayerPrefs.GetInt("MD26", b26);
            b27 = PlayerPrefs.GetInt("MD27", b27);
            b28 = PlayerPrefs.GetInt("MD28", b28);
            b29 = PlayerPrefs.GetInt("MD29", b29);
            b30 = PlayerPrefs.GetInt("MD30", b30);
            b31 = PlayerPrefs.GetInt("MD31", b31);
            b32 = PlayerPrefs.GetInt("MD32", b32);
            b33 = PlayerPrefs.GetInt("MD33", b33);
            b34 = PlayerPrefs.GetInt("MD34", b34);
            b35 = PlayerPrefs.GetInt("MD35", b35);
            b36 = PlayerPrefs.GetInt("MD36", b36);
            b37 = PlayerPrefs.GetInt("MD37", b37);
            b38 = PlayerPrefs.GetInt("MD38", b38);
            b39 = PlayerPrefs.GetInt("MD39", b39);
            b40 = PlayerPrefs.GetInt("MD40", b40);
            b41 = PlayerPrefs.GetInt("MD41", b41);
            b42 = PlayerPrefs.GetInt("MD42", b42);
            b43 = PlayerPrefs.GetInt("MD43", b43);
            b44 = PlayerPrefs.GetInt("MD44", b44);
            b45 = PlayerPrefs.GetInt("MD45", b45);
            b46 = PlayerPrefs.GetInt("MD46", b46);
            b47 = PlayerPrefs.GetInt("MD47", b47);
            b48 = PlayerPrefs.GetInt("MD48", b48);
            b49 = PlayerPrefs.GetInt("MD49", b49);
            b50 = PlayerPrefs.GetInt("MD50", b50);
            Final = b1 + b2 + b3 + b4 + b5 + b6 + b7 + b8 + b9 + b10 + b11 + b12 + b13 + b14 + b15 + b16 + b17 +
                b18 + b19 + b20 + b21 + b22 + b23 + b24 + b25 + b26 + b27 + b28 + b29 + b30 + b31 + b32 + b33
                + b34 + b35 + b36 + b37 + b38 + b39 + b40 + b41 + b42 + b43 + b44 + b45 + b46 + b47 + b48 + b49 +
                b50;


            PlayerPrefs.SetInt("Div_star", Final);

		}

		public static void SaveScore(float lastScore, int level)
		{


			PlayerPrefs.SetFloat("LAST_SCORE", lastScore);
			PlayerPrefs.SetInt("LAST_LEVEL", level);

			int best = GetBestScore();

			if (lastScore > best)
				PlayerPrefs.SetFloat("LAST_SCORE_IS_NEW_BEST", 1);
			else
				PlayerPrefs.SetFloat("LAST_SCORE_IS_NEW_BEST", 0);


			if (lastScore > best)
				PlayerPrefs.SetFloat("BEST_SCORE", lastScore);


			PlayerPrefs.Save();
		}

		public static int Totalscore()
		{
			return PlayerPrefs.GetInt("Add_star");
		}


		public static int GetLastLevel()
		{
			return PlayerPrefs.GetInt("LAST_LEVEL");
		}

		public static bool GetLastScoreIsBest()
		{
			int temp = PlayerPrefs.GetInt("LAST_SCORE_IS_NEW_BEST");
			if (temp == 1)
			{
				return true;
			}
			return false;
		}

		public static int GetBestScore()
		{
			return PlayerPrefs.GetInt("BEST_SCORE");
		}
	}
}