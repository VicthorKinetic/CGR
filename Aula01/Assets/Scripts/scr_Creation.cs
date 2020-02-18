using UnityEngine;
using System.Collections;

public class scr_Creation : MonoBehaviour {

    public float max = 1.56f;
    public float min = -1.46f;
    public GameObject[] Enemy;
    public float intervalo = 1f;
    float tempo;
    private double localizacao;

    // Use this for initialization
    void Start () {

        tempo = intervalo;
	
	}
	
	// Update is called once per frame
	void Update () {

        tempo -= Time.deltaTime;
        if (tempo <= 0)
        {
            localizacao = Random.Range(1, 5);

            if (localizacao == 1)
            {
                Vector3 posicaoCarro = new Vector3(-1.4f, transform.position.y, transform.position.z);
                Instantiate(Enemy[Random.Range(0,5)], posicaoCarro, transform.rotation);
            }
            else
            {
                if (localizacao == 2)
                {
                    Vector3 posicaoCarro = new Vector3(-0.51f, transform.position.y, transform.position.z);
                    Instantiate(Enemy[Random.Range(0,5)], posicaoCarro, transform.rotation);
                }
                else
                {
                    if (localizacao == 3)
                    {
                        Vector3 posicaoCarro = new Vector3 (0.51f, transform.position.y, transform.position.z);
                        Instantiate(Enemy[Random.Range(0,5)], posicaoCarro, transform.rotation);
                    }
                    else
                    {
                        Vector3 posicaoCarro = new Vector3(1.4f, transform.position.y, transform.position.z);
                        Instantiate(Enemy[Random.Range(0,5)], posicaoCarro, transform.rotation);
                    }
                }
            }

            tempo = intervalo;

        }

	
	}
}
