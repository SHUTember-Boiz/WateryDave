using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cs_GameManager : MonoBehaviour {

    private enum e_GameState
    {
        Paused,
        GameOn
    }

    private e_GameState gs_CurrentGameState  = e_GameState.Paused;
    public GameObject g_StartPanel;
    public GameObject g_OptionsPanel;


    void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}

    public void QuitGame()
    {
        Application.Quit();
    }

    // Func to begin game
    // Todo - main Update loop only runs if we are checking Game on
    public void StartGame()
    {
        gs_CurrentGameState = e_GameState.GameOn;
        g_StartPanel.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void OptionsMenu()
    {
        g_StartPanel.SetActive(false);
        g_OptionsPanel.SetActive(true);
    }

    public void MainMenu()
    {
        g_StartPanel.SetActive(true);
        g_OptionsPanel.SetActive(false);
    }
}
