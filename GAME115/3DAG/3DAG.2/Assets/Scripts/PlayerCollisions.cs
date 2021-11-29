using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    // Door Animator
    public GameObject door; // This will be an open slot in the Unity Inspector to drag the door object into yo
    Animator doorAnimator;

    // To check if the door is open or not
    private bool doorIsOpen = false;



    // Start is called before the first frame update
    void Start()
    {
        doorAnimator = door.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Collision detection
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.tag == "shackDoor")
        {
            // Debug.Log("Hit the door!");

            OpenDoor();
        }
    }

    void OpenDoor()
    {
        // Set Animator parameter
        doorAnimator.SetBool("doorOpen", true);
    }

}
