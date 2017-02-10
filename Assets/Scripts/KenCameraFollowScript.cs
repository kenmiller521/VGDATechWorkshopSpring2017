using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KenCameraFollowScript : MonoBehaviour {
	public Transform playerTransform;
	private Vector3 _newPos;
	// Use this for initialization
	void Start () {
		playerTransform = GameObject.Find ("Player").GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		_newPos = new Vector3 (playerTransform.position.x, playerTransform.position.y, -10);
		transform.position = _newPos;
	}
}
