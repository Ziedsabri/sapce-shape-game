using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Planetbehaviour : MonoBehaviour
{
    public Gamemanager mgp;
    public Gamemanager gml;
    public Texture[] planettextures= new Texture[4];
    public Renderer myrenderer;
    public Renderer myspaceshiprenderer;
    public AudioClip explosion;
    int i;
    
    void Start()
    {
        ResetPlanet(15);
        for (i = 0; i <= 2; i++)
        {
            myspaceshiprenderer.transform.GetChild(i).gameObject.SetActive(true);
        }
        myspaceshiprenderer.transform.GetChild(3).gameObject.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0,-mgp.gamespeed, 0), Space.World);
        transform.Rotate(new Vector3(0, 1, 0), Space.Self);
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.name == "Pit")
        {
            ResetPlanet(12);
            gml.score++;
        }
        if(other.gameObject.tag=="Player")
        {
            gml.gs = Gamemanager.gamestate.gameover;
            gml.gamespeed = 0;
            gml.GetComponent<AudioSource>().Stop();
            gml.GetComponent<AudioSource>().PlayOneShot(explosion);
            myspaceshiprenderer.enabled = false;
            for (i = 0; i <= 2; i++)
            {
                myspaceshiprenderer.transform.GetChild(i).gameObject.SetActive(false);
            }
            myspaceshiprenderer.transform.GetChild(3).gameObject.SetActive(true);




        }
    }
    private void ResetPlanet(float ypos)
    {
        transform.position = new Vector3(Random.Range(-gml.limitscreen, gml.limitscreen), ypos, 0);
        transform.rotation = Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));
        myrenderer.material.SetTexture("_MainTex", planettextures[Random.Range(0, 3)]);

    }
}
