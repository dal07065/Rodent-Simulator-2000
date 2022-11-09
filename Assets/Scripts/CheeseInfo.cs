using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseInfo : MonoBehaviour
{
    //public PlayerInfo playerInfo;
    public AudioSource get;
    public string currentCollider;

    // Start is called before the first frame update
    void Start()
    {
        get = GetComponent<AudioSource>();
        currentCollider = "None";
    }

    void OnTriggerEnter(Collider other)
    {
        currentCollider = other.gameObject.tag;
        if (currentCollider == "Player")
        {
            gameObject.GetComponentInChildren<SkinnedMeshRenderer>().enabled = false;
            get.Play();
            GameObject.Find("GameManager").GetComponent<PlayerInfo>().incrementCheeseCount();
            //other.gameObject.SetActive(false);
            Destroy(this.gameObject, 1f);
        }
        /*
        if (currentCollider == "Player")
        {
            get.Play();
            playerInfo.cheeseCount += 1;
            gameObject.active = false;
        }
        else if (currentCollider == "Terrain")
        {
            Debug.Log("Cheese has collided with the Terrain!");
        }
        */
    }

    public string getCurrentCollider()
    {
        return currentCollider;
    }
}
