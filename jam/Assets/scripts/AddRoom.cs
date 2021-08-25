using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRoom : MonoBehaviour
{
    private RoomsTemplete templete;
    void Start()
    {
        templete = GameObject.FindGameObjectWithTag("rooms").GetComponent<RoomsTemplete>();
        templete.roomslist.Add(this.gameObject);
    }
}
