using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorScript : MonoBehaviour {
    public int speed;
    public PlayerController playerScript;
    public GameObject player;

     void Start()
    {
        playerScript = player. GetComponent <PlayerController> ();
    }
    // Use this for initialization
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(-moveHorizontal, 0.0f, -moveVertical);
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            playerScript.count++;
            playerScript.setCountText();
        }
    }





}
