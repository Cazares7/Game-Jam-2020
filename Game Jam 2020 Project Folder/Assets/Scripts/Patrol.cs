using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    public float rotate_speed = 1.0f;

    public Transform[] moveSpots;
    private int randomSpot;

    private float waitTime;
    public float startWaitTime;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;
        randomSpot = Random.Range(0, moveSpots.Length);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);
      
       Vector3 targetDirection = moveSpots[randomSpot].position - transform.position;
        
        Vector3 targetPosition = new Vector3(transform.position.x, transform.position.y, moveSpots[randomSpot].position.y); // The step size is equal to speed times frame time.
      transform.LookAt(targetPosition);
       if (Vector2.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                randomSpot = Random.Range(0, moveSpots.Length);
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }

    }

    public static float getAngle(Vector3 fr, Vector3 to, Vector3 up)
    {
        // http://answers.unity3d.com/questions/24983/how-to-calculate-the-angle-between-two-vectors.html      

        // the vector perpendicular to referenceForward (90 degrees clockwise)
        // (used to determine if angle is positive or negative)
        Vector3 referenceRight = Vector3.Cross(up, fr);

        // Get the angle in degrees between 0 and 180
        float angle = Vector3.Angle(to, fr);

        // Determine if the degree value should be negative. Here, a positive value
        // from the dot product means that our vector is the right of the reference vector
        // whereas a negative value means we're on the left.
        float sign = (Vector3.Dot(to, referenceRight) > 0.0f) ? 1.0f : -1.0f;

        float finalAngle = sign * angle;

        return finalAngle;

    }
}
