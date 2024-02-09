using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinisLine : MonoBehaviour
{
    [SerializeField] ParticleSystem finisline;

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            finisline.Play();
            GetComponent<AudioSource>().Play();
            Invoke("relodeScene",1f);
        }
    }

    void relodeScene()
    {
        SceneManager.LoadScene(0);
    }

}
