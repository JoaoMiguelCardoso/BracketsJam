using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomsTemplete : MonoBehaviour
{
    public GameObject[] BottomRooms;
    public GameObject[] LeftRooms;
    public GameObject[] TopRooms;
    public GameObject[] RightRooms;

    public GameObject clossed;
    public List<GameObject> roomslist;

    public float waitTime;
    private bool bossvivo;
    [SerializeField]private GameObject boss;

    private void Update()
    {
        if(waitTime <= 0.1f && bossvivo == false){
            for (int i = 0; i < roomslist.Count; i++)
            {
                if(i ==  roomslist.Count - 1){
                    Instantiate(boss, roomslist[i].transform.position, Quaternion.identity);
                    bossvivo = true;
                }
            }
        }else{
            waitTime -= Time.deltaTime;
        }
    }
}
