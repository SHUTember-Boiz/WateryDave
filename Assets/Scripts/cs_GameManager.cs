﻿using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cs_GameManager : MonoBehaviour {

    public enum e_GameState
    {
        Paused,
        GameOn
    }

    public e_GameState gs_CurrentGameState  = e_GameState.Paused;
    public GameObject g_StartPanel;
    public GameObject g_OptionsPanel;
    public GameObject g_PausePanel;
    public GameObject g_GamePanel;


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


    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }


    public void StartGame()
    {
        gs_CurrentGameState = e_GameState.GameOn;
        g_StartPanel  .SetActive(false);
        g_OptionsPanel.SetActive(false);
        g_PausePanel  .SetActive(false);
        g_GamePanel   .SetActive(true);
    }


    public void OptionsMenu()
    {
        gs_CurrentGameState = e_GameState.Paused;
        g_StartPanel  .SetActive(false);
        g_OptionsPanel.SetActive(true);
        g_PausePanel  .SetActive(false);
        g_GamePanel   .SetActive(false);
    }

    public void MainMenu()
    {
        gs_CurrentGameState = e_GameState.Paused;
        g_StartPanel  .SetActive(true);
        g_OptionsPanel.SetActive(false);
        g_PausePanel  .SetActive(false);
        g_GamePanel   .SetActive(false);
    }

    public void PauseGame()
    {
        gs_CurrentGameState = e_GameState.Paused;
        g_StartPanel  .SetActive(false);
        g_OptionsPanel.SetActive(false);
        g_PausePanel  .SetActive(true);
        g_GamePanel   .SetActive(false);
    }

    public void PlayerDied(int PlayerID)
    {
    }
}