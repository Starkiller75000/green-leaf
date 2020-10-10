using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WasteBackgroundTile : MonoBehaviour {

    public int width;
    public int height;
    public int offSet;
    public GameObject tilePrefab;
    public GameObject dots;
    public GameObject destroyParticle;
    private BackgroundTile[,] allTiles;
    public GameObject[,] allDots;
    public Dot currentDot;
    private FindMatches findMatches;
    private RaycastHit hit;
    private string ourObject;

	// Use this for initialization
	void Start () {
        allTiles = new BackgroundTile[width, height];
        allDots = new GameObject[width, height];
	}
	
    public void Spawn(){
        float i = Random.Range(0.5f, 3.7f);
        float j = Random.Range(0.5f, 3f);
        Vector2 tempPosition = new Vector3(transform.position.x+i, transform.position.y+j, 0);
        GameObject dot = Instantiate(dots, tempPosition, Quaternion.identity);
        dot.transform.parent = this.transform;
        dot.name = "( " + i + ", " + j + " )";
        dot.transform.localScale = new Vector3(i, j, 1);
    }
}
