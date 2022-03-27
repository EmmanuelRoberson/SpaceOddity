using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerBehavior : MonoBehaviour
{
    public int speed = 10;

    private CharacterController myController;

    // Start is called before the first frame update
    void Start()
    {
        // Access Character Controller component on attach game object.
        myController = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Movement value in Z direction.
        Vector3 movementZ = Input.GetAxis("Vertical") * Vector3.forward * speed * Time.deltaTime;

        // Movement value in X direction.
        Vector3 movementX = Input.GetAxis("Horizontal") * Vector3.right * speed * Time.deltaTime;

        Vector3 movement = transform.TransformDirection(movementZ + movementX);

        // Moves game object in given direction.
        myController.Move(movementZ+movementX);
    }
}
