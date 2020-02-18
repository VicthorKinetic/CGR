using UnityEngine;
using System.Collections;

public class scr_Player : MonoBehaviour {

    #region Variáveis
    public float velocidadePlayer = 0.09f;
    private int direcaoX = 0;
    private int direcaoY = 0;
    #endregion


    // Use this for initialization
    void Start () {
        
    }

    #region Verificar a Direção do Carro
    public void VerificaDirecao()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        
            direcaoX = 1;
        else
            if (Input.GetKey(KeyCode.LeftArrow))
                direcaoX = -1;
            else
                direcaoX = 0;

        if (Input.GetKey(KeyCode.UpArrow))
        
            direcaoY = 1;
        else
            if (Input.GetKey(KeyCode.DownArrow))
                direcaoY = -1;
            else
                direcaoY = 0;
        
    }
    #endregion

    // Update is called once per frame
    void Update() {

        #region Movimentação
        float posicaoX = transform.position.x;
        float posicaoY = transform.position.y;

        VerificaDirecao();

        posicaoX += direcaoX * velocidadePlayer;
        posicaoY += direcaoY * velocidadePlayer;

        posicaoX = Mathf.Clamp(posicaoX, -2.25f, 2.25f);
        posicaoY = Mathf.Clamp(posicaoY, -3.92f, 3.83f);

        transform.position = new Vector3(posicaoX, transform.position.y, transform.position.z);
        transform.position = new Vector3(transform.position.x, posicaoY, transform.position.z);
        #endregion
    }

    void OnCollisionEnter2D(Collision2D quem)
    {
        if (quem.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
