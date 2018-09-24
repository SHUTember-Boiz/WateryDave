using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabRotate : MonoBehaviour
{
	private float i = 0f;
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up, i);
		i=+ 0.5f;
	}
}
