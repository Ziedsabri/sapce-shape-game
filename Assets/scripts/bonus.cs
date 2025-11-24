using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bonus : MonoBehaviour
{
    public Gamemanager gm;
    public GameObject myprefab;
    public AudioClip bonussound;
    void Start()
    {
        transform.position = new Vector3(Random.Range(-gm.limitscreen, gm.limitscreen), 20, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -gm.gamespeed, 0), Space.World);
        transform.Rotate(new Vector3(0, 1, 0), Space.Self);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            gm.score++;
            gm.GetComponent<AudioSource>().PlayOneShot(bonussound);
            Destroystar(17);


        }
        if (other.gameObject.name == "Pit")
        {
            Destroystar(20);
        }
    }
    private void Destroystar(int ypos)
    {
        Instantiate(myprefab, new Vector3(Random.Range(-gm.limitscreen, gm.limitscreen), ypos, 0), myprefab.transform.rotation);
        Destroy(gameObject);
    }
}
