using UnityEngine;
using System.Collections;

public class scr_Perder : MonoBehaviour {

    public int chances = 3;
    public scr_Pacman Pac;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnCollisionEnter2D(Collision2D quem)
    {
        Pac.corpoPacman.position = new Vector2(0f, -1.78f);
        chances--;
        if (chances < 1)
        {
            Destroy(quem.gameObject);
        }
    }
}
