using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingTrigger : MonoBehaviour
{
    public GameObject endingPanel;
    // Start is called before the first frame update
    void Start()
    {
        //endingPanel = GameObject.Find("Ending");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
            endingPanel.SetActive(true);

    }
}
