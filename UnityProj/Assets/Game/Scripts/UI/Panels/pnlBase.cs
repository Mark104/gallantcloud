using UnityEngine;
using System.Collections;

public class pnlBase: UIPanelController {

	void Awake () {
		
		hidePosition = new Vector3(0,-700,0);
		showPosition = new Vector3(0,-300,0);
		currentlyHidden = false;
		
	}
}
