using UnityEngine;
using System.Collections;

public class scrRandomCor : MonoBehaviour {

    public Sprite[] sprites;
    
    // Use this for initialization
    void Start () {
        int qualCor = Random.Range(0, sprites.Length);

        GetComponent<SpriteRenderer>().sprite = sprites[qualCor];    
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
