using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EricPlayerScript : MonoBehaviour {
    
    //used to find component
    public Rigidbody2D rb2d;
    public int jumpStrength;

	// Use this for initialization
	void Start () {
        //gets and assigns object
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        //Vector2.right finds 1 in x 0 in y
        //means force will be added to the player continuously in the right direction
        rb2d.AddForce(Vector2.right);

        //looks for input in the keyboard keycode specifically for the space key
        if (Input.GetKeyDown(KeyCode.Space)){
            //adds force in the y direction (simulates a jump)
            //Vector2.direction only adds one in the direction axis
            //multiplying the value adds power
            rb2d.AddForce(Vector2.up * jumpStrength);
        }
	}
}
