using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud1 : MonoBehaviour {
    Rigidbody2D rb;
    public float speed = 1f ;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.velocity = transform.right * speed;

    }
}
