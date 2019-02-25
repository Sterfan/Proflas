﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject[] bullets;

    private float shootingDelay = 0.55f;
    private float cooldownTimer = 0.6f;
    public  int currentBullet = 0;
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            ++currentBullet;

            if (currentBullet+1 > bullets.Length)
            {
                currentBullet = 0;
            }
        }
        

        cooldownTimer -= Time.deltaTime;

        if (Input.GetButton("Fire1") && cooldownTimer <= 0) 
        {
            cooldownTimer = shootingDelay;
            Debug.Log("Pew!");
            
            Instantiate(bullets[currentBullet], transform.position, transform.rotation);

        }
    }
}
