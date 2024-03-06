using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    public Text highScoreText;
    public GameObject mainMenu;
    public GameObject optionsMenu;

    public void Start()
    {
        setHighScoreText();
    }

    public void startGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void goToOptionsMenu()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

    public void setHighScoreText()
    {
        highScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
