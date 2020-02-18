using UnityEngine;
using System.Collections;

public class scr_GerarGotas : MonoBehaviour {

    public GameObject gota;
    public float intervalo = 2f;
    float tempo;
    int posicaoSorteada;
    public float[] posicao = { -5.97f, -4.31f, -2.78f, -1.31f, 0.35f, 1.98f, 3.76f, 5.51f};


    // Use this for initialization
    void Start () {
        tempo = intervalo;
    }
	
	// Update is called once per frame
	void Update () {
        tempo -= Time.deltaTime;
        if (tempo <= 0)
        {
            posicaoSorteada = Random.Range(0, 8);
            Vector3 posicaogota = new Vector3(posicao[posicaoSorteada], transform.position.y, transform.position.z);
            tempo = intervalo;
            Instantiate(gota, posicaogota, transform.rotation);
        }
    }
}
