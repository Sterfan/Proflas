﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 5f;

    private Transform player;
    private Vector2 Target;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        Target = new Vector2(player.position.x, player.position.y);
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Target, speed * Time.deltaTime);
    }
}
