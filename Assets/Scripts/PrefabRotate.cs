using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabRotate : MonoBehaviour
{
	private float i = 0f;
	// Update is called once per frame
	void Update ()
    {
		transform.Rotate(Vector3.up, i);
		i=+ 0.5f;
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Ship"))
        {
            if (gameObject.CompareTag("Speed"))
            {
                collision.transform.GetComponent<Movement>().DoubleSpeed();
            }
            else
            {
                collision.transform.GetComponent<Movement>().AddAttack();
            }
        }

        Destroy(gameObject);
    }
}
