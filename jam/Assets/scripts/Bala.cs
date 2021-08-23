using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public int dano;
    public float velocidade;
    Vector2 mousePos;
    public Camera cam;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        rb.velocity = transform.up * velocidade;
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
     if(other.gameObject.tag.Equals("Enemy"))
     {
         other.GetComponent<Life>().PerderVida(dano);
         Destroy(gameObject);
     }   
    }

}
