using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bolt;

public class EnemySightLaser : MonoBehaviour
{
    public LineRenderer lineOfSight;
    public float range;

    bool IsLight;
    // Start is called before the first frame update

    void Start()
    {

    }
    void FixedUpdate()
    { 
        RaycastHit2D hitinfo = Physics2D.Raycast(transform.position, transform.right, range);




        if (hitinfo.collider != null)
        {

            Debug.Log("Pooooo");
            lineOfSight.SetPosition(1, hitinfo.point);

            if (hitinfo.collider.CompareTag("Player")) {
                CustomEvent.Trigger(GameObject.FindGameObjectWithTag("Player"), "Death", IsLight);
            }

        }
        else
        {
            Debug.Log("Po");
            lineOfSight.SetPosition(1, transform.position + transform.right * range);

        }
        lineOfSight.SetPosition(0, transform.position);





   
    
    }

   public void SetLight(bool isLight) {
       IsLight = isLight;
   }
}
