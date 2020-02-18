using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Scr_Paku : MonoBehaviour {


    #region Variáveis
    private Rigidbody2D corpo2d;

    private Animator animacao;

    public int direcaoX = 1;

    private float valorPadrao = 0;

    Vector3 posicaoPes;

    public float DiferencaY = 0.6f;

    public float DiferencaX = -0.22f;

    public float raioCirculo = 0.27f;

    public LayerMask camadaChao;

    public bool noChao;

    public float velocidadeX = 0f;

    public float velocidade;

    public float velocidadePulo = 16f;

    public float intervaloPulo = .1f;

    public float tempoPressPulo = 0f;

    private float tempoUltimoPulo = 0;

    public Scr_Camera cameraMatadora;

    public Scr_Audio sons;

    public bool morreu = false;

    public int coletados;

    public bool correndo = false;
    #endregion

    // Use this for initialization

    #region Muda indice da animação conforme movimentação
    public void VerificaAnimacao()
    {
        if (velocidadeX == 0)
        {
            animacao.SetInteger("indAnimPlayer", 0);
        }

        if (velocidadeX > 0 && noChao)
        {
            animacao.SetInteger("indAnimPlayer", 1);
            if (correndo)
            {
                animacao.speed = 3f;
            }
            else
            {
                animacao.speed = 2f;
            }
        }

        if (!noChao)
        {
            animacao.SetInteger("indAnimPlayer", 2);
        }

    }
    #endregion

    #region Atualiza a velocidade do Player
    public void AtualizaAndar()
    {
            var valorEixoX = Input.GetAxis("Horizontal");
            var velocidadeFinalX = velocidade * direcaoX;

            if (valorEixoX != valorPadrao && noChao)
            {
                corpo2d.velocity = new Vector2(velocidadeFinalX, corpo2d.velocity.y);
            }

    }
    #endregion

    #region Verificar direção do Player por meio de Axis
    public void VerificaDirecao()
    {
        var valorEixoX = Input.GetAxis("Horizontal");
        if (valorEixoX > valorPadrao) { direcaoX = (int)DirecaoPlayer.Direita; }
        else if (valorEixoX < valorPadrao) { direcaoX = (int)DirecaoPlayer.Esquerda; }
        transform.localScale = new Vector3(direcaoX, 1, 1);

    }
    #endregion

    #region Determina Tempo de Pulo
    public void verificaTempoPressionadoPulo()
    {
        var valorEixo = Input.GetAxis("Jump");
        if (valorEixo != valorPadrao)
        {
            tempoPressPulo += Time.deltaTime;
        }
        else
        {
            tempoPressPulo = 0;
        }
    }
    #endregion

    #region Atualiza o Pulo
    public void AtualizaPular()
    {
        var valorEixo = Input.GetAxis("Jump");
        verificaTempoPressionadoPulo();
        var pular = false;

        if (valorEixo != valorPadrao)
        {
            pular = true;
            if (noChao)
            {
                if (pular && tempoPressPulo < .1f && Time.time - tempoUltimoPulo > intervaloPulo)
                {
                    corpo2d.AddForce(new Vector2(0, velocidadePulo), ForceMode2D.Impulse);
                    tempoUltimoPulo = Time.time;
                    sons.Jump.Play();
                }
            }
        }
    }
    #endregion

    #region Verifica se correndo
    void VerificaCorrendo()
    {
        var valorEixo = Input.GetAxis("Fire1");
        if (valorEixo != valorPadrao)
        {
            velocidade = 3.5f;
            correndo = true;
        }
        else
        {
            velocidade = 3.4f;
            correndo = false;
        }
    }
    #endregion

    #region Inicialização e Update

    #region Atribui componentes
    void Awake()
    {
        corpo2d = GetComponent<Rigidbody2D>();
        animacao = GetComponent<Animator>();
    }
    #endregion

    void Start () {
	}


    void FixedUpdate()
    {
        #region Captura valores do movimento atual do Player
        velocidadeX = Mathf.Abs(corpo2d.velocity.x);
        #endregion

        #region Determina contato com o chão
        posicaoPes = new Vector3(transform.position.x - DiferencaX, transform.position.y - DiferencaY, transform.position.z);
        noChao = Physics2D.OverlapCircle(posicaoPes, raioCirculo, camadaChao);
        #endregion

        #region Ativa Script da camera
        if (corpo2d.position.x >= 0)
        {
            cameraMatadora.enabled = true;
        }

        #endregion
    }


    #region Interação com Colecionáveis
    void OnCollisionEnter2D(Collision2D quem)
    {
        if (quem.gameObject.tag == "Colectables")
        {
            Destroy(quem.gameObject);
            sons.Get.Play();
            coletados++;
        }
    }
    #endregion

    void Update () {
        VerificaCorrendo();
        VerificaDirecao();
        AtualizaPular();
        VerificaAnimacao();
        AtualizaAndar();
	}
    #endregion

    #region Cria circulo para programador verifica se a intersecção com os hitboxes
    void OnDrawGizmos()
    {
        Gizmos.color = Color.black;
        Gizmos.DrawWireSphere(new Vector3(transform.position.x - DiferencaX, transform.position.y - DiferencaY, transform.position.z), raioCirculo);
    }
    #endregion

}
