using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class HitScan : MonoBehaviour {
    void OnCollisionEnter2D (Collision2D col)
    {
        Debug.Log("Hit!");
    }
}