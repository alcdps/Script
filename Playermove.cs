using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{

    public Vector2 Speed = new Vector2(0.05f, 0.05f);

    private Rigidbody2D rigidbody2D;
    private Animator Anim;


    public void Start()
    {
        Anim = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame

    void Update()
    {
        if(Input.GetKeyDown("f"))
        {
            Anim.SetTrigger("Attack");
        }
    }

    void FixedUpdate()
    {
        Vector2 Position = transform.position;

        if (Input.GetKey("right"))
        {
            Anim.SetFloat("rotationx", 1f);
            Anim.SetFloat("rotationy", 0f);
            transform.Translate(Time.deltaTime, 0, 0);
            Position.x += Speed.x;
        }



        if (Input.GetKey("left"))
        {
            Anim.SetFloat("rotationx", -1f);
            Anim.SetFloat("rotationy", 0f);
            transform.Translate(-Time.deltaTime, 0, 0);
            Position.x -= Speed.x;
        }

        if (Input.GetKey("up"))
        {
            Anim.SetFloat("rotationx", 0f);
            Anim.SetFloat("rotationy", 1f);
            transform.Translate(0, Time.deltaTime, 0);
            Position.y += Speed.y;
        }


        if (Input.GetKey("down"))
        {
            Anim.SetFloat("rotationx", 0f);
            Anim.SetFloat("rotationy", -1f);
            transform.Translate(0, -Time.deltaTime, 0);
            Position.y -= Speed.y;
        }

        transform.position = Position;
    }
}
