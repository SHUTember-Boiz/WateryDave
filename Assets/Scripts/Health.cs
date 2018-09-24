using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	// Use this for initialization
	void Start () {
        _health = 100;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    int getHealth()
    {
        return _health;
    }

    void updateHealth(int change)
    {
        _health += change;
        if (isDead())
            endGame(_playerID);
    }

    bool isDead()
    {
        if (_health > 0)
            return false;
        else
            return true;
    }

    void endGame(int playerID){
        //DO SOMETHING
    }

    private int _playerID;
    private int _health;
}
