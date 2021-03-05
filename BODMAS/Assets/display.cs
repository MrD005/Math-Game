using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AppAdvisory.MathGame
{
    public class display : MonoBehaviour
    {
        
        public Text score;
        public Slider star;
        public void OnEnable()
        {
            score.text = ScoreManager.Totalscore().ToString();
            



        }
    }

}
