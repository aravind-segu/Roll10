using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour {
    public GameObject otherDoor;
    void OnCollisionEnter(Collision collision)
    {
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 newPosition = new Vector3(0.0f,0.0f,0.0f);
        if (collision.gameObject.name == "Player")
        {
            Vector3 bluePosition = otherDoor.transform.position;
            if (moveVertical < 0)
            {
                 newPosition = new Vector3(bluePosition.x, 0.5f, (bluePosition.z - 1.5f));
            }
            else
            {
                newPosition = new Vector3(bluePosition.x, 0.5f, (bluePosition.z + 0.3f));
            }
            collision.gameObject.transform.position = newPosition;
        }
    }
}
