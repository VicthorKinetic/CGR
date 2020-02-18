using UnityEngine;
using System.Collections;

public class scrMovimentoRua : MonoBehaviour {

    public float velocidadeRua = 1.5f;
    Vector2 posicaoTextura;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        posicaoTextura = new Vector2(0, Time.time * velocidadeRua);
        GetComponent<Renderer>().material.mainTextureOffset = posicaoTextura;
	}
}
