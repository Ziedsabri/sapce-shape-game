using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firemenuscript : MonoBehaviour
{
    public planet pl;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position = new Vector3(pl.transform.position.x, pl.transform.position.y, pl.transform.position.z);
    }
}
