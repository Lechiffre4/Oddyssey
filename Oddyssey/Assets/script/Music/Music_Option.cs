using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class Music_Option : MonoBehaviour
{
    public AudioMixer mixer;

    public void SetVolume(float slidervalue) 
    {
        mixer.SetFloat("Music", Mathf.Log10(slidervalue) *20);
    }

}
