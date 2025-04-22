using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    public GameObject GameOverPanel;

    public int score;

    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenGameOver()
    {
        GameOverPanel.SetActive(true);
    }

    public void CloseGameOver()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        GameOverPanel.SetActive(false);
    }

    public void UpdateScoreText()

    {
        score++;
        scoreText.text = score.ToString();


    }
}
