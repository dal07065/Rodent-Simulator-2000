using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public GameObject ui;

    void Start()
    {
        ui = GameObject.Find("Canvas");
        //DontDestroyOnLoad(this.gameObject);
        //DontDestroyOnLoad(ui);

    }

    // Update is called once per frame
    public void triggered(string scene)
    {
        StartCoroutine(LoadScene(scene));
    }

    IEnumerator LoadScene(string scene)
    {
        ui.GetComponentInChildren<Animator>().SetBool("FadeBlack", true);
        yield return new WaitForSeconds(1.5f);
        if (scene == "Next")
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        else
            SceneManager.LoadScene(scene);
        //ui.GetComponentInChildren<Animator>().SetBool("FadeBlack", false);
        //Cursor.lockState = CursorLockMode.None;
    }
}
