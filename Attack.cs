using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

    private GameObject Player;
    public int speed = 10;

	// Use this for initialization
	void Start () {
        Player = GameObject.FindWithTag("Player");
        Rigidbody2D rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = new Vector2(speed * Player.transform.localScale.x, rigidbody2D.velocity.y);
        Destroy(gameObject, 0.5f);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
