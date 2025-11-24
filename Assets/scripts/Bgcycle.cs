using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bgcycle : MonoBehaviour
{
    public Gamemanager gm;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(new Vector3(0, -gm.gamespeed, 0));  
        if (transform.position.y <= -20)
        {
            transform.position = new Vector3(0,20, 2);  
        }
        RenderSettings.skybox.SetFloat("_Rotation", Time.time*gm.gamespeed*100);
    }
}

