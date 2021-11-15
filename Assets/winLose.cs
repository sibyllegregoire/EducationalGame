using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winLose : MonoBehaviour{
    public int Score;
    public Text ScoreText;
    public int Soft;
    public int Hard;

    // Update is called once per frame
    public void Update(){
        if(Score >= 10){
            YouWin();
        }
        
    }
    public void YouWin(){
        ScoreText.text = "You Win!";
        Time.timeScale = 0f;
    }
 
    public void SoftAddScore()
    {
        if (Soft == 1)
        {
            Score++;
            ScoreText.text = Score.ToString();
            Debug.Log(ScoreText.text);
        }
        else
        {
            ScoreText.text = "You are Wrong!";
            Time.timeScale = 0f;
        }
    }
    
    public void HardAddScore()
    {
        if (Hard == 1)
        {
            Score++;
            ScoreText.text = Score.ToString();
            Debug.Log(ScoreText.text);
        }
        else
        {
            ScoreText.text = "You are Wrong!";
            Time.timeScale = 0f;
        }
    }
}
