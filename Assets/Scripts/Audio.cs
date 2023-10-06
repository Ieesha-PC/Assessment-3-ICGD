using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource Intro;

    public AudioSource NormalState;

    private bool NormalPlaying = false;

    // Start is called before the first frame update
    void Start()
    {
        Intro.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Intro.isPlaying && !NormalPlaying)
        {
            NormalState.Play();
            NormalPlaying = true;
        }
    }
}
