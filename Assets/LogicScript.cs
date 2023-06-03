using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public static bool isPaused = false;
    public static bool canReceiveInput = true;
    public int playerScore;
    public int highScore;
    public Text scoreText;
    public Text highScoreText;
    public GameObject gameOverScreen;
    public GameObject pauseGameScreen;
    public AudioSource dingSFX;
    public AudioSource gameoverSFX;

    private void Start()
    {
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("highScore");
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        dingSFX.Play();
    }

    public void Update()
    {
        if(!gameOverScreen.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (isPaused)
                {
                    ResumeGame();
                }
                else
                {
                    TogglePause();
                }
            }
        }
    }

    private void OnDisable()
    {
        if (pauseGameScreen != null)
        {
            ResumeGame();
        }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        if (pauseGameScreen != null)
        {
            pauseGameScreen.SetActive(false);
        }
        isPaused = false;
        canReceiveInput = true; 
    }  

    void TogglePause()
    {
            Time.timeScale = 0f;
            if (pauseGameScreen != null)
            {
                pauseGameScreen.SetActive(true);
            }
            isPaused = true;
            canReceiveInput = false;
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        gameoverSFX.Play(); 
        
        if (playerScore >= PlayerPrefs.GetInt("highScore"))
        {
            highScore = playerScore;
            PlayerPrefs.SetInt("highScore", playerScore);
        }
    }
}