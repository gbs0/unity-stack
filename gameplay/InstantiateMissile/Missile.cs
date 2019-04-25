using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour
{
    // Instantiate a rigidbody then set the velocity

    Rigidbody projectile;

    void Update()
    {
        // Ctrl was pressed, launch a projectile
        if (Input.GetButtonDown("Fire1"))
        {
            // Instantiate the projectile at the position and rotation of this transform
            Rigidbody clone;
            clone = Instantiate(projectile, transform.position, transform.rotation);

            // Give the cloned object an initial velocity along the current
            // object's Z axis
            clone.velocity = transform.TransformDirection(Vector3.forward * 10);
        }
    }
}

// Instantiate can also clone script instances directly. 
// The entire game object hierarchy will be cloned and the cloned script instance will be returned.

using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour
{
    public int timeoutDestructor;

    // ...other code...
}


public class ExampleClass : MonoBehaviour
{
    // Instantiate a Prefab with an attached Missile script
    public Missile projectile;

    void Update()
    {
        // Ctrl was pressed, launch a projectile
        if (Input.GetButtonDown("Fire1"))
        {
            // Instantiate the projectile at the position and rotation of this transform
            Missile clone = (Missile)Instantiate(projectile, transform.position, transform.rotation);

            // Set the missiles timeout destructor to 5
            clone.timeoutDestructor = 5;
        }
    }
}