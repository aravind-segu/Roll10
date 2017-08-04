using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour {

    public GameObject shooterBase;
    public Vector3 movement = new Vector3(0.0f, 0.0f, 1);
    public int speed;
    public GameObject player;
    public Transform smallerSpheres;
    // Use this for initialization
    void Start () {
        gameObject.transform.position = new Vector3( shooterBase.transform.position.x,shooterBase.transform.position.y + 0.9f,shooterBase.transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
            transform.Translate(movement * speed * Time.deltaTime);
	}

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Bullets")
        {
            Physics.IgnoreCollision(gameObject.GetComponent<Collider>(), collision.gameObject.GetComponent<Collider>());
        }
        else if (collision.gameObject.name == "Player" || collision.gameObject.name == "Player Mirror")
        {
            Debug.Log("Collided");
            player.SetActive(false);
            smallerSpheres.gameObject.SetActive(true);
            smallerSpheres.gameObject.transform.position = player.gameObject.transform.position;
            foreach (Transform sphere in smallerSpheres)
            {
                Rigidbody rbSphere = sphere.gameObject.AddComponent<Rigidbody>();
                rbSphere.AddExplosionForce(10.0F, player.gameObject.transform.position, 5.0F, 3.0F);
            }
        }
        else
        {
            gameObject.transform.position = shooterBase.transform.position;
        }
        
    }
}
