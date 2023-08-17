using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSrc;
    public AudioClip die;
    public AudioClip hit;
    public AudioClip point;
    public AudioClip wing;

    public void HitSFX(){
        audioSrc.PlayOneShot(hit);
        audioSrc.PlayOneShot(die);
    }

    public void PointSFX(){
        audioSrc.PlayOneShot(point);
    }

    public void WingSFX(){
        audioSrc.PlayOneShot(wing);
    }
}
