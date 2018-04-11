using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpForce;
    public float forwardSpeed;
    public GameObject cam;
    bool dead=false;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody2D>(); 

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (dead == false)
        {
            rb.transform.Translate(new Vector3(1, 0, 0) * forwardSpeed * Time.deltaTime);
            cam.transform.Translate(new Vector3((float)0.9, 0, 0) * forwardSpeed * Time.deltaTime);

            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = Vector2.zero;
                rb.AddForce(new Vector2(0, 1) * jumpForce);
            }

        }

        if (rb.transform.localPosition.x > 42)
        {
            dead = true;
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        dead = true;

    }



}
