using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KamikazeEnemyAi : MonoBehaviour
{
    public float moveSpeed= 4f;
    
    public Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        
    }


    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
    }
 }