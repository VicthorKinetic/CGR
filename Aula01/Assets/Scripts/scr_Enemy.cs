using UnityEngine;
using System.Collections;

public class scr_Enemy : MonoBehaviour {
    // = outro modo de ser feito



    public float velocidadeEnemy = 3f;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(new Vector3(0, -1, 0) * velocidadeEnemy * Time.deltaTime);

        //float posicaoY = transform.position.y;
        //posicaoY += -1 * velocidadeEnemy;
        //transform.position = new Vector3(transform.position.x, posicaoY, transform.position.z);
	
	}
}
