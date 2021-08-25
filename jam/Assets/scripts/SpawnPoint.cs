using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField]private int OpenningDirection;
    /* 
    1  ==> bottom door needed    
    2  ==> left door needed
    3  ==> top door needed
    4  ==> rigth door needed
    */

    private void Update() {
        switch (OpenningDirection)
        {
            case 1:
            break;
            case 2:
            break;
            case 3:
            break;
            case 4: 
            break;
            default:
                Debug.Log("ta loko?");
            break;
        }
    }
    
    


}
