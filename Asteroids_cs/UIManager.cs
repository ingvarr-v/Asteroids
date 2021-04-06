using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public PlayerManager playerMan;
    public GameObject GameUI, deathUI;

    void Awake()
    {
        deathUI.SetActive(false);
        Time.timeScale = 0;
        playerMan.playerActive = false;
    }

    public void startGame()
    {
        Time.timeScale = 1;
        playerMan.playerActive = true;
        GameUI.SetActive(false);
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void restartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
