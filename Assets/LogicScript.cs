using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public Text currentScoreText;
    public Text highScoreText;
    public GameObject sassy;
    public GameObject alienSpawner;
    public GameObject pauseScreen;
    public GameObject newHighScoreScreen;
    public GameObject gameOverScreen;
    private bool isPaused = false;

    public void Start()
    {
        highScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) == true && !isPaused)
        {
            pauseGame();
        } else if (Input.GetKeyDown(KeyCode.Escape) == true && isPaused)
        {
            resumeGame();
        }
    }

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        // only increase the score if sassy is still alive
        if (sassy.GetComponent<SassyScript>().isSassyAlive())
        {
            playerScore += 1;
            currentScoreText.text = playerScore.ToString();
        }
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void pauseGame()
    {
        isPaused = true;
        Time.timeScale = 0;
        pauseScreen.SetActive(true);
    }

    public void resumeGame()
    {
        isPaused = false;
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
    }

    public void gameOver()
    {
        if (PlayerPrefs.GetInt("HighScore") < playerScore)
        {
            Debug.Log("NEW HIGH SCORE!");
            newHighScoreScreen.SetActive(true);
            PlayerPrefs.SetInt("HighScore", playerScore);
            highScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
        }
        else
        {
            gameOverScreen.SetActive(true);
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
