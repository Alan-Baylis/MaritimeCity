
using UnityEngine;
using CoreSystems;
using System.Collections;
using DialogueSystems;

public class BrendanAnimatorScript : StateMachineBehaviour
{


    Core.CoreEventSystem CoreEvent;
    bool bFrontDoorTriggerBreached = false;
    bool bDogGoneUpstairs = false;

    public enum LocationsForBrendan {FrontDoor, LivingRoom, BackOutside};
    LocationsForBrendan Locations;
    static BrendanPOVController BrendanObject;
    GameObject BrendanGameObject = BrendanObject.gameObject;
    Animator BrendanAnimator;
    Vector3[] VectorLocations = new Vector3[20];


    public BrendanAnimatorScript(BrendanPOVController BrendanObject)
    {
        //this.BrendanObject = BrendanObject;

     BrendanAnimator = BrendanGameObject.GetComponent<Animator>();


    }

    public void WalkTo(LocationsForBrendan _Locations)
    {

        if (_Locations == LocationsForBrendan.FrontDoor)
        {
            BrendanAnimator.SetLookAtPosition(VectorLocations[0]);
            BrendanAnimator.Update(1.0f);
        }

        if (_Locations == LocationsForBrendan.LivingRoom)
        {

        }

        if (_Locations == LocationsForBrendan.BackOutside)
        {

        }

    }

    public void PlayAnimation(Animation NewAnimation)
    {
        NewAnimation.GetClip("Walk");
    }

    // OnStateEnter is called before OnStateEnter is called on any state inside this state machine
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {

       
    }

     // OnStateUpdate is called before OnStateUpdate is called on any state inside this state machine
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {

        //template code for Idle
        if (bFrontDoorTriggerBreached == true && stateInfo.IsTag("Idle"))
        {
            animator.SetBool("bAllowWalking", true);
            WalkTo(LocationsForBrendan.FrontDoor);

        }

        //template code for Idle
        if(bDogGoneUpstairs == true && stateInfo.IsTag("Idle"))
        {
            animator.SetBool("bAllowWalking", true);
            WalkTo(LocationsForBrendan.LivingRoom);
        }

    }

	// OnStateExit is called before OnStateExit is called on any state inside this state machine
	//override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateMove is called before OnStateMove is called on any state inside this state machine
	//override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateIK is called before OnStateIK is called on any state inside this state machine
	//override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateMachineEnter is called when entering a state machine via its Entry Node
	//override public void OnStateMachineEnter(Animator animator, int stateMachinePathHash){
	//
	//}

	// OnStateMachineExit is called when exiting a state machine via its Exit Node
	//override public void OnStateMachineExit(Animator animator, int stateMachinePathHash) {
	//
	//}
}

