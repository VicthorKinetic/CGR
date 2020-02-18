using UnityEngine;
using System.Collections;

public class scr_Destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D quem)
    {
        if(quem.gameObject.tag == "Enemy")
        {
            Destroy(quem.gameObject);
        }
    }
}
