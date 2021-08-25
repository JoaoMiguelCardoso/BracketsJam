using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class AIInimigoBasico : MonoBehaviour
{
    public float velocidade;
    Rigidbody2D rb;
    public Transform Player;
    Vector2 jogador;
    public float distanceFromPlayer,minimumAttackDistancePlayer,lineOfSite,lineOfSiteLimit;
    [Header("Tiro")]
    public GameObject bala;

    public float tempoEntreTiros;
    float tempoTiros;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }

    void FixedUpdate()
    {
        distanceFromPlayer = Vector2.Distance(Player.position,transform.position);

        Vector2 lookDir = (Vector2)Player.position - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        if(distanceFromPlayer < lineOfSite && distanceFromPlayer > lineOfSiteLimit)
        {
            rb.rotation = angle;

            GetComponent<AIPath>().canMove = true;
        }
        else if(distanceFromPlayer < lineOfSiteLimit)
        {
            rb.rotation = angle;
            rb.position = Vector2.MoveTowards(transform.position,Player.position,-velocidade * Time.deltaTime);
        }
        else if(distanceFromPlayer > lineOfSite)GetComponent<AIPath>().canMove = false;
        if(distanceFromPlayer < minimumAttackDistancePlayer && tempoTiros <Time.time)
        {
            rb.rotation = angle;
            Instantiate(bala,GetComponentInChildren<Transform>().position,transform.rotation);
            tempoTiros = Time.time + tempoEntreTiros;
        }

    } 

    private void OnDrawGizmosSelected() {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(transform.position,lineOfSite);
        Gizmos.DrawSphere(transform.position,minimumAttackDistancePlayer);
        Gizmos.DrawSphere(transform.position,lineOfSiteLimit);
    }
}
