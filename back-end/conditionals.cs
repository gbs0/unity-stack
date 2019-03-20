using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{   
    void Start()
    {
        myTransform = Component.GetComponent<Transform>();
    }

    void Update()
    {                                                           
        // For Controls
        if (Input.GetKey(KeyCode.RightArrow)) {
            // Do something
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            // Do something
        }

        if (Input.GetKey(KeyCode.UpArrow)) {
            // Do something
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            // Do something
        }

        // For GameObject Transform
        if (myTransform.position.x < -10) 
        {
            // Do something
        }


    }

}
