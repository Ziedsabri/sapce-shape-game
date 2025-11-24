using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planet : MonoBehaviour
{
    public Animator anim;
    public lightscript lightrot;
    
    // Start is called before the first frame update
    void Start()
    {
        lightrot.a = transform.rotation.x;
       anim.enabled =false;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (lightrot.a<-3 || lightrot.a>190)
        {
            
            anim.enabled = true;
           
            

        }
        
        
    }
}
