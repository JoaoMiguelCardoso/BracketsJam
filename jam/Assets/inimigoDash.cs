using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigoDash : MonoBehaviour
{
    public float velocidade;
    Rigidbody2D rb;
    public Transform Player;
    Vector2 jogador;
    bool carregar;
    public float distanceFromPlayer,minimumAttackDistancePlayer,lineOfSite,lineOfSiteLimit;
float tempo;
    public float tempoEntreDash;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
        void FixedUpdate()
    {
        distanceFromPlayer = Vector2.Distance(Player.position,transform.position);

        Vector2 lookDir = (Vector2)Player.position - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        if(distanceFromPlayer < lineOfSite)
        {
            rb.rotation = angle;
            carregar = true;

           // rb.position = Vector2.MoveTowards(transform.position,Player.position,velocidade * Time.deltaTime);
        }

        if(carregar)
        {
            if(tempo < Time.time)
            {
            rb.velocity = transform.up * velocidade;
            tempo = Time.time + tempoEntreDash;
            carregar = false;
            }
        }
    } 
}
