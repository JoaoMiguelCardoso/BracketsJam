using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerifiBuraco : MonoBehaviour
{
    public bool Buraco;

    private void Start()
    {
       // Destroy(this.gameObject, 4f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Buraco"){
            Buraco = true;
        }
    }
}
