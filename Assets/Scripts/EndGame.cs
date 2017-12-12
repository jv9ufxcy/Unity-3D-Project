using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour, IActivatable
{

    [SerializeField]
    string sceneToLoad;

    public string NameText
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    void IActivatable.DoActivate()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    //private void DoActivate()
    //{
       
    //}
    

    //private void OnTriggerStay2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag == "Player")
    //    {
            
    //    }
    //}
}
