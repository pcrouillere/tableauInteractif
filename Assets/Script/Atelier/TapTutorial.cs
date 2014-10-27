using UnityEngine;
using System.Collections;

public class TapTutorial : MonoBehaviour {

	void OnTap(TapGesture gesture) { 
		if (gesture.Selection) {
			if ( gesture.Selection.name == "Thomas" ) {
				Debug.Log ("Thomas has been taped");
				gesture.Selection.GetComponent<tk2dSprite>().color = new Color (1,1,1,1);
				gesture.Selection.GetComponent<tk2dSpriteAnimator>().Play();
			}
		}
	}
}