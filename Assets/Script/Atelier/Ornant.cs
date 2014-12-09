using UnityEngine;
using System.Collections;

public class Ornant : MonoBehaviour {
	public bool over;
	// Use this for initialization
	void Start () {
		renderer.material.color = new Color (0, 0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseEnter() {
		renderer.material.color = new Color (1, 1, 1, 1);
	}

	void OnMouseExit() {
		renderer.material.color = new Color (0, 0, 0, 0);
	}

	void OnMouseDown() {
		Application.LoadLevel ("Ornant");
	}
}
