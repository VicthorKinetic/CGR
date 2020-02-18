using UnityEngine;
using System.Collections;

public class scr_Gota : MonoBehaviour {

    public float velocidade = 3f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(new Vector3(0, -1, 0) * velocidade * Time.deltaTime);

    }
}
