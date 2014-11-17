﻿using UnityEngine;
using System.Collections;

public class Animation : MonoBehaviour {
	public string st;
	public int nbframe;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(GetComponent<tk2dSpriteAnimator> ().CurrentClip != null) {
			Debug.Log("current frame (real name) is " + GetComponent<tk2dSpriteAnimator> ().CurrentClip.name );
			if (GetComponent<tk2dSpriteAnimator> ().CurrentClip.name == st) {
				Debug.Log("current name" + st);
				Debug.Log("current Frame" + GetComponent<tk2dSpriteAnimator> ().CurrentFrame);
				if (GetComponent<tk2dSpriteAnimator> ().CurrentFrame == nbframe) {
					GetComponent<tk2dSprite>().color = new Color (1,1,1,0);
					GetComponent<tk2dSpriteAnimator>().Stop();
				}
			}
		}
	}
}