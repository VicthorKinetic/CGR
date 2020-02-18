using UnityEngine;
using System.Collections;

public class scrBastao : MonoBehaviour {

    public float velocidade = 7f;
    Rigidbody2D corpo2dBastao;
    int direcao = 0;
	// Use this for initialization
	void Start () {
        corpo2dBastao = GetComponent<Rigidbody2D>();
	}

    private void verificaDirecao()
    {
        if (Input.GetAxis("Horizontal") > 0)
            direcao = 1;
        else
            if (Input.GetAxis("Horizontal") < 0)
            direcao = -1;
        else
            direcao = 0;
    }

	// Update is called once per frame
	void Update () {
        verificaDirecao();
        corpo2dBastao.velocity = new Vector2(velocidade * direcao ,0f);
	}
}
