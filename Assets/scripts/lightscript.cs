using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightscript : MonoBehaviour
{
    
    public float a=0;
   
    void Start()
    {
        a = 30;
    }

    
    void Update()
    {
        a +=0.5f;
        transform.rotation = Quaternion.Euler(a,-30, 0);
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        


    }
}
