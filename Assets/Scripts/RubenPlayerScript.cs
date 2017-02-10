using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubenPlayerScript : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public int jumpStrength;
    

	// Use this for initialization
	void Start ()
    {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        rb2d.AddForce(Vector2.right);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.AddForce(Vector2.up * jumpStrength);
        }
	}
}
