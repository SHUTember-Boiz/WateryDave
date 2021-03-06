﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cs_Health : MonoBehaviour
{
    public cs_GameManager m_GameManager;

    public RectTransform g_HealthObject;

    private const float F_MaxBarSize = 750.0f;
    private float f_CurrentBarSize = 750.0f;

    public int _playerID;
    private float _health;

    public GameObject g_Ship;


    void Start()
    {
        _health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        // If the game is ons
        if (m_GameManager.gs_CurrentGameState == cs_GameManager.e_GameState.GameOn)
        {
            SetHealthBar();

            if (isDead())
            {
                m_GameManager.PlayerDied(_playerID);
            }
        }
    }

    private void SetHealthBar()
    {
        f_CurrentBarSize = F_MaxBarSize * (getHealth() / 100.0f);

        g_HealthObject.sizeDelta = new Vector2(f_CurrentBarSize, 60);
    }


    float getHealth()
    {
        return _health;
    }

    public void updateHealth(float change)
    {
        _health += change;
    }

    bool isDead()
    {
        if (_health > 0)
            return false;
        else
            return true;
    }
}
