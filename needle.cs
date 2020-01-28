using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class needle : MonoBehaviour {
	public spinner _spinner;
	public Text scoretext;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D col){
		if (!_spinner.isStoped)
			return;
		scoretext.text = col.gameObject.name;

	}

}