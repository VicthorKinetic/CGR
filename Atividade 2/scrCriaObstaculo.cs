using UnityEngine;
using System.Collections;

public class scrCriaObstaculo : MonoBehaviour {

    public GameObject obstaculo;
    public int qtdObstaculos;
    public float inicialX;


    private float[] posX;
    private float posY;
    private float posInicialX;

	// Use this for initialization
	void Start () {
        posX = new float[qtdObstaculos];
        float modificador = 0f;
        posInicialX = inicialX;
        posY = 4f;

        for (int i = 0; i < qtdObstaculos; i++)
        {
            if (i % 23 == 0)
            {
                posInicialX = inicialX;
                modificador = 0;
            }
            posX[i] = posInicialX + modificador;
            modificador += 0.55f;
        }
        
        for (int i = 0; i < qtdObstaculos; i++)
        {
            if (i % 23 == 0)
            {
                posY = posY - .4f;
            }
            Instantiate(obstaculo, new Vector3(posX[i], posY, 0), transform.rotation);
        }
        

    }
	
	// Update is called once per frame
	void Update () {

        
	}
}
