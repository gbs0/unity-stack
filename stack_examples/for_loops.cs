public class Block : MonoBehaviour {
	void blockCreator()
  {
  	int levelLines = Mathf.Clamp(level, 1, 6);
  	for(int column = 0; column < levelLines; column++) {

  		for (int row = 0; row < 5; row++) {
    		GameObject copia;
    		if (1 < level/2) {
    			copia = Instantiate(superblock, transform);
    		}
        else copia = Instantiate(block, transform);

    		Vector2 newPosition = genesisBlock;
    		newPosition.x += 1.5f * row;
    		newPosition.y -= 0.8f * column;
    		copia.transform.position = newPosition;
    	}	
  	}
  }
}