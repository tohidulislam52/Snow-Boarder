using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerCrased : MonoBehaviour
{
    [SerializeField] ParticleSystem crasEffect;
    [SerializeField] AudioClip crashSFX;
    [SerializeField] float loadTime = .2f;
    bool stopeCrased =true;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ground" && stopeCrased)

        {
            stopeCrased =false;
            GetComponent<PlayerMovement>().CheckeMovement();
            crasEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("relodeScene", loadTime );
        }
    }
    void relodeScene ()
    {
        SceneManager.LoadScene(0);
    }

    
}
