using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SceneLoaderTrigger : MonoBehaviour
{
    //Unless going to a specific scene, indicate "scene" variable as "Next" in the inspector view of this script
    public string scene;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.name == "Player")
            GameObject.Find("GameManager").GetComponent<SceneLoader>().triggered(scene);
        
    }

}