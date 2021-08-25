using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee : MonoBehaviour
{
    public Transform papai;
    public float radius;
    public LayerMask balaInimigo;

    //public static int OverlapCircle(papai.position,radius,balaInimigo);
    Collider2D[] tiro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 a = Physics2D.OverlapCircle(papai.position,radius,balaInimigo);
       // foreach(Collider2D[] balas in Physics2D.OverlapCircle(papai.position,radius,balaInimigo))
        {

        }
    }
}
