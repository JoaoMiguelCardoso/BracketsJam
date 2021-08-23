using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public int vidaTotal;
    [SerializeField]int vidaAtual;
    
    void Start()
    {
       vidaAtual = vidaTotal; 
    }
    public void PerderVida(int dano)
    {
        vidaAtual -= dano;
    }
}