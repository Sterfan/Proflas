using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBullet : MonoBehaviour
{

    float deleteTime = 2.0f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        deleteTime -= Time.deltaTime;
        
        if (deleteTime <= 0)
        {
            Destroy(gameObject);
        }

    }
}
