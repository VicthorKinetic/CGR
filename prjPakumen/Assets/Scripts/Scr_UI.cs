using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scr_UI : MonoBehaviour {

    public Scr_Paku Paku;
    public Text txtColetados;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        txtColetados.text = "0" + Paku.coletados.ToString();
	
	}
}
