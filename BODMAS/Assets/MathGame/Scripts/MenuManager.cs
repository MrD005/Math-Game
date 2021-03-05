using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace MenuBarouch
{

	public class MenuManager : MonoBehaviour 
	{
		public RectTransform rect;
		public GameObject parentadd;
		public RectTransform Game;
		public GameObject type;

		public GameObject Addcomplete;
		public GameObject Subcomplete;
		public GameObject Mulcomplete;
		public GameObject Divcomplete;
		public GameObject MENU;
		public GameObject GameOver;
		public GameObject play;

		public GameObject[] MA;
		public GameObject[] MS;
		public GameObject[] MM;
		public GameObject[] MD;
		public Button[] A;
		public Button[] B;
		public Button[] C;
		public Button[] D;
		public Image BACKGROUND_BACK;

		public Color NORMAL_COLOR;

		private void Start()
		{
			print(Screen.width);
			print(Screen.height);
			print(Screen.currentResolution);
			print(Screen.currentResolution.width);
			print(Screen.currentResolution.height);


			for (int i = 2; i <= 50; i++)
			{
				A[i].interactable = false;

			}

			//level size according to phone resolution
		}

		public void size()
        {
			
			if (Screen.width == 720 && Screen.height == 1280)
			{ 
				Game.position = new Vector2(0,-150);
			}

			else if (Screen.width == 720 && Screen.height == 1520)
			{
				Game.position = new Vector2(0, 150);
			}

			else if (Screen.width == 480 && Screen.height == 800)
			{
				Game.position = new Vector2(0, -150);
			}

		}

		public void backtonormal()
        {
			if (Screen.width == 720 && Screen.height == 1280)
			{
				Game.position = new Vector2(370, 670);
			}

			else if (Screen.width == 720 && Screen.height == 1520)
            {
				Game.position = new Vector2(350,800);
			}

			if (Screen.width == 480 && Screen.height == 800)
			{
				Game.position = new Vector2(370, 670);
			}
		}
		void Awake()
		{
			MENU.SetActive (true);		
			type.SetActive(false);
			Subcomplete.SetActive(false);
			Mulcomplete.SetActive(false);
		    Divcomplete.SetActive(false);
			type.SetActive(false);

		}

		public void ADDcomplete() 
		{
			
			float time = 0.2f;
			GoIn(Addcomplete, time, time);
			Addcomplete.SetActive(true);
			
		}
		public void SUBcomplete()
		{

			float time = 0.2f;
			GoIn(Subcomplete, time, time);
			Subcomplete.SetActive(true);
		}
		public void MULcomplete()
		{

			float time = 0.2f;
			GoIn(Mulcomplete, time, time);
			Mulcomplete.SetActive(true);
		}

		public void DIVcomplete()
		{
			float time = 0.2f;
			GoIn(Divcomplete, time, time);
			Divcomplete.SetActive(true);
		}
		public void Backtomenu()
		{
			float time = 0.2f;
			GoOut(type, time, 0);//type=+,-;
			GoIn(MENU, time, time);
			GameOver.SetActive(false);
			play.SetActive(true);


		}
		
		public void completetoAddlevel()
		{
			float time = 0.2f;
			GoIn(type, time, time);
			backtonormal();
		}

		public void completetoSUBlevel()
		{
			float time = 0.2f;
			GoIn(type, time, time);
		}
		public void completetoMullevel()
		{
			float time = 0.2f;
			GoIn(type, time, time);
		}
		public void completetoDivlevel()
		{
			float time = 0.2f;
			GoIn(type, time, time);
		}
		
		public void gototype() 
		{
			float time = 0.2f;
			GoOut(MENU, time, 0);
			GoIn(type, time, time);
		}
		//open the game
		public void GoToMA1()
		{
			float time = 0.2f;
			
			GoOut(type, time, 0);
			MA[1].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[1], MA[1].transform.position, Quaternion.identity) as GameObject) ;
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();


		}
		public void GoToMA2()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[2].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[2], MA[2].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA3()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[3].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[3], MA[3].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA4()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[4].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[4], MA[4].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
		}
		public void GoToMA5()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[5].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[5], MA[5].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA6()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[6].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[6], MA[6].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();

		}
		public void GoToMA7()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[7].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[7], MA[	7].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA8()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[8].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[8], MA[8].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA9()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[9].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[9], MA[9].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA10()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[10].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[10], MA[10].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA11()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[11].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[11], MA[11].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA12()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[1].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[12], MA[12].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA13()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[13].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[13], MA[13].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA14()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[14].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[14], MA[14].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA15()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[15].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[15], MA[15].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMA16()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[16].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[16], MA[16].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMA17()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[17].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[17], MA[17].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA18()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[18].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[18], MA[18].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMA19()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[19].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[19], MA[19].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA20()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[20].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[20], MA[20].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA21()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[21].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[21], MA[21].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA22()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[22].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[22], MA[22].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMA23()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[23].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[23], MA[23].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMA24()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[24].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[24], MA[24].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA25()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[25].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[25], MA[25].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA26()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[26].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[26], MA[26].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA27()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[27].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[27], MA[27].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA28()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[28].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[28], MA[28].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA29()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[29].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[29], MA[29].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA30()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[30].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[30], MA[30].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMA31()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[31].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[31], MA[31].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMA32()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[32].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[32], MA[32].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA33()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[33].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[33], MA[33].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA34()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[34].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[34], MA[34].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMA35()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[35].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[35], MA[35].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMA36()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[36].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[36], MA[36].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMA37()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[37].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[37], MA[37].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA38()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[38].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[38], MA[38].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMA39()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[39].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[39], MA[39].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA40()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[40].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[40], MA[40].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMA41()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[41].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[41], MA[41].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA42()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[42].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[42], MA[42].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA43()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[43].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[43], MA[43].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA44()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[44].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[44], MA[44].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA45()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[45].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[45], MA[45].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMA46()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[46].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[46], MA[46].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA47()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[47].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[47], MA[47].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA48()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[48].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[48], MA[48].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA49()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[49].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[49], MA[49].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMA50()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MA[50].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MA[50], MA[50].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMS1()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[1].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[1], MS[1].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMS2()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[2].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[2], MS[2].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMS3()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[3].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[3], MS[3].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMS4()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[4].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[4], MS[4].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMS5()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[5].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[5], MS[5].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMS6()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[6].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[6], MS[6].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMS7()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[7].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[7], MS[7].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMS8()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[8].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[8], MS[8].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMS9()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[9].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[9], MS[9].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMS10()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[10].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[10], MS[10].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMS11()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[11].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[11], MS[11].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMS12()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[12].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[12], MS[12].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMS13()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[13].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[13], MS[13].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMS14()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[14].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[14], MS[14].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMS15()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[15].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[15], MS[15].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMS16()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[16].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[16], MS[16].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMS17()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[17].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[17], MS[17].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMS18()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[18].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[18], MS[18].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMS19()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[19].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[19], MS[19].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMS20()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[20].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[20], MS[20].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMS21()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[21].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[21], MS[21].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMS22()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[22].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[22], MS[22].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMS23()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[23].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[23], MS[23].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMS24()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[24].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[24], MS[24].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMS25()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[25].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[25], MS[25].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMS26()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[26].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[26], MS[26].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMS27()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[27].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[27], MS[27].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMS28()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[28].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[28], MS[28].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMS29()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[29].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[29], MS[29].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMS30()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[30].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[30], MS[30].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMS31()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[31].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[31], MS[31].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMS32()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[32].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[32], MS[32].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMS33()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[33].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[33], MS[33].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMS34()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[34].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[34], MS[34].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMS35()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[35].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[35], MS[35].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMS36()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[36].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[36], MS[36].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMS37()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[37].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[37], MS[37].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMS38()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[38].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[38], MS[38].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMS39()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[39].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[39], MS[39].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMS40()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[40].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[40], MS[40].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMS41()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[41].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[41], MS[41].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMS42()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[42].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[42], MS[42].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMS43()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[43].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[43], MS[43].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMS44()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[44].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[44], MS[44].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMS45()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[45].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[45], MS[45].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMS46()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[46].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[46], MS[46].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMS47()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[47].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[47], MS[47].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMS48()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[48].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[48], MS[48].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMS49()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[49].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[49], MS[49].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMS50()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MS[50].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MS[50], MS[50].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMM1()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[1].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[1], MM[1].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM2()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[2].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[2], MM[2].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM3()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[3].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[3], MM[3].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM4()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[4].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[4], MM[4].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM5()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[5].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[5], MM[5].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMM6()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[6].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[6], MM[6].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMM7()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[7].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[7], MM[7].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMM8()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[8].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[8], MM[8].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM9()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[9].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[9], MM[9].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM10()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[10].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[10], MM[10].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM11()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[11].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[11], MM[11].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM12()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[12].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[12], MM[12].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM13()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[13].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[13], MM[13].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM14()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[14].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[14], MM[14].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM15()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[15].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[15], MM[15].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM16()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[16].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[16], MM[16].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM17()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[17].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[17], MM[17].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM18()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[18].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[18], MM[18].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}


		

		public void GoToMM19()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[19].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[19], MM[19].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM20()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[20].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[20], MM[20].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM21()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[21].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[21], MM[21].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMM22()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[22].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[22], MM[22].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMM23()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[23].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[23], MM[23].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM24()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[24].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[24], MM[24].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM25()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[25].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[25], MM[25].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM26()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[26].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[26], MM[26].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMM27()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[27].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[27], MM[27].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM28()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[28].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[28], MM[28].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM29()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[29].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[29], MM[29].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM30()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[30].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[30], MM[30].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM31()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[31].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[31], MM[31].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM32()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[32].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[32], MM[32].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM33()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[33].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[33], MM[33].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM34()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[34].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[34], MM[34].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMM35()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[35].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[35], MM[35].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMM36()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[36].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[36], MM[36].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM37()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[37].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[37], MM[37].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM38()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[38].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[38], MM[38].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM39()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[39].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[39], MM[39].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM40()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[40].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[40], MM[40].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM41()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[41].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[41], MM[41].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM42()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[42].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[42], MM[42].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMM43()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[43].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[43], MM[43].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM44()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[44].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[44], MM[44].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM45()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[45].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[45], MM[45].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM46()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[46].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[46], MM[46].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM47()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[47].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[47], MM[47].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM48()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[48].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[48], MM[48].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM49()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[49].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[49], MM[49].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMM50()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MM[50].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MM[50], MM[50].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMD1()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[1].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[1], MD[1].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMD2()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[2].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[2], MD[2].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD3()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[3].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[3], MD[3].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD4()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[4].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[4], MD[4].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMD5()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[5].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[5], MD[5].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMD6()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[6].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[6], MD[6].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMD7()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[7].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[7], MD[7].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMD8()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[8].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[8], MD[8].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD9()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[9].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[9], MD[9].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD10()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[10].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[10], MD[10].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD11()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[11].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[11], MD[11].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD12()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[12].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[12], MD[12].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD13()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[13].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[13], MD[13].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD14()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[14].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[14], MD[14].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD15()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[15].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[15], MD[15].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD16()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[16].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[16], MD[16].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD17()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[17].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[17], MD[17].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD18()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[18].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[18], MD[18].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD19()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[19].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[19], MD[19].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD20()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[20].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[20], MD[20].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD21()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[21].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[21], MD[21].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD22()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[22].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[22], MD[22].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD23()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[23].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[23], MD[23].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD24()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[24].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[24], MD[24].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD25()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[25].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[25], MD[25].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD26()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[26].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[26], MD[26].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD27()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[27].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[27], MD[27].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD28()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[28].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[28], MD[28].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD29()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[29].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[29], MD[29].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD30()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[30].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[30], MD[30].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD31()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[31].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[31], MD[31].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMD32()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[32].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[32], MD[32].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD33()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[33].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[33], MD[33].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMD34()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[34].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[34], MD[34].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}

		public void GoToMD35()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[35].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[35], MD[35].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD36()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[36].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[36], MD[36].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD37()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[37].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[37], MD[37].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD38()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[38].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[38], MD[38].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD39()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[39].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[39], MD[39].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD40()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[40].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[40], MD[40].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD41()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[41].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[41], MD[41].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD42()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[42].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[42], MD[42].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD43()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[43].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[43], MD[43].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD44()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[44].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[44], MD[44].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD45()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[45].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[45], MD[45].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD46()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[46].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[46], MD[46].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD47()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[47].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[47], MD[47].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD48()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[48].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[48], MD[48].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD49()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[49].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[49], MD[49].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		public void GoToMD50()
		{
			float time = 0.2f;

			GoOut(type, time, 0);
			MD[50].SetActive(true);
			GameObject GO;
			GO = (Instantiate(MD[50], MD[50].transform.position, Quaternion.identity) as GameObject);
			GO.transform.SetParent(Game);
			GO.transform.localScale = new Vector3(1, 1, 1);
			size();
		}
		void Update()
		{
			BACKGROUND_BACK.color = Color.Lerp(BACKGROUND_BACK.color, NORMAL_COLOR,Time.time);
		}

		//animation scale from 1 to 0
		public void GoOut(GameObject obj, float time, float delay)  
		{
			obj.transform.localScale = Vector3.one;
			StartCoroutine (GoInOrOutCorout (obj, 0, time, delay, () => {
				obj.transform.localScale = Vector3.zero;
				obj.SetActive(false);
			}));

		}

		//animation scale from 0 to 1
		public void GoIn(GameObject obj, float time, float delay){
			obj.transform.localScale = Vector3.zero;
			StartCoroutine (GoInOrOutCorout (obj, 1, time, delay, () => {
				obj.transform.localScale = Vector3.one;
				obj.SetActive(true);
			}));

		}

		//do the animation scale
		IEnumerator GoInOrOutCorout(GameObject obj, float scale, float time, float delay, Action callback)
		{
			obj.SetActive(true);

			yield return new WaitForSeconds (delay);

			var originalScale = obj.transform.localScale;
			var targetScale = Vector3.one * scale;
			var originalTime = time;

			while (time > 0.0f)
			{
				time -= Time.deltaTime;
				obj.transform.localScale = Vector3.Lerp(targetScale, originalScale, time / originalTime);
				yield return 0;
			}

			if (callback != null)
				callback ();
		}
	}
}
