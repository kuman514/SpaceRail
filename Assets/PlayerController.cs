using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    bool isOnTheGround;
    public static int Lives = 6;
    int life;
    AudioSource se;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isOnTheGround = true;
        life = Lives;
        se = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Rail"))
        {
            // Landing
            isOnTheGround = true;
        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            // Crushed Obstacle
            print("Crushed Obstacle");

            if(Lives > 0)
            {
                Lives--;
            }
        }
    }

    void Jump()
    {
        if(isOnTheGround)
        {
            se.Play();
            rb.AddForce(0f, 200f, 0f);
            isOnTheGround = false;
        }
    }

    public void ResetLives()
    {
        Lives = life;
    }
}
