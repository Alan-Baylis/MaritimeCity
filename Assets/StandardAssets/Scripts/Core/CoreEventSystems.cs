using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEditor.Events;
using System.Collections;

public class CoreEventSystems : MonoBehaviour {


    


    // Use this for initialization
    void Start()
    {

        Debug.Log("Core Event Systems Active");
      

    }

    // Update is called once per frame
    void Update()
    {

    }

    
    //UnityEventCallState MaritimeCallState = UnityEventCallState.Off;

    void Awake()
    {

        //MaritimeCallState = UnityEventCallState.EditorAndRuntime;

    }
}



public interface IMixamoAnimationHandler
{
    

    void PlayAnimation(Animation MixamoAnimation);

}
