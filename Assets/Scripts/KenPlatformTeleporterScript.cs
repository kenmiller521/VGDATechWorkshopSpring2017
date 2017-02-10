using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KenPlatformTeleporterScript : MonoBehaviour {
	public int followDistance;
	public Transform playerTransform;
	public GameObject[] platformPositions;
	private Vector3 _newPos;
	private int _rand;
	// Use this for initialization
	void Start () {
		playerTransform = GameObject.Find ("Player").GetComponent<Transform> ();
		platformPositions = GameObject.FindGameObjectsWithTag ("PlatformPosition");
	}
	
	// Update is called once per frame
	void Update () 
	{
		_newPos = new Vector3 (playerTransform.position.x - followDistance, transform.position.y, 0);
		transform.position = _newPos;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Platform") 
		{
			Debug.Log ("Is a platform");
			_rand = Random.Range (0, platformPositions.Length);
			_newPos = platformPositions[_rand].transform.position;
			other.transform.position = _newPos;
			for (int i = 0; i < platformPositions.Length; i++) 
			{
				platformPositions [i].transform.position = new Vector3 (platformPositions [i].transform.position.x + 1.5f, platformPositions [i].transform.position.y, 0);
			}
		}
	}
}
