using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisBlock : MonoBehaviour                            //"TetrisBlock" MUST be renamed to whatever your script is called for the code to work!
{
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
        }
        
        else if(Input.GetKeyDown(KeyCode.RightArrow)) 
        {
            transform.position += new Vector3(1,0,0);
        }
    }
} 
