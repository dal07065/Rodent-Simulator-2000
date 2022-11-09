using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractAction : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Within InteractAction");
        if(Input.GetKeyDown(KeyCode.E)) //"e" = KeyCode.E
            anim.SetTrigger("OpenClose");
    }

    void interactAction()
    {

    }
}
