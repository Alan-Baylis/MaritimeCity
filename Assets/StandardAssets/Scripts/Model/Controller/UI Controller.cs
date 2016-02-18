using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;




/// <summary>
/// A basic GUI design interface is being currently used but a more comprenhensive one is on the way
/// </summary>
public class HighLevelUIController : MonoBehaviour 
{

	GUISkin NewGUISkin = new GUISkin();
	GUI NewGUI = new GUI();
	GUIContent NewGUIContent = new GUIContent();
	GUIStyle NewGUIStyle = new GUIStyle();
	GUIStyleState NewGUIStyleState = new GUIStyleState();


	/// <summary>
	/// This should probably be in the main character file 
	/// </summary>
	Camera RenderUIOutlineForGameObjects = new Camera();

	// Use this for initialization
	void Start () 
	{
		NewGUIStyle.active = NewGUIStyleState;
		NewGUIStyle.alignment = TextAnchor.MiddleCenter;
		NewGUIContent.text = HighLevelDialogueController.BrendanScript [1];
	
	}

	
	// Update is called once per frame
	void Update ()
	{


	}
}

