using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgmenuscript : MonoBehaviour
{ 
 

void Start()
{
    
}


void Update()
{
   
        transform.Translate(new Vector3(-0.3f, 0, 0));
        if (transform.position.x <= -12f)
        {
            transform.position = new Vector3(20, -2, 2);
        }
        



}

}
