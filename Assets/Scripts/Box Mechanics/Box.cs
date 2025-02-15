using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField] private float speed;

    //Time limit is for the movement on the conveyor when they spawn
    private float timeLimit = 3f;
    private float timeMoving;

    private Rigidbody _rb;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //Makes the box and stops when time limit is over
        if (timeMoving < timeLimit)
        {
            timeMoving +=Time.deltaTime;
            Vector3 velocity = new Vector3(0, _rb.linearVelocity.y, 0);
            velocity += transform.forward * speed;
            _rb.linearVelocity = velocity;
        }
        
    }
}
