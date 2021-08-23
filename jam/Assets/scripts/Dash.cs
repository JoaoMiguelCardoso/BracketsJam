using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    Rigidbody2D rb;
    public float velocidade;
    public float timeDashing;
    float tempo;
    public float tempoEntreDash;

    public GameObject bala;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift) && tempo < Time.time)
        {
            Dashh();
            tempo = Time.time + tempoEntreDash;
        }
    }

    void Dashh()
    {
        Vector2 direction = new Vector2(GetComponent<PlayerMovement>().hori,GetComponent<PlayerMovement>().verti);
        if(GetComponent<PlayerMovement>().hori != 0 && GetComponent<PlayerMovement>().hori != 0){
        rb.velocity = direction * velocidade;
        }
        else
        {
            rb.velocity = transform.up * velocidade;
        }
        StartCoroutine("dash");
    }

    IEnumerator dash()
    {
        GetComponent<PlayerMovement>().enabled = false;
        yield return new WaitForSeconds(timeDashing);
        GetComponent<PlayerMovement>().enabled = true;
        rb.velocity = Vector2.zero;
        AtaqueArea();
    }

    void AtaqueArea()
    {
        Instantiate(bala,transform.position,Quaternion.identity);
    }


}
