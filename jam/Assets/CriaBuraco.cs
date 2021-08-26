using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriaBuraco : MonoBehaviour
{
    [SerializeField]private GameObject[] ParedesAdicionais;
    [SerializeField]private GameObject[] VerificaBuracos;
    [SerializeField]private GameObject[] ParedesNormais;
    [SerializeField]private string tipo;
    /*
        1 == bootom;
        2 == top;
        3 == left;
        4 == right;
    */
    private void Update()
    {
        Tiposala();
    }
    private void Veri(int i){
        i = i -1;
        if(VerificaBuracos[i] != null){
            if(VerificaBuracos[i].GetComponent<VerifiBuraco>() != null){
                if(VerificaBuracos[i].GetComponent<VerifiBuraco>().Buraco == true){
                    ParedesAdicionais[i].SetActive(true);
                    ParedesNormais[i].SetActive(false);
                }
            }
        }
    }
    private void Tiposala(){
        switch (tipo)
        {
            case "B":
                Veri(2);
                Veri(3);
                Veri(4);
            break;
            case "T":
                Veri(1);
                Veri(3);
                Veri(4);
            break;
            case "L":
                Veri(1);
                Veri(2);
                Veri(4);
            break;
            case "R":
                Veri(1);
                Veri(2);
                Veri(3);
            break;
            case "LR":
                Veri(1);
                Veri(2);
            break;
            case "LT":
                Veri(1);
                Veri(4);
            break;
            case "LB":
                Veri(4);
                Veri(2);
            break;
            case "TR":
                Veri(1);
                Veri(3);
            break;
            case "TB":
                Veri(3);
                Veri(4);
            break;
            case "RB":
                Veri(3);
                Veri(2);
            break;
            case "LRT":
                Veri(1);
            break;
            case "LTB":
                Veri(4);
            break;
            case "LRB":
                Veri(2);
            break;
            case "TRB":
                Veri(1);
            break;
            default:
            break;
        }
    }
}
