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
		if ( gesture.Selection.name == "PopCorn" ) {
			Debug.Log ("PopCorn has been taped");
			gesture.Selection.GetComponent<tk2dSprite>().color = new Color (1,1,1,1);
			gesture.Selection.GetComponent<tk2dSpriteAnimator>().PlayFromFrame(0);
			gesture.Selection.GetComponent<AudioSource>().Play();
		}
		if ( gesture.Selection.name == "Faucheuse" ) {
			Debug.Log ("Faucheuse has been taped");
			gesture.Selection.GetComponent<tk2dSprite>().color = new Color (1,1,1,1);
			gesture.Selection.GetComponent<tk2dSpriteAnimator>().PlayFromFrame(0);
			gesture.Selection.GetComponent<AudioSource>().Play();
		}
		if ( gesture.Selection.name == "Party" ) {
			Debug.Log ("Party has been taped");
			gesture.Selection.GetComponent<tk2dSprite>().color = new Color (1,1,1,1);
			gesture.Selection.GetComponent<tk2dSpriteAnimator>().PlayFromFrame(0);
			gesture.Selection.GetComponent<AudioSource>().Play();
		}
		if ( gesture.Selection.name == "Mouchoir" ) {
			Debug.Log ("Party has been taped");
			gesture.Selection.GetComponent<tk2dSprite>().color = new Color (1,1,1,1);
			gesture.Selection.GetComponent<tk2dSpriteAnimator>().PlayFromFrame(0);
			gesture.Selection.GetComponent<AudioSource>().Play();
		}
	}


}