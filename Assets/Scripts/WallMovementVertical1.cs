using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WallMovementVertical1 : MonoBehaviour
{
    public Vector3 movement = new Vector3(0.0f,0.0f,1);
    public float speed;
    // Update is called once per frame
 
    void Update()
    {
            transform.Translate(movement * speed * Time.deltaTime);
        if (gameObject.transform.position.x < -0.7 & gameObject.transform.position.x > -0.75)
        {
            Debug.Log("Entered Speed");
            speed = 0.0f;
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY|RigidbodyConstraints.FreezePositionZ|
                            RigidbodyConstraints.FreezeRotation;
            }
        
        
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        Debug.Log(collision.gameObject.name != "Player");
        if (collision.gameObject.name != "Player")
        {
            Debug.Log("entered");
            movement.x = movement.x * -1;
        }
    }
}
