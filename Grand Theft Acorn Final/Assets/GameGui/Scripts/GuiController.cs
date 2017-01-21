using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GuiController : MonoBehaviour {

	public Text boxText;
	public GameObject panel;

	public Text leftText;
	public Text rightText;

	public static GuiController Instance { get; private set; }

	// Use this for initialization
	void Awake () {
		Instance = this;
		panel.SetActive (false);
		//DisplayBox ("Hello World");
	}


	public static void DisplayBox (string txt) {
		Instance._DisplayBox (txt);
	}

	public  void _DisplayBox (string txt){
		//Time.timeScale = 0;
		Instance.panel.SetActive (true);
		Instance.boxText.text = txt;
	}

	public static void ClearBox () {
		Instance._ClearBox ();
	}

	public  void _ClearBox(){
		Instance.panel.SetActive (false);
	//	Time.timeScale = 1.0f;
	}

	public static void LeftText (string txt){
		Instance._LeftText (txt);
	}

	public void _LeftText(string txt){
		Instance.leftText.text = txt;
	}

	public static void RightText (string txt){
		Instance._RightText (txt);
	}

	public void _RightText(string txt){
		Instance.rightText.text = txt;
	}


	//public  static GuiController GetGUI(){
		//return GameObject.Find ("Canvas").GetComponent<GuiController> ();
	//}
}
