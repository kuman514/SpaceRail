using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehaviour : MonoBehaviour
{
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.02f;
        ResetPosition();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0f, 0f, speed);

        // speed increased gradually
        speed += 0.000008f;

        if(transform.position.z < -18f)
        {
            ResetPosition();
        }
    }

    void ResetPosition()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, 25f + Random.Range(0.5f, 12f));
    }
}
