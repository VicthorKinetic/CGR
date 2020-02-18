using UnityEngine;
using System.Collections;

public class scrDestroiCarros : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D quem)
    {
        if (quem.gameObject.tag == "Inimigo")
        {
            Destroy(quem.gameObject);
        }
    }
}
