using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindmillRotate : MonoBehaviour {
    public GameObject center;
    public int speed;
	// Update is called once per frame
	void Update () {
        transform.RotateAround(center.transform.position, Vector3.up, 20 * speed * Time.deltaTime);
	}
}
