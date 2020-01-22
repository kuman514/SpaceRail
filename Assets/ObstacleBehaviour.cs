using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehaviour : MonoBehaviour
{
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0f, 0f, speed);
        if(transform.position.z < -18f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 25f);
        }
    }
}
