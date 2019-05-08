using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{   
    Transform actualPosition;    // Add data type for t variable

    public float speed;

    
    // Start is called before the first frame update
    void Start()
    {
        actualPosition = GetComponent<Transform>();                      // Get Transform component on GameObject
    }

    // Update is called once per frame
    void Update()
    {                                                           
        float moveHorizontal  = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float moveVertical = Input.GetAxis("Vertical") * Time.deltaTime * speed; 
        gameObject.transform.Translate(moveHorizontal, moveVertical, 0);

    }

}
