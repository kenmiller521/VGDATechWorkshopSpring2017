using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EricPlatformTeleporterScript : MonoBehaviour {
    public int followDistance;
    public Transform playerTransform;
    //holds platform position
    public GameObject[] platformPositions;
    //to get off the player set offset
    private Vector3 _newPos;
    //to make random numbers, will be used to choose random platform position
    private int _rand;

	// Use this for initialization
	void Start () {
        //finds player and sets transform component
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();

        //goes through heirarchy to find the objects with tag "PlatformPosition"
        platformPositions = GameObject.FindGameObjectsWithTag("PlatformPosition");	
	}
	
	// Update is called once per frame
	void Update () {
        //position uses vector3
        _newPos = new Vector3(playerTransform.position.x - followDistance, transform.position.y, 0);
        transform.position = _newPos;
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Platform")
        {
            Debug.Log("Is a platform");
            _rand = Random.Range(0, platformPositions.Length);
            _newPos = platformPositions[_rand].transform.position;

            other.transform.position = _newPos;
            for(int i = 0; i < platformPositions.Length; i++)
            {
                platformPositions[i].transform.position = new Vector3(platformPositions[i].transform.position.x+1.5f, platformPositions[i].transform.position.y, 0);

            }
        }
    }
}
