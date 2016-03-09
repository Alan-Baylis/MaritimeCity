using UnityEngine;
using System.Collections;

public class BrendanBaseAnimator : MonoBehaviour {


    public enum WalkID {
        active,
        inactive };

    public static WalkID Walk = WalkID.inactive;
    private Animator testAnimator;


    // Use this for initialization
    void Start() {

        testAnimator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        InitializeWalkerID();
   
    }

    public static void SetWalkIDInactive()
    {
        Walk = WalkID.inactive;
    }

    public static void SetWalkIDActive()
    {
        Walk = WalkID.active;
    }


    public void InitializeWalkerID()
    {
        switch (Walk)
        {

            case WalkID.active:
                if (gameObject != null)
                {
                    testAnimator.Play("Walk");
                }
                break;


            case WalkID.inactive:
                if (gameObject != null)
                {

                    testAnimator.Stop();
                }
                break;

        }

        return testAnimator;
    }


}