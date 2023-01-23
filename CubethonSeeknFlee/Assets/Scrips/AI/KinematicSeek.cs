using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinematicSeek
{
    public Transform character;
    public Transform target;

    public float maxSpeed;

    public KinematicSteeringOutput getSteering(bool ifFlee)
    {
        KinematicSteeringOutput result = new KinematicSteeringOutput();

        result.velocity = target.position - character.position;

        result.velocity.Normalize();
        result.velocity *= maxSpeed;
        if (ifFlee)
            result.velocity *= -1;
        // Face in the direction we want to move
        // Millington has:
        // character.orientation = newOrientation(character.orientation, result.velocity)
        float targetAngle = newOrientation(character.rotation.eulerAngles.y, result.velocity);
        character.eulerAngles = new Vector3(0, targetAngle, 0);

        result.rotation = 0;
        return result;
    }

    // Millington p. 51
    private float newOrientation(float current, Vector3 velocity)
    {
        // Make sure we have a velocity.
        if (velocity.magnitude > 0) // Millington: "if velocity.length() > 0:"
        {
            // Calculate oreintation from the velocity
            // Millington has "return atan2(-static.x, static.z) because he assumes a left-hand system
            // see formulae on pages 47 vs. 46

            float targetAngle = Mathf.Atan2(velocity.x, velocity.z);
            // The above calculated radians. We prefer degrees, so convert:
            targetAngle *= Mathf.Rad2Deg;
            return targetAngle;
        }
        else
        {
            return current;
        }
    }

    void Update()
    {
        //getSteering(ifFlee);
    }
}
