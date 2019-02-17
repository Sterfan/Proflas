using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject[] bullets;

    private float ShootingDelay = 0.35f;
    private float cooldownTimer = 0.5f;
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
            cooldownTimer = ShootingDelay;
            Debug.Log("Pew!");
            
            Instantiate(bullets[currentBullet], transform.position, transform.rotation);

        }

    }
    


}
