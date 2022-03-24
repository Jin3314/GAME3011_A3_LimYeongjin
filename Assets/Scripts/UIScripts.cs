using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIScripts : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI TimerText;
    public TextMeshProUGUI EndText;
    
    // Update is called once per frame
    void Update()
    {
        ScoreText.text = GameManager.instance.score.ToString();
        TimerText.text = ((int)GameManager.instance.timer).ToString();
        EndText.text = "Your Score: " + GameManager.instance.lastScore.ToString();
    }
}
