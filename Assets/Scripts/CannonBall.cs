using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    private Rigidbody rb;
    private float timer = 0;

    public GameObject BlueHealth;
    public GameObject RedHealth;

    public GameObject prefab_MushroomOP;


    private const float F_StartDamage = -15.0f;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * 10;


        BlueHealth = GameObject.Find("UI_Top_Health_L").transform.GetChild(0).gameObject;
        RedHealth  = GameObject.Find("UI_Top_Health_R").transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 5)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Ship"))
        {
            if (collision.transform.GetComponent<Movement>().playerID == 0)
            {
                // blue
                BlueHealth.GetComponent<cs_Health>().updateHealth(F_StartDamage - Random.Range(0,5));
            }
            else
            {
                // red
                RedHealth.GetComponent<cs_Health>().updateHealth(F_StartDamage - Random.Range(0, 5));
            }
        }
        Instantiate(prefab_MushroomOP,transform.position,transform.rotation);


            Destroy(gameObject);

    }
}
