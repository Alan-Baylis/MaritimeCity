﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using CoreSystems.DialogueSystem;
using System.Collections;
using System.Collections.Generic;

public class HighLevelDialogueController : CoreDialogueSystems
{

	public UnityEvent UnityEvent_DialogueBoxOpen;
	public UnityEvent UnityEvent_DialogueBoxClose;


	
	public static int Dialogue_ScriptIterator = 0;
	public static float _Time = 0;

   
	public AudioClip[] BrendanAudioDialogue = new AudioClip[10];
	public AudioClip[] LukeAudioDialogue = new AudioClip[10];
	public AudioClip[] ElliAudioDialogue = new AudioClip[10];

	public bool bConversationStart = false;
	public bool bConversationActive = false;
	public bool bConversationEnd = false;

	

	public AudioSource PrimarySource; //Brendan
	public AudioSource ElliSource;
	public AudioSource LukeSource;

	public enum DialogueState {Brendan, Elli, Luke, Liam};
	public enum DialogueControllerState {Open, Closed};


	public DialogueControllerState NewDialogueUIState = DialogueControllerState.Open;
	public DialogueState NewDialogueScriptState;

	// Use this for initialization
	void Start ()
	{

		 

	}

	public void StateInitialization() 
	{
		if (NewDialogueUIState == DialogueControllerState.Open) 
		{
			

		} else if (NewDialogueUIState == DialogueControllerState.Closed) 
		{
			
		}

	}
		
	public void OnPointerClick(PointerEventData eventData)
	{
		ScriptIterator++;

	}

	bool bFinishedPlaying()
	{
		if (PrimarySource.isPlaying == true)
		{
			return true;

		} else if (PrimarySource.isPlaying == false) 
		{
			return false;
		}

		return false;
	}


	//For memory efficiency 
	public void PurgeMemory(){


	}



	// Update is called once per frame
	void Update ()
	{


	
	}


}

