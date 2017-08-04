using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController7 : MonoBehaviour {
    public GameObject player;
    private Vector3 offset;
    // Use this for initialization
    void Start()
    {
        //offset = transform.position - player.transform.position;
        offset = new Vector3(0,10,-10);
        transform.position = offset;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}