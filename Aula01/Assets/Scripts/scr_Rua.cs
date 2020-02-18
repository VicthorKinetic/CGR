using UnityEngine;
using System.Collections;

public class scr_Rua : MonoBehaviour {
    
    // = outro modo de fazer


    //private float posicaoRua;
    //public float velocidadeRua = 0.002f;


    public float velocidadeRua = 1.5f;
    Vector2 posicaoCentro;
    

	// Use this for initialization
	void Start () {

        //posicaoRua = GetComponent<Renderer>().material.mainTextureOffset.y;
	}
	
	// Update is called once per frame
	void Update () {
	
        //posicaoRua += Time.time * velocidadeRua;
        //GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, posicaoRua);

        posicaoCentro = new Vector2(0, Time.time * velocidadeRua);
        GetComponent<Renderer>().material.mainTextureOffset = posicaoCentro;

    }
}
