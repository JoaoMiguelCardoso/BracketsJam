using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizontal,vertical;
    public float velocidade;
    public float hori,verti;
    public Vector2 mousePos;
    public Camera cam;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
      //  Movimento();
    }

    private void FixedUpdate() 
    {
        Movimento();
    }

    void Movimento()
    {
        if(horizontal > 0)hori = 1;
        else if(horizontal < 0)hori = -1;
        else hori = 0;

        if(vertical > 0)verti = 1;
        else if(vertical < 0)verti = -1;
        else verti = 0;

        Vector2 movi = new Vector2(hori,verti);

        transform.Translate(movi * velocidade,Space.World);


        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
