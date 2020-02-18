using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scr_Iniciar : MonoBehaviour {


    public Button btnStart;

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

    public void Menu()
    {
        SceneManager.LoadScene("Inicio");
    }
}
