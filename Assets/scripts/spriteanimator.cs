using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteanimator : MonoBehaviour
{
    public SpriteRenderer  myspriterenderer;
    public Sprite[] spritearray;
    private int currentframe;
    private float timer;
    public float framerate;
   
    void Start()
    {
        currentframe = 0;
        timer = 0;

    }

    void Update()
    {
        timer += 1 * Time.deltaTime;
        if (timer >= framerate)
        {
            myspriterenderer.sprite = spritearray[currentframe];
            currentframe++;
        }
       
        if( currentframe == spritearray.Length)
        {
            Destroy(gameObject);
        }
    }
}
