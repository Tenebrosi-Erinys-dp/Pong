using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip startingClip;
    public AudioClip loopClip;
    // Start is called before the first frame update
    void Start()
    {
        audioSource.clip = startingClip;
        audioSource.Play();
        audioSource.loop = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = loopClip;
            audioSource.Play();
            audioSource.loop = true;
        }
    }
}
