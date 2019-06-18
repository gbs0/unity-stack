using UnityEngine;
using System.Collections;

// This returns the GameObject named Hand in one of the Scenes.

public class ExampleClass : MonoBehaviour
{
    public GameObject hand;

    void Example()
    {
        // This returns the GameObject named Hand.
        hand = GameObject.Find("Hand");

        // This returns the GameObject named Hand.
        // Hand must not have a parent in the Hierarchy view.
        hand = GameObject.Find("/Hand");

        // This returns the GameObject named Hand,
        // which is a child of Arm > Monster.
        // Monster must not have a parent in the Hierarchy view.
        hand = GameObject.Find("/Monster/Arm/Hand");

        // This returns the GameObject named Hand,
        // which is a child of Arm > Monster.
        hand = GameObject.Find("Monster/Arm/Hand");
    }
}