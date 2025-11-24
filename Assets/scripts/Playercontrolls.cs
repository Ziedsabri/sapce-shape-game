using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontrolls : MonoBehaviour
{
    public float playerspeed;
    public Gamemanager gml;
    public float deadangle;
    void Start()
    {


    }

    void Update()
    {
        #region pc control
        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveright();
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveleft();
        }
        #endregion
        #region mobilecontrol
        if (Input.acceleration.x> deadangle)
        {
            moveright();
        }
        if (Input.acceleration.x < -deadangle)
        {
            moveleft();
        }
        #endregion
    }
    private void moveright()
    {
        if ((transform.position.x < gml.limitscreen ) && (gml.gs == Gamemanager.gamestate.gameplay))
        {
            transform.Translate(new Vector3(playerspeed, 0, 0),Space.World);
            transform.Rotate(0, 0.4f, 0,Space.Self);
        }
    }
    private void moveleft()
    {
        if ((transform.position.x > -gml.limitscreen ) && (gml.gs == Gamemanager.gamestate.gameplay))
        {
            transform.Translate(new Vector3(-playerspeed, 0, 0),Space.World);
            transform.Rotate(0, -0.4f, 0, Space.Self);

        }
    }   
}
