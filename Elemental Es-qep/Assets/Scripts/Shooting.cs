using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject Bulletprefab;
    private float ShootingDelay = 0.25f;
    private float cooldownTimer = 0;
    void Update()
    {
        cooldownTimer -= Time.deltaTime;

        if (Input.GetButton("Fire1") && cooldownTimer <= 0) 
        {
            cooldownTimer = ShootingDelay;
            Debug.Log("Pew!");

            GameObject bullet = (GameObject)Instantiate(Bulletprefab, transform.position, transform.rotation);
            bullet.layer = gameObject.layer;
        }
    }
}
