using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;
    public AudioMixerGroup audioMixerGroup;
    void Start()
    {
        audioSource.outputAudioMixerGroup = audioMixerGroup;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
