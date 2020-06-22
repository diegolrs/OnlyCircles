using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Score : MonoBehaviour
{
    private int scorePoints;
    private int highScorePoints;
    private Text scoreText;
    private Text highScoreText;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        scorePoints = 0;
        highScorePoints = 0;
        scoreText = GameObject.Find("Canvas").transform.Find("Score").transform.GetComponent<Text>();
        highScoreText = GameObject.Find("Canvas").transform.Find("HighScore").transform.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        scorePoints = (int)time;

        scoreText.text = "Score: " + scorePoints;
        highScoreText.text = "High score: " + highScorePoints;

        UpdateHighScore();
    }

    void UpdateHighScore()
    {
        if(scorePoints > highScorePoints)
        {
            highScorePoints = scorePoints;
        }
    }

    public void Reset()
    {
        scorePoints = 0;
        time = 0;
    }
}
