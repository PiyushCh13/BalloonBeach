using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreUI;
    public TextMeshProUGUI highScoreUI;
    public int score;
    public int highScore;

    // Start is called before the first frame update
    void Start()
    {
        
        highScore = PlayerPrefs.GetInt("highscore");
    }

    // Update is called once per frame
    void Update()
    {

        scoreUI.text = score.ToString();
        highScoreUI.text = highScore.ToString();

        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("highscore", highScore);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
       

        if (other.gameObject.tag == "Score Up")
        {
            score++;

        }
    }

}

