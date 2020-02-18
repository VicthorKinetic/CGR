using UnityEngine;
using System.Collections;

public class scr_Fantasmas : MonoBehaviour {
    private bool destruir = false;
    private Color inicial;
    private Color final;
    private SpriteRenderer fantasma;
    private float temp = 0.0f;

	// Use this for initialization
	void Start () {
        fantasma = GetComponent<SpriteRenderer>();
        inicial = fantasma.color;
        final = new Color(inicial.r, inicial.g, inicial.b, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
        if (destruir)
        {
            temp += Time.deltaTime * 5;

            gameObject.GetComponent<Renderer>().material.color = Color.Lerp(inicial, final, temp);

            if (gameObject.GetComponent<Renderer>().material.color.a <= 0.0)
            {
                Destroy(gameObject);
            }
        }
	}

    void OnCollisionEnter2D(Collision2D quem)
    {
        destruir = true;
    }
}
