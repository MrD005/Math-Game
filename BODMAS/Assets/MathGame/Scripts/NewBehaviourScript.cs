﻿
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using MenuBarouch;
#if APPADVISORY_LEADERBOARD
using AppAdvisory.social;
#endif
#if APPADVISORY_ADS
using AppAdvisory.Ads;
#endif

namespace AppAdvisory.MathGame
{
	public class NewBehaviourScript : MonoBehaviour
	{
		public int numberOfPlayToShowInterstitial = 5;



		static System.Random _random = new System.Random();

		public AudioClip musicBackground;
		public AudioClip goodAnswerSound;
		public AudioClip falsedAnswerSound;

		public int timeTotalGame;
		public int timeMalus;
		public int timeBonus;

		public Color NORMAL_COLOR;
		public Color GOOD_COLOR;
		public Color FAIL_COLOR;
		public Image BACKGROUND_BACK;

		public ParticleSystem ParticleSystemSuccessPrefab;

		public Text point;

		public GameObject QUESTIONS_GO;

		public GameObject BUTTONS_GO;

		public GameObject POINTS;
		public Text pointsText;

		public Text questionNumber1;
		public Text questionOperator; //+=0 -=1 *=2 /=3
		public Text questionNumber2;
		public Text questionResult;

		public Text[] reponses;

		public int level; //responsible to change the speed of the fill out => so the difficulty

		public int _score;

		public int GOODANSWER; //count the number of good answer, ie. the score

		public Slider slider; //the slider in the top of the game screen

		public Text levelText; //the text to see the level during the game

		private Vector2 pivotPoint;

		int _result = 10;
		int _number1 = 5;
		int _number2 = 5;
		int _operateur = 0;

		public delegate void _GameOver();
		public static event _GameOver OnGameOver;


		//play fx when answer is wrong
		void PlaySoundFalse()
		{
			GetComponent<AudioSource>().PlayOneShot(falsedAnswerSound);
		}

		//play fx when answer is good
		void PlaySoundGood()
		{
			GetComponent<AudioSource>().PlayOneShot(goodAnswerSound);
		}

		//play the music
		void PlayMusic()
		{
			GetComponent<AudioSource>().Play();
		}

		//stop the music
		void StopMusic()
		{
			GetComponent<AudioSource>().Stop();
		}

		void OnEnable()
		{
			Application.targetFrameRate = 60;
			StartGame();
		}

		void OnDisable()
		{
			StopMusic();
		}

		//method to start the game
		private void StartGame()
		{
			PlayMusic();

			//reset the score
			_score = 0;

			//reset the level
			level = 1;

			point.text = _score.ToString();

			levelText.text = "Level " + level.ToString();

			//create the first question
			ChooseOperator();

			//start the game
			StartCoroutine(TimerStart());
		}

		//decrease continiously the timer (= the slider), and if = 0 ==> gameover
		IEnumerator TimerStart()
		{
			slider.maxValue = timeTotalGame;
			slider.value = timeTotalGame;

			while (true)
			{

				float timer = 0.01f + ((float)Mathf.Sqrt(level)) / 100f;

				slider.value -= timer;


				//if the slider == 0 ===> game over
				if (slider.value == 0)
				{
					break;
				}


				yield return new WaitForSeconds(0.01f);
			}

			GameOver();
		}


		private void GameOver()
		{






			if (OnGameOver != null)
				OnGameOver();
		}

		//choose operateur for the question : + = 0    - = 1     * = 2      / = 3
		void ChooseOperator()
		{
			int operateur = 0;

			//if (level == 1) {
			//	operateur = UnityEngine.Random.Range (0, 2);
			//	} else if (level <= 3) {
			//	operateur = UnityEngine.Random.Range (0, 3);
			//} else {
			//	operateur = UnityEngine.Random.Range (0, 4);
			//}

			CreateQuestion(operateur);
		}

		void CreateQuestion(int operateur)
		{

			int result = 10;
			int number1 = 5;
			int number2 = 5;

			int essai = 0;

			while (true)
			{
				essai++;

				bool isOK = true;

			


				if (operateur == 3)
				{
					if (number1 % number2 != 0)
					{
						isOK = false;
					}

					if (number1 / number2 == 0)
					{
						isOK = false;
					}

					if (number1 / number2 == 1)
					{
						isOK = false;
					}
				}
				else

				if (level <= 2)
				{
					if (result > 9)
					{
						isOK = false;
					}
					if (result <= 0 || number1 <= 0 || number2 <= 0)
					{
						isOK = false;
					}
				}
				else if (level <= 4)
				{
					if (result > 50)
					{
						isOK = false;
					}
					if (result <= 0 || number1 <= 0 || number2 <= 0)
					{
						isOK = false;
					}
				}
				else if (level <= 6)
				{
					if (result > 99)
					{
						isOK = false;
					}
				}


				if (result > 99)
				{
					isOK = false;
				}


				//CHECK!!!
				if (isOK)
				{
					if (operateur == 0)
					{
						int resultTest = number1 + number2;
						if (resultTest != result)
						{
							isOK = false;
						}
					}
					if (operateur == 1)
					{
						int resultTest = number1 - number2;
						if (resultTest != result)
						{
							isOK = false;
						}
					}
					if (operateur == 2)
					{
						int resultTest = number1 * number2;
						if (resultTest != result)
						{
							isOK = false;
						}
					}
					if (operateur == 4)
					{
						int resultTest = number1 / number2;
						if (resultTest != result)
						{
							isOK = false;
						}
					}

				}


				if (isOK)
				{
					_result = result;
					_number1 = number1;
					_number2 = number2;
					_operateur = operateur;

					break;
				}
			}

			SetText(number1, number2, operateur, result);

		}

		//set the question text
		private void SetText(int n1, int n2, int oper, int result)
		{
			int TYPE_QUESTION = UnityEngine.Random.Range(0, 3);

			if (TYPE_QUESTION == 0)
			{
				questionNumber1.text = "?";

				questionNumber2.text = n2.ToString();

				questionOperator.text = GetOperator(oper);

				questionResult.text = result.ToString();

				GOODANSWER = n1;
			}



			if (TYPE_QUESTION == 1)
			{
				questionNumber1.text = n1.ToString();

				questionNumber2.text = "?";

				questionOperator.text = GetOperator(oper);

				questionResult.text = result.ToString();

				GOODANSWER = n2;
			}

			if (TYPE_QUESTION == 2)
			{
				questionNumber1.text = n1.ToString();

				questionNumber2.text = n2.ToString();

				questionOperator.text = GetOperator(oper);

				questionResult.text = "?";

				GOODANSWER = result;
			}

			questionNumber1.transform.parent.Find("Selected").gameObject.SetActive(TYPE_QUESTION == 0);

			questionNumber2.transform.parent.Find("Selected").gameObject.SetActive(TYPE_QUESTION == 1);
			questionResult.transform.parent.Find("Selected").gameObject.SetActive(TYPE_QUESTION == 2);


			if (TYPE_QUESTION != 1)
			{
				int[] answers = new int[4];

				List<int> l = new List<int>();

				l.Add(GOODANSWER);

				while (true)
				{
					int ans = 0;

					int addRange = 0;

					while (true)
					{
						bool isOk = true;

						ans = UnityEngine.Random.Range(1, GOODANSWER * 2 + 3);

						if (ans <= 0)
							isOk = false;

						if (isOk)
							break;

						addRange++;
					}

					if (!l.Contains(ans))
						l.Add(ans);

					if (l.Count == 4)
						break;
				}

				l.Sort();

				answers = l.ToArray();

				Array.Sort(answers);

				for (int i = 0; i < 4; i++)
				{
					reponses[i].fontSize = 90;
					reponses[i].text = answers[i].ToString();
				}
			}
			else
			{
				reponses[0].text = "+";
				reponses[0].fontSize = 130;
				reponses[1].text = "-";
				reponses[1].fontSize = 130;
				reponses[2].text = "x";
				reponses[3].text = "÷";
			}
		}


		public void OnClicked(Text text)
		{
			int myAnswer;

			bool isMaybeOperator = text.text.Length <= 1;

			if (text.text.Contains("+") && isMaybeOperator)
				myAnswer = 0;
			else if (text.text.Contains("-") && isMaybeOperator)
				myAnswer = 1;
			else if (text.text.Contains("x") && isMaybeOperator)
				myAnswer = 2;
			else if (text.text.Contains("÷") && isMaybeOperator)
				myAnswer = 3;
			else
				myAnswer = int.Parse(text.text);

			if (GOODANSWER == myAnswer)
			{
				_score++;

				if (_score % 5 == 0)
				{
					level++;
					levelText.text = "Level " + level.ToString();
				}

				pointsText.text = _score.ToString();

				StartCoroutine(GoodAnswerAnim());

				slider.value += timeTotalGame;

				AnimColorBACKGROUND_BACK(true);

				BUTTONS_GO.GetComponent<Animator>().Play("AnimButtonGame");

				PlaySoundGood();
			}
			else
			{
				slider.value -= timeTotalGame / 5;

				PlaySoundFalse();

				AnimColorBACKGROUND_BACK(false);
			}
		}


		private int GetResult(int n1, int n2, int oper)
		{
			if (oper == 0)
				return n1 + n2;
			else if (oper == 1)
				return n1 + n2;

			else if (oper == 2)
				return n1 + n2;

			else if (oper == 3)
				return n1 + n2;
			else
				return 0;
		}

		private string GetOperator(int oper)
		{
			if (oper == 0)
				return "+";
			else if (oper == 1)
				return "+";
			else if (oper == 2)
				return "+";
			else if (oper == 3)
				return "+";
			else
				return "";
		}

		IEnumerator GoodAnswerAnim()
		{
			float time = 0.2f;

			QUESTIONS_GO.GetComponent<Animator>().Play("AnimQuestionChange");



			yield return new WaitForSeconds(time + 0.01f);

			ChooseOperator();
		}

		public static string[] RandomizeStrings(string[] arr)
		{
			List<KeyValuePair<int, string>> list = new List<KeyValuePair<int, string>>();
			// Add all strings from array
			// Add new random int each time
			foreach (string s in arr)
			{
				list.Add(new KeyValuePair<int, string>(_random.Next(), s));
			}
			// Sort the list by the random number
			var sorted = from item in list
						 orderby item.Key
						 select item;
			// Allocate new string array
			string[] result = new string[arr.Length];
			// Copy values to array
			int index = 0;
			foreach (KeyValuePair<int, string> pair in sorted)
			{
				result[index] = pair.Value;
				index++;
			}
			// Return copied array
			return result;
		}

		public void AnimColorBACKGROUND_BACK(bool isGoodAnswer)
		{
			StartCoroutine(AnimColorBACKGROUND_BACK_Corout(isGoodAnswer));
		}

		IEnumerator AnimColorBACKGROUND_BACK_Corout(bool isGoodAnswer)
		{
			Color c = FAIL_COLOR;

			var time = 0.3f;
			var originalTime = time;

			if (isGoodAnswer)
				c = GOOD_COLOR;

			while (time > 0.0f)
			{
				time -= Time.deltaTime;
				BACKGROUND_BACK.color = Color.Lerp(NORMAL_COLOR, c, time / originalTime);
				yield return 0;
			}

		}

	}

}