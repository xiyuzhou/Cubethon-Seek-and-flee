using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kinematic : MonoBehaviour
{
    Vector3 velocity;
    float rotation;

    private KinematicSeek mySteering;
    public Transform myTarget;
    public float myMaxSpeed = 5f;

    public float Range = 10f;
    public bool ifFlee = false;

    private void Start()
    {
        mySteering = new KinematicSeek();
        mySteering.target = myTarget;
        mySteering.character = this.transform;
        mySteering.maxSpeed = myMaxSpeed;
    }

    private void KinematicUpdate(KinematicSteeringOutput steering, float time)
    {
        
        velocity += steering.velocity * time;
        transform.position += velocity * time;
    }

    private void Update()
    {
        if (Vector3.Distance(this.transform.position, myTarget.position) < Range)
        {
            KinematicSteeringOutput steering = mySteering.getSteering(ifFlee);
            KinematicUpdate(steering, Time.deltaTime);
        }
        
    }
}
