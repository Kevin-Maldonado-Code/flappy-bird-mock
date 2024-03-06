using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenuScript : MonoBehaviour
{
    public Text highScoreText;
    public MainMenuScript mainMenuScript;
    public GameObject mainMenu;
    public GameObject optionsMenu;

    // Start is called before the first frame update
    void Start()
    {
        highScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
    }

    public void resetHighScore()
    {
        PlayerPrefs.SetInt("HighScore", 0);
        highScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
        Debug.Log("High Score has been reset!");
    }

    public void goToMainMenu()
    {
        mainMenu.GetComponent<MainMenuScript>().setHighScoreText();
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }
}
