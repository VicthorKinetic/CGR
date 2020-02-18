using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scr_Iniciar : MonoBehaviour {

    public Button botao;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Iniciar()
    {
        SceneManager.LoadScene("Jogo");
    }
}
