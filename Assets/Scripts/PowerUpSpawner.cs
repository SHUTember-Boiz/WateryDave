using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{

    [SerializeField]
    private List<GameObject> spawnPoints;

    [SerializeField]
    private List<GameObject> powerUps;

    private float timer;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 10)
        {
            SpawnObject();
            timer = 0;
        }
    }

    private void SpawnObject()
    {
        int r = Random.Range(0, spawnPoints.Count);
        int a = Random.Range(0, powerUps.Count);
        Instantiate(powerUps[a], spawnPoints[r].transform.position, Quaternion.identity);
    }
}
