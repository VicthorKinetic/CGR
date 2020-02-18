using UnityEngine;
using System.Collections;

public class scr_Pacman : MonoBehaviour {

    public Rigidbody2D corpoPacman;
	public int FantasmasAcertos;
	public GameObject bola;

	// Use this for initialization
	void Start () {
		bola = this.gameObject;
        corpoPacman = GetComponent<Rigidbody2D>();
        corpoPacman.velocity = new Vector2(2, -5);
	
	}
	
	// Update is called once per frame
	void Update () {
        if (corpoPacman.velocity.y > 0)
            corpoPacman.velocity = new Vector2(corpoPacman.velocity.x, 5f);
        else
            corpoPacman.velocity = new Vector2(corpoPacman.velocity.x, -5f);

        if (corpoPacman.velocity.x > 3f)
            corpoPacman.velocity = new Vector2(3f, corpoPacman.velocity.y);


        
	}

	void OnCollisionEnter2D(Collision2D quem)
	{
		if (quem.gameObject.tag == "Enemy")
		{
			FantasmasAcertos++;
		}
	}
}
