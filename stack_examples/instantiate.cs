using UnityEngine;
using System.Collections;

// Instantiates 10 copies of Prefab each 2 units apart from each other
public class ExampleClass : MonoBehaviour
{
    public Transform prefab;
    
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(prefab, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
        }
    }
}