using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneWeapon : MonoBehaviour {
    float CharacterSpeed = 7f;

    Rigidbody2D rb;

    Blub target;

    Vector2 moveDirection;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<Blub>();
        moveDirection = (target.transform.position - transform.position).normalized * CharacterSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 1f);




	}
	
	// Update is called once per frame
	void OnTriggerEnter2d (Collider2D col)
    {
		if(col.gameObject.name.Equals("Blub"))
        {
            Debug.Log("Hit");
            Destroy(gameObject);
        }
	}
}
