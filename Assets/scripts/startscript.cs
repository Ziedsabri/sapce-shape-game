using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startscript : MonoBehaviour
{
    public Button startbutton;

    void Start()
    {
        
    }


    void Update()
    {
        
    }
    public void Reloadscene()
    {
        SceneManager.LoadScene("SampleScene");

    }
}
