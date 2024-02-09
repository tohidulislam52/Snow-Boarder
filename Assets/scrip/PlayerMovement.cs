using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float torqueAmaunt=1;
    [SerializeField] float BoostSpeed= 30f;
    [SerializeField] float NormalSpeed= 20f;

    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;
           float onetime =0;
    bool collosPlayerMovement= true;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    

    void Update()
    { if(collosPlayerMovement == true)
        {
        PlayerRotate();
        PalyerBoost();
        }
 
        if(Input.GetKey(KeyCode.E) && onetime == 0)
        {
            onetime = 1;
            Application.Quit();
            Debug.Log("quit");
        }
    }

    public void CheckeMovement()
    {
        collosPlayerMovement = false;
    }

    void PalyerBoost()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = BoostSpeed;
        }
        else
        {
            surfaceEffector2D.speed = NormalSpeed;
        }
    }

    private void PlayerRotate()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rb2d.AddTorque(-torqueAmaunt);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb2d.AddTorque(torqueAmaunt);
        }
    }
}
