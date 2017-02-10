using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubenCameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    private Vector3 newPosition;

	// Use this for initialization
	void Start ()
    {
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        newPosition = new Vector3(playerTransform.position.x, playerTransform.transform.position.y, -10);
        transform.position = newPosition;
	}
}
