using UnityEngine;
using System.Collections;

public class scr_GerenciarFantasmas : MonoBehaviour {

    public GameObject fantasma;
    public int qtdFantasmas = 28;
    public float inicialX = -3.6f;

    private float[] posX;
    public float posY = 5.5f;
    private float posInicialX;


    // Use this for initialization
    void Start()
    {

        posX = new float[qtdFantasmas];
        float modificador = 0f;
        posInicialX = inicialX;

        for (int i = 0; i < qtdFantasmas; i++)
        {
            if (i % 7 == 0)
            {
                posInicialX = inicialX;
                modificador = 0;
            }
            posX[i] = posInicialX + modificador;
            modificador += 1.2f;
        }

        for (int i = 0; i < qtdFantasmas; i++)
        {
            if (i % 7 == 0)
            {
                posY = posY - 1.2f;
            }
            Instantiate(fantasma, new Vector3(posX[i], posY, 0), transform.rotation);
        }


    }

    // Update is called once per frame
    void Update()
    {


    }
}
