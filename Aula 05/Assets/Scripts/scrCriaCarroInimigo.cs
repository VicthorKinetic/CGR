using UnityEngine;
using System.Collections;

public class scrCriaCarroInimigo : MonoBehaviour {

    public GameObject[] modeloCarro;
    public float intervalo = 1f;
    float tempo;
    int posicaoSorteada;
    public float[] posicao = { -1.5f, -0.45f, 0.6f, 1.67f };


	// Use this for initialization
	void Start () {
        tempo = intervalo;
	}
	
	// Update is called once per frame
	void Update () {
        tempo -= Time.deltaTime;
        if (tempo <= 0)
        {
            posicaoSorteada = Random.Range(0, 4);
            Vector3 posicaoCarro = new Vector3( posicao[posicaoSorteada], transform.position.y, transform.position.z);
            int qualCarro = Random.Range(0, 5);
            Instantiate(modeloCarro[qualCarro], posicaoCarro, transform.rotation);
            tempo = intervalo;
        }    
	}
}
