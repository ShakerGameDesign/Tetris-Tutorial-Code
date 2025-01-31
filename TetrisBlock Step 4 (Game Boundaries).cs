﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisBlock : MonoBehaviour                                //"TetrisBlock" MUST be renamed to whatever your script is called for the code to work!
{
    private float previousTime;
    public float fallTime = 0.8f;
    public static int height = 20;
    public static int width = 10;

    //Start is called before the first frame update
    void start()
    {
    
    }

    // Update is called once per frame
    void Update() 
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow)) 
        {
            transform.position += new Vector3(-1,0,0);
            if(!ValidMove())
                transform.position -= new Vector3(-1,0,0);
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow)) 
        {
            transform.position += new Vector3(1,0,0);
            if (!ValidMove())
                transform.position -= new Vector3(1,0,0);
        }


        if(Time.time - previousTime > (Input.GetKey(KeyCode.DownArrow) ? fallTime / 10 : fallTime))
        {
            transform.position += new Vector3(0, -1,  0);
            if (!ValidMove())
                transform.position -= new Vector3(0, -1,  0);
            previousTime = Time.time;
        }
    }

    bool ValidMove()
    {
        foreach (Transform children in transform)
        {
            int roundedX = Mathf.RoundToInt(children.transform.position.x);
            int roundedY = Mathf.RoundToInt(children.transform.position.y);

            if(roundedX < 0 || roundedX >= width || roundedY < 0 ||roundedY >= height)
            {
                return false;
            }
        }

        return true;
    }
} 
