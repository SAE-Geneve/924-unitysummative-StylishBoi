using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float walkSpeed = 6f;
    private Vector3 moveDirection = Vector3.zero;
    
    private PlayerInput _inputs;
    private Rigidbody _rigidbody;

    void Start()
    {
        _inputs=GetComponent<PlayerInput>();
        _rigidbody=GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //I genuiely have no idea what is going on here
        //Everything else in the game works for the most part apart this so you need to fix the movement before playing
        //apart if you think the drunk movement is a good feature (If ends up actually working which is one chance out
        //of two
        Debug.Log(_inputs.Move);
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        float curSpeedX = walkSpeed * _inputs.Move.x;
        float curSpeedY = walkSpeed * _inputs.Move.y;
        
        moveDirection = (forward * curSpeedY) + (right * curSpeedX);

        _rigidbody.AddForce(moveDirection);
    }
}
