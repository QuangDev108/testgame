using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public static SoundController instance;
    private void Awake()
    {
        instance = this;
    }
    public void PlayThisSound(string clipName, float volumeMutiplayer)
    {
        AudioSource audioSource = this.gameObject.AddComponent<AudioSource>();
        audioSource.volume *= volumeMutiplayer;
        audioSource.PlayOneShot((AudioClip)Resources.Load("Sounds/" + clipName,typeof(AudioClip)));
    }    
}
