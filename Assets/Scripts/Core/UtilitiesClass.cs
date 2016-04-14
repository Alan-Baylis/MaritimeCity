using UnityEngine;
using System.Collections;

public class UtilitiesClass : MonoBehaviour{

    #region Generic Utilities Functions

    public static void SetBoolActive(bool Boolean)
    {

        Boolean = true;

    }

    public static void SetBoolInactive(bool Boolean)
    {
        Boolean = false;

    }

    //Provide a generic implementation that can be called from the utilties class
    public virtual void ISystemPause(string MethodName)
    {

        if (MethodName.Contains("Controller"))
        {
            this.StopCoroutine(MethodName);
        }

    }

    #endregion

    #region System Runtime Functions
    void mRuntimePause()
    {
    //If button is pressed go to next part

        for (int a = 0; a < MaritimeRuntimeInfrastructure.SystemObjects.Length; a++) 
        {
            //MaritimeRuntimeInfrastructure.SystemObjects [a].ISystemPause();
        }

    }


    void mRuntimePlay()
    {
        for (int a = 0; a < MaritimeRuntimeInfrastructure.SystemObjects.Length; a++) 
        {
             // MaritimeRuntimeInfrastructure.SystemObjects [a].ISystemPlay();
        }

    }

    #endregion

    #region Example Code
    //Recursion using polymorphism 
    void Function1()
    {
        Function1(gameObject);
    }

    void Function1(GameObject Game)
    {

    }

    #endregion

}


public interface IUtilitiesInterface
{
    void ISystemPause();

    void ISystemPlay();

    /*
    public virtual void ISystemPlay()
    {
        this.StartCoroutine(methodName: "DialogueIterator");

    }*/

}
