using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{   
    Transform actualPosition;    // Add data type for t variable
    



    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<Transform>();                      // Get Transform component on GameObject
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
    }

}
