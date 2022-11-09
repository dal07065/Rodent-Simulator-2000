using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour
{
    public int cheeseCount;
    public Text cheeseCountText;

    //private Collider currentCollider;

    //public bool interactStatus;

    // Start is called before the first frame update
    void Start()
    {
        //interactStatus = false;
        cheeseCount = 0;

        //get = GetComponent<AudioSource>();
    }
    public void incrementCheeseCount()
    {
        cheeseCount = cheeseCount + 1;
        cheeseCountText.text = "" + cheeseCount;
    }
    public int getCheeseCount()
    {
        return cheeseCount;
    }
    /*
    void Update()
    {
        if (Input.GetKeyDown("E") && interactStatus)
        {
            //currentCollider.gameObject.InteractAction.interact();
        }
    }
    */
    /*
    private void OnTriggerEnter(Collider other)
    {
        currentCollider = other;
        /*
        if (currentCollider.gameObject.tag == "Cheese")
        {
            get.Play();
            cheeseCount = cheeseCount + 1;
            //other.gameObject.SetActive(false);
            Destroy(other.gameObject, 1f);
        }
        */
        /*
        else if(currentCollider.gameObject.tag == "Terrain")
        {
            Debug.Log("Cheese has collided with the Terrain!");
        }
        else if(currentCollider.gameObject.tag == "Door")
        {
            interactStatus = true;
            Debug.Log("Player has collided with the Door!");
        }
        */
}

