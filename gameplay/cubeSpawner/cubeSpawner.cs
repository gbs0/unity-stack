// Unity Imports;


public class CubeSpawner : MonoBehaviour {
	// Initialize cube prefab;
	public GameObject cubePrefab;

	void FixedUpdate()
	{
		PrefabUtility.InstantiatePrefab(cubePrefab, transform.position, Quaternion.identity);
	}
	
}