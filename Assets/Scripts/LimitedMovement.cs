using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitedMovement : MonoBehaviour
{
    public Vector3 movement = new Vector3(0.0f, 0.0f, 1);
    public Vector3 finalPosition = new Vector3(0.0f, 0.0f,1.0f);
    public float speed;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(movement * speed * Time.deltaTime);
        Debug.Log(Vector3.Distance(gameObject.transform.position, finalPosition));

        if (Vector3.Distance(gameObject.transform.position, finalPosition) <= 0.06)
        {
            Debug.Log("entered");
            movement.x = movement.x * -1;
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