using UnityEngine;
using System.Collections;

public class scr_Barra : MonoBehaviour {

    private int direcao = 0;
    private float velocidadeBarra = 5f;
    Rigidbody2D corpoBarra;


	// Use this for initialization
	void Start () {
        corpoBarra = GetComponent<Rigidbody2D>();    
    }

     public void MoverBarra()
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

        MoverBarra();

        corpoBarra.velocity = new Vector2(velocidadeBarra * direcao, 0f);

	}
}
