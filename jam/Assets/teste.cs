using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other != null){
            Debug.Log("vaii");
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other != null){
            Debug.Log("é");
        }
    }
}
