using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailController : MonoBehaviour
{
    Rigidbody rb;
    AudioSource se;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        se = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            RotateRail(-1);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            RotateRail(1);
        }
    }

    void RotateRail(int direction)
    {
        // -1 left, 1 right
        if(direction == -1 || direction == 1)
        {
            se.Play();
            transform.Rotate(new Vector3(0f, 45f * direction, 0f), Space.Self);
        }
    }
}
