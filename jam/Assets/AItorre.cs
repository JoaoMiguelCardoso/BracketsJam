using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AItorre : MonoBehaviour
{
    public GameObject bala;

    float tempo;
    public float tempoEntreTiros;

    public Transform papai;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(tempo < Time.time)
        {
            Instantiate(bala,papai.position,papai.rotation);
            tempo = Time.time + tempoEntreTiros;
        }
    }
}
