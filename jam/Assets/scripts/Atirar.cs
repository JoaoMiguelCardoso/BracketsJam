using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atirar : MonoBehaviour
{
    public GameObject[] bala;
    public float[] tempoEntreTiros;
    float tempo;

    [Header("Troca de Arma")]
    [SerializeField]int arma;
    public float tempoTrocaDeArma;
    float tempoArma;

    // Start is called before the first frame update
    void Start()
    {
        arma = 0;
        tempo = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && tempo < Time.time)
        {
            Instantiate(bala[arma],this.transform.position,this.transform.rotation);
            tempo = Time.time + tempoEntreTiros[arma];
        }

        if(Input.GetKeyDown(KeyCode.Q) && tempoArma < Time.time)
        {
            arma += 1;
            if(arma >= bala.Length) arma = 0;
        }
    }
}
