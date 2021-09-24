using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicController : MonoBehaviour
{
    private AudioSource[] clips;
    private AudioSource gameIntro;
    private AudioSource normalGhost;
    // Start is called before the first frame update
    void Start()
    {
        clips = GetComponents<AudioSource>();
        gameIntro = clips[0];
        normalGhost = clips[1];
        gameIntro.Play();
        normalGhost.PlayDelayed(gameIntro.clip.length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
