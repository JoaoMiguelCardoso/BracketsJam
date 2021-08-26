using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField]private int OpenningDirection;
    /* 
    1  ==> bottom door needed    
    2  ==> top door needed
    3  ==> left door needed
    4  ==> rigth door needed
    */
    private RoomsTemplete Rooms;
    private int Rand, bl, ll, tl, rl;
    private bool mane;
    private float tempo = 4f;

    private void Start()
    {
        Destroy(this.gameObject, tempo);
        Rooms = GameObject.FindGameObjectWithTag("rooms").GetComponent<RoomsTemplete>();
        if(Rooms != null){
            if(Rooms.BottomRooms != null){
                bl = Rooms.BottomRooms.Length;
            }
            if(Rooms.LeftRooms != null){
                ll = Rooms.LeftRooms.Length;
            }
            if(Rooms.TopRooms != null){
                tl = Rooms.TopRooms.Length;
            }
            if(Rooms.RightRooms != null){
                rl = Rooms.RightRooms.Length;
            }
        }
        Invoke("Spawn", 0.1f);
        //Debug.Log("ue");
    }

    void Spawn() {
        if(mane == false){
            if(OpenningDirection == 1){
                Rand = Random.Range(0, bl);
                Instantiate(Rooms.BottomRooms[Rand], transform.position, Rooms.BottomRooms[Rand].transform.rotation );
            }else if(OpenningDirection == 3){
                Rand = Random.Range(0, ll);
                Instantiate(Rooms.LeftRooms[Rand], transform.position, Rooms.LeftRooms[Rand].transform.rotation );
            }else if(OpenningDirection == 2){
                Rand = Random.Range(0, tl);
                Instantiate(Rooms.TopRooms[Rand], transform.position, Rooms.TopRooms[Rand].transform.rotation );
            }else if(OpenningDirection == 4){
                Rand = Random.Range(0, rl);
                Instantiate(Rooms.RightRooms[Rand], transform.position, Rooms.RightRooms[Rand].transform.rotation );
            }
            mane = true;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Spawnpoints" ){
            if(other.GetComponent<SpawnPoint>() != null){
                if(other.GetComponent<SpawnPoint>().mane == false && mane == false){
                    if(Rooms != null){
                        if(Rooms.clossed != null){
                            Instantiate(Rooms.clossed, transform.position, Quaternion.identity);
                            Destroy(this.gameObject);
                        }
                    }
                }
            }
            mane = true;
        }
    }


}
