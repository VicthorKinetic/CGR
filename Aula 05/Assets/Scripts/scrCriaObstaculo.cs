using UnityEngine;
using System.Collections;

public class scrCriaObstaculo : MonoBehaviour {
    public GameObject modeloObstaculo;
    public float intervalo = 1f;
    float tempo;
    public float[] posicao;


    // Use this for initialization
    void Start()
    {
        tempo = intervalo;
    }

    // Update is called once per frame
    void Update()
    {
        tempo -= Time.deltaTime;
        if (tempo <= 0)
        {
            Instantiate(modeloObstaculo, new Vector3(posicao[0], transform.position.y, transform.position.z), transform.rotation);
            Instantiate(modeloObstaculo, new Vector3(posicao[1], transform.position.y, transform.position.z), transform.rotation);
            tempo = intervalo;
        }
    }
}
