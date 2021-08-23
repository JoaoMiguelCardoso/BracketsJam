using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaInimigo : MonoBehaviour
{
     public int dano;
    public float velocidade;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
    rb = GetComponent<Rigidbody2D>();
    rb.velocity = transform.up * velocidade;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        private void OnTriggerEnter2D(Collider2D other) 
    {
     if(other.gameObject.tag.Equals("Player"))
     {
         other.GetComponent<Life>().PerderVida(dano);
         Destroy(gameObject);
     }   
    }
}
