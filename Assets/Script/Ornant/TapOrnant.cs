using UnityEngine;
using System.Collections;

public class TapOrnant : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTap(TapGesture gesture){
		if ( gesture.Selection.name == "Dress" ) {
			Debug.Log ("Dress has been taped");
			gesture.Selection.GetComponent<tk2dSprite>().color = new Color (1,1,1,1);
			gesture.Selection.GetComponent<tk2dSpriteAnimator>().PlayFromFrame(0);
		}
	}

}

