using UnityEngine;
using System.Collections;

public class scrCarroInimigo : MonoBehaviour {

    public float velocidade = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //float posicaoY = transform.position.y;
        //posicaoY += -1 * velocidade;
        //transform.position = new Vector3(transform.position.x, posicaoY, transform.position.z);

        transform.Translate(new Vector3(0, -1, 0) * velocidade * Time.deltaTime);
	}
}
