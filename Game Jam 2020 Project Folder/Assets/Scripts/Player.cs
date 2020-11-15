using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5;

    public bool inLight = false;
    
    public float lightDuration = 2.0f;
    public float lightCooldownDuration = 2.0f;
    

    private Rigidbody2D body;

    private float lightCooldownTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!inLight)
        {
            if (lightCooldownTime >= lightCooldownDuration)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    StartCoroutine(InLightMode());
                }
            }
            else
            {
                lightCooldownTime += Time.deltaTime;
            }
        }
    }

    IEnumerator InLightMode()
    {
        lightCooldownTime = 0.0f;

        inLight = true;
        yield return new WaitForSeconds(lightDuration);
        inLight = false;
    }
    
    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        
        body.velocity = new Vector2(horizontal, vertical) * speed;
    }
}
