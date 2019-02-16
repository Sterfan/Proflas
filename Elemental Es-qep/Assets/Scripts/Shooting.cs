using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject Bulletprefab, Bulletprefab2;

    private float ShootingDelay = 0.35f;
    private float cooldownTimer = 1;
    public static int whichWeapon = 1;

    void Update()
    {
        cooldownTimer -= Time.deltaTime;

        if (Input.GetButton("Fire1") && cooldownTimer <= 0) 
        {
            cooldownTimer = ShootingDelay;
            Debug.Log("Pew!");

            GameObject bullet = (GameObject)Instantiate(Bulletprefab, transform.position, transform.rotation);
            
        }

    }


}
