using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector3 velocity, torque;
    private float maxSpeed = 5, speed = 1f, shotTimer = 0;

    [SerializeField]
    Transform firePoint;

    [SerializeField]
    private GameObject cannonBall;

    [SerializeField]
    private KeyCode Forward, Back, Left, Right, Fire;

    private bool bouncing = false, canFire = true;

    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!bouncing)
        {
            shotTimer -= Time.deltaTime;

            if (shotTimer < 0 && !canFire)
            {
                canFire = true;
                shotTimer = 1.5f;
            }

            torque = Vector3.zero;
            velocity = Vector3.zero;

            if (Input.GetKey(Forward))
            {
                // Add velocity
                velocity -= transform.forward * 10;
            }

            if (Input.GetKey(Back))
            {
                // Reduce velocity
                velocity += transform.forward * 10;
            }

            if (Input.GetKey(Left))
            {
                // Add torque clockwise
                torque -= Vector3.up;
            }

            if (Input.GetKey(Right))
            {
                // Add torque anti-clockwise
                torque += Vector3.up;
            }

            // Limit speed and torque
            velocity = Vector3.ClampMagnitude(velocity, maxSpeed);

            rb.AddForce(velocity);
            rb.AddTorque(torque);

            if (Input.GetKeyDown(Fire) && canFire)
            {
                // Fire
                Instantiate(cannonBall, firePoint.transform.position, firePoint.transform.rotation);
                canFire = false;
                shotTimer = 1.5f;
            }
        }
        else
        {
            // Reduce velocity

            if (velocity.magnitude > 0)
            {
                bouncing = false;
            }
        }
    }

    void BounceBack()
    {
        // Set velocity backwards
        rb.velocity = -transform.forward;
        bouncing = true;
    }
}
