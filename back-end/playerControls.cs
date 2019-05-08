using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{   
    Transform actualPosition;    // Add data type for t variable

    // Start is called before the first frame update
    void Start()
    {
        actualPosition = GetComponent<Transform>();                      // Get Transform component on GameObject
    }

    // Update is called once per frame
    void Update()
    {                                                           
        // transform.position = new Vector3();              // Get a new Instance of position using Vector3
        if (Input.GetKey(KeyCode.RightArrow)) {
            actualPosition.Translate(0.1f, 0, 0);                        // Add new translates for x axis
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            actualPosition.Translate(-0.1f, 0, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow)) {
            actualPosition.Translate(0, 0.1f, 0);
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            actualPosition.Translate(0, -0.1f, 0);
        }

        if (Input.GetMouseButton (0)) }
            playerFire();
        }
        
        if (Input.GetMouseButton (0) && //some other condition
        ) {
            /// Do something
        }
        
        Vector3 newPosition = actualPosition.position;
        // if (actualPosition.x > 2.9f) actualPosition.x = 2.9f;
        // if (actualPosition.x < -2.9f) actualPosition.x = -2.9f;
        newPosition.x = Mathf.Clamp(newPosition.x, -2.9f, 2.9f);  //One line statement
        transform.position = newPosition;

        // Or we can move the player using gameObject and Transform properties
        gameObject.transform.Translate(moveHorizontal, moveVertical, 0);
        
    }

}
