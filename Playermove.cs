using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour {

    public float Speed = 5f;

    private Rigidbody2D rigidbody2D;
    private Animator anim;


    public void Start()
    {
        anim = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    public void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");

        if(x!=0)
        {
            rigidbody2D.velocity = new Vector2(x * Speed, rigidbody2D.velocity.y);
            Vector2 temp = transform.localScale;
            temp.x = -x;
            transform.localScale = temp;
            anim.SetBool("Moveleft", true);

        }
        else
        {
            rigidbody2D.velocity = new Vector2(0, rigidbody2D.velocity.y);
            anim.SetBool("Moveleft", false);
        }

        float y = Input.GetAxisRaw("Vertical");
        if (y != 0)
        {
            anim.SetBool("Movedown",true);
            anim.SetBool("Moveup", false);
        }
        else
        {
            anim.SetBool("Moveup", true);
            anim.SetBool("Movedown", false);
        }

        Vector2 direction = new Vector2(x, y).normalized;

        GetComponent<Rigidbody2D>().velocity = direction * Speed;
    }
}
