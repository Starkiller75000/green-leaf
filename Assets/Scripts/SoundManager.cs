using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource[] Noise;
    
    public void PlayRandomDestroyNoise() {
        int clipToplay = Random.Range(0, Noise.Length);
        Noise[clipToplay].Play();
    }
}
