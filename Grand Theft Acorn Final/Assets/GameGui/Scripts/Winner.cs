using UnityEngine;
using System.Collections;

public class Winner : MonoBehaviour {

	string winnerMessage = "U R WINNR";

	void OnCollisionEnter2D (){
		GuiController.DisplayBox(winnerMessage);
	}

}
