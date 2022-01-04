using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    //public AudioSource audioUI;
    
    

    void Start()
    {
        //audioUI = GetComponent<AudioSource>();
    }

    public void SceneMove(int sceneId)
    {
        //audioUI.Play();
        SceneManager.LoadScene(sceneId);
        
    }


    public void Quit()
    {
        Application.Quit();
    }
}
