using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemy : MonoBehaviour
{
    public GameObject Bulletprefab;
    private float ShootingDelay = 0.8f;
    private float cooldownTimer = 1;
    void Update()
    {
        cooldownTimer -= Time.deltaTime;

        if (cooldownTimer <= 0)
        {
            cooldownTimer = ShootingDelay;
            Debug.Log("Pew!");

            GameObject bullet = (GameObject)Instantiate(Bulletprefab, transform.position, transform.rotation);
            bullet.layer = gameObject.layer;
        }
    }
}
