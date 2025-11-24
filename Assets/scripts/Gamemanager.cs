using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public float gamespeed;
    public float speediincreasreasratio;
    public float limitscreen;
    
    public enum gamestate { gameplay, gameover }
    [HideInInspector] public gamestate gs;
    internal bool gameover;
    [HideInInspector] public int score;
    void Start()
    {
        
        gs = gamestate.gameplay;
        
    }

    void Update()
    {
        if (gs == gamestate.gameplay) {
            gamespeed += speediincreasreasratio * Time.deltaTime;
        }
        else if (gs==gamestate.gameover)
        {
            if(score > PlayerPrefs.GetFloat("SampleScene"))
            {
                PlayerPrefs.SetFloat("SampleScene", score);
                
            }
        }
        
       
    }
}