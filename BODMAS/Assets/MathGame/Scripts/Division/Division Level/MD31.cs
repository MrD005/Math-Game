using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
#if APPADVISORY_LEADERBOARD
using AppAdvisory.social;
#endif
#if APPADVISORY_ADS
using AppAdvisory.Ads;
#endif

namespace AppAdvisory.MathGame
{
	public class MD31 : MonoBehaviour
	{


		public int numberOfPlayToShowInterstitial = 5;
		public GameObject Game;
		public GameObject complete;
		[SerializeField]



		private float count = 100f;

		public AudioClip musicBackground;
		public AudioClip goodAnswerSound;
		public AudioClip falsedAnswerSound;
		public GameObject LeftStar;
		public GameObject MidStar;
		public GameObject RightStar;


		public int timeTotalGame;


		public Color NORMAL_COLOR;
		public Color GOOD_COLOR;

		public Color FAIL_COLOR;
		public Image BACKGROUND_BACK;



		public Text point;

		public GameObject QUESTIONS_GO;

		public GameObject BUTTONS_GO;
		public Text theLastScore;

		public GameObject POINTS;
		public Text pointsText;

		public Text questionNumber1;
		public Text questionOperator; //+=0 -=1 *=2 /=3
		public Text questionNumber2;
		public Text questionResult;

		public Text[] reponses;

		public int level; //responsible to change the speed of the fill out => so the difficulty

		public float _score;

		public int GOODANSWER; //count the number of good answer, ie. the score

		public Slider slider; //the slider in the top of the game screen
		public GameObject slid;


		public Text levelText; //the text to see the level during the game



		public delegate void _GameOver();
		public static event _GameOver OnGameOver;
		bool help = false;

		private void Update()
		{
			count -= 1 * 0.2f;

			if (help == false)
			{
				StartGame();
				Debug.Log("start");
				help = true;

			}

		}
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





			//create the first question
			ChooseOperator();

			//start the game
			StartCoroutine(TimeMA3());
			Debug.Log("Timer");
		}



		//decrease continiously the timer (= the slider), and if = 0 ==> gameover
		IEnumerator TimeMA3()
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
					_score = 0;
					Destroy(slid);
					Destroy(POINTS);
					Destroy(BUTTONS_GO);
					Destroy(QUESTIONS_GO);
					complete.SetActive(true);
					theLastScore.text = "" + _score;
					LeftStar.SetActive(false);
					MidStar.SetActive(false);
					RightStar.SetActive(false);
					break;
				}


				yield return new WaitForSeconds(0.01f);
			}
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


		public void CreateQuestion(int operateur)
		{

			//Text.Equals("1");
			//if(l==1)
			//a = 1,b=2,r=3
			//else if(l==2)
			//a=3,b=5,r=8....continue;
			//level =text
			int result = 71;
			int number1 = 5041;
			int number2 = 71;




			int _result = result;
			int _number1 = number1;
			int _number2 = number2;
			int _operateur = operateur;



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

		}


		public void OnClicked(Text text)
		{
			int myAnswer;

			bool isMaybeOperator = text.text.Length <= 1;

			if (text.text.Contains("+") && isMaybeOperator)
				myAnswer = 0;
			else
				myAnswer = int.Parse(text.text);

			if (GOODANSWER == myAnswer)
			{
				_score = 100;

				QUESTIONS_GO.SetActive(false);

				Destroy(slid);
				Destroy(POINTS);
				Destroy(BUTTONS_GO);
				Destroy(QUESTIONS_GO);
				complete.SetActive(true);

				StartCoroutine(GoodAnswerAnim());

				AnimColorBACKGROUND_BACK(true);

				BUTTONS_GO.GetComponent<Animator>().Play("AnimButtonGame");

				PlaySoundGood();
			}
			else if (GOODANSWER != myAnswer)
			{

				_score = 0;
				slider.value -= timeTotalGame / 5;

				PlaySoundFalse();

				AnimColorBACKGROUND_BACK(false);
			}
			if (count < 100 && count > 70)
			{
				float time = 0.4f;
				float time2 = 0.5f;
				float time3 = 0.6f;
				GoIn(LeftStar, time, time);
				GoIn(MidStar, time2, time2);
				GoIn(RightStar, time3, time3);
				_score = count;
				theLastScore.text = "" + _score;
			}
			else if (count < 70 && count > 40)
			{
				float time = 0.4f;
				float time2 = 0.5f;
				_score = count;
				GoIn(LeftStar, time, time);
				GoIn(MidStar, time2, time2);
				theLastScore.text = "" + _score;

			}
			else if (count < 40 && count > 20)
			{
				_score = count;
				float time = 0.4f;
				GoIn(LeftStar, time, time);
				theLastScore.text = "" + -_score;
			}
			else if (_score == 0)
			{
				LeftStar.SetActive(false);
				MidStar.SetActive(false);
				RightStar.SetActive(false);
				theLastScore.text = "" + _score;
			}

			theLastScore.text = "" + count;
			//help = false;

		}


		private int GetResult(int n1, int n2, int oper)
		{
			if (oper == 3)
				return n1 / n2;

			else
				return 0;
		}

		private string GetOperator(int oper)
		{
			if (oper == 3)
				return "/";
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

		public void GoOut(GameObject obj, float time, float delay)
		{
			obj.transform.localScale = Vector3.one;
			StartCoroutine(GoInOrOutCorout(obj, 0, time, delay, () => {
				obj.transform.localScale = Vector3.zero;
				obj.SetActive(false);
			}));

		}

		//animation scale from 0 to 1
		public void GoIn(GameObject obj, float time, float delay)
		{
			obj.transform.localScale = Vector3.zero;
			StartCoroutine(GoInOrOutCorout(obj, 1, time, delay, () => {
				obj.transform.localScale = Vector3.one;
				obj.SetActive(true);
			}));

		}

		//do the animation scale
		IEnumerator GoInOrOutCorout(GameObject obj, float scale, float time, float delay, Action callback)
		{
			obj.SetActive(true);

			yield return new WaitForSeconds(delay);

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
				callback();
		}


	}

}