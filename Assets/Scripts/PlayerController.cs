using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    private Rigidbody rb;
    public float speed;
    public int count;
    public Text countText;
    public GameObject finishDisk;
    public GameObject blueDoor;
    public GameObject redDoor;
    private int maxCount;
    public bool finished = false;
    public GameObject LateStartWall;
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "MiniGame")
        {
            maxCount = 12;
        }
        if (scene.name == "Level 2")
        {
            maxCount = 10;
        }
        if (scene.name == "Level 3")
        {
            maxCount = 10;
        }
        if (scene.name == "Level 4")
        {
            maxCount = 10;
        }
        if (scene.name == "Level 5")
        {
            maxCount = 8;
        }
        if (scene.name == "Level 6")
        {
            maxCount = 10;
        }
        if (scene.name == "Level 7")
        {
            maxCount = 10;
        }
        rb = GetComponent<Rigidbody>();
        count = 0;
        setCountText();
        finishDisk.SetActive(false);
        if (scene.name == "Level 2")
        {
            LateStartWall.SetActive(false);
        }
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        
        rb.AddForce(movement * speed);
        if (count >= maxCount)
        {
            Vector3 portalPosition = finishDisk.transform.position;
            Vector3 playerPosition = gameObject.transform.position;
            Debug.Log(Vector3.Distance(portalPosition, playerPosition));
            if (Vector3.Distance(portalPosition, playerPosition) <= 0.7)
            {
                countText.text = "You Won";
                rb.velocity = Vector3.zero;
            }

        }
        Scene scene = SceneManager.GetActiveScene();
       
        

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count++;
            setCountText();
        }
    }

   
    public void setCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= maxCount) { 

            finished = true;
            finishDisk.SetActive(true);
            LateStartWall.SetActive(true);
        }
    }
}
