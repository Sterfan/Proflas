//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class EnemySight : MonoBehaviour
//{
//    [SerializeField]
//    private BossMeleeArm enemy;


//   void OnTriggerEnter2D(Collider2D other)
//    {
//        if (other.tag=="Player")
//        {
//            enemy.target = other.gameObject;
//            Debug.Log("EnemyInSight!");
//        }
//    }

//    void OnTriggerExit2D (Collider2D other)
//    {
//        if (other.tag == "Player")
//        {
//            enemy.target = null;
//        }
//    }

//}
