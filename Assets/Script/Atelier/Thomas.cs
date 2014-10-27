using UnityEngine;
using System.Collections;

public class Thomas : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(GetComponent<tk2dSpriteAnimator> ().CurrentClip != null) {
			if (GetComponent<tk2dSpriteAnimator> ().CurrentClip.name == "ThomasHit") {
							if (GetComponent<tk2dSpriteAnimator> ().CurrentFrame == 6) {
								GetComponent<tk2dSprite>().color = new Color (1,1,1,0);
							}
					}
		}
	}
}
