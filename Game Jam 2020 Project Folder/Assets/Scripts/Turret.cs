using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform shootPoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject Shoot(GameObject bullet) {
      GameObject shot =  Instantiate(bullet, shootPoint.position, Quaternion.identity);
      return shot;
    }
}
