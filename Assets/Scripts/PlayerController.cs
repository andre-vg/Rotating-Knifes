using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Range(1f, 10.0f)]
    public float playerSpeed = 5f;

    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            transform.Translate(Vector2.up * Time.deltaTime * playerSpeed);
        }
        if(Input.GetKey(KeyCode.S)){
            transform.Translate(Vector2.down * Time.deltaTime * playerSpeed);
        }
        if(Input.GetKey(KeyCode.A)){
            transform.Translate(Vector2.left * Time.deltaTime * playerSpeed);
        }
        if(Input.GetKey(KeyCode.D)){
            transform.Translate(Vector2.right * Time.deltaTime * playerSpeed);
        }        
    }
    
}
