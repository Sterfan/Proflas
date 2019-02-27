﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HPManagerWaterEnemy : MonoBehaviour
{
    public int maxHealth = 8;
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
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Windbullet")
        {
            currentHealth--;
        }
        else
        {
            currentHealth--;
        }
    }
    public void TakingDamage(int damagetaken)
    {
        currentHealth -= damagetaken;
    }
}