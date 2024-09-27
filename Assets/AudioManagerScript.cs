using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{

    public AudioSource SFX;

    public AudioClip good;
    public AudioClip bad;


   public void Success()
    {

        SFX.clip = good;
        SFX.Play();
        
    }

    public void Failure()
    {

        SFX.clip = bad;
        SFX.Play();

    }


}
