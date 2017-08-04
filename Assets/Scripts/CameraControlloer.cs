using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlloer : MonoBehaviour {
    public GameObject player;
    private Vector3 offset;
	// Use this for initialization
	void Start () {
        //offset = transform.position - player.transform.position;
        float vectorX = player.transform.position.x;
        float vectorY = player.transform.position.y + 10;
        float vectorZ = player.transform.position.z - 10;
        offset = new Vector3(vectorX, vectorY, vectorZ);
        transform.position = player.transform.position + offset;
    }
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
}
