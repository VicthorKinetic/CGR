using UnityEngine;
using System.Collections;

public class scr_MudarFantasma : MonoBehaviour {

    public Sprite[] sprites;

	// Use this for initialization
	void Start () {

        int qualfantasma = Random.Range(0, sprites.Length);

        GetComponent<SpriteRenderer>().sprite = sprites[qualfantasma]; 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
