using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMController : MonoBehaviour
{
    AudioSource bgm;

    // Start is called before the first frame update
    void Start()
    {
        bgm = GetComponent<AudioSource>();
        //bgm.playOnAwake = true;
        //bgm.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerController.Lives <= 0)
        {
            bgm.Stop();
        }
    }

    public void PlayMusic()
    {
        bgm.Play();
    }
}
