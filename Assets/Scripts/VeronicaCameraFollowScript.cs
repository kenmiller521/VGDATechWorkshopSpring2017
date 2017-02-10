using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeronicaCameraFollowScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
