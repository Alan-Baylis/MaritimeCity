using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.Collections;

public class MainMenuUI : MonoBehaviour 
{
	public Button Start;
	public Button Exit;
	public Text Title;

	private Button.ButtonClickedEvent LoadEpisodeOne = new Button.ButtonClickedEvent();

	void Awake()
	{
	   Start.interactable = true;
	   Exit.interactable = true;
	   LoadEpisodeOne.AddListener (LoadLevels);
           Start.onClick = LoadEpisodeOne;
	}

	void LoadLevels()
	{
	   SceneManager.LoadScene (1);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
