using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManagerPlayer : MonoBehaviour
{

    public int maxHealth = 20;
    public int currentHealth;
    public Slider healthBar;

    void Start()
    {
        currentHealth = maxHealth;
    }


    void Update()
    {
        healthBar.value = currentHealth;

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            Application.LoadLevel(Application.loadedLevel);
        }
    }
     void OnTriggerEnter2D()
    {
        Debug.Log("Player Health -1");

        currentHealth--;
        //if (other.gameObject.tag == "Earthbullet")
        //{
        //    currentHealth--;
        //}

    }
    //public void TakingDamage(int damagetaken)
    //{
    //    currentHealth -= damagetaken;
    //}
}
