using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DastEffect : MonoBehaviour
{
    [SerializeField] ParticleSystem particl;

    void OnCollisionEnter2D(Collision2D other) 
    {
        
        
        if(other.gameObject.tag == "Ground")
        {
            particl.Play();
        }
    }
    void OnCollisionExit2D(Collision2D other) 
    {
        if(other.gameObject.tag == "Ground")
        {
            particl.Stop();
        }
    }


    // [SerializeField] ParticleSystem dustParticles;

    // void OnCollisionEnter2D(Collision2D other) 
    // {
    //     if(other.gameObject.tag == "Ground")
    //     {
    //         dustParticles.Play();
    //     }
    // }
    

    // void OnCollisionExit2D(Collision2D other) 
    // {
    //     if(other.gameObject.tag == "Ground")
    //     {
    //         dustParticles.Stop();
    //     }
    // }

}
