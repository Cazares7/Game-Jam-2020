using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    public GameObject CanvasToRender;
    public GameObject main;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleCanvas() {
        bool toggle = !CanvasToRender.activeSelf;
        CanvasToRender.gameObject.SetActive(toggle);

      
    }

     public void ToggleCanvas(GameObject canvas) {
        bool toggle = !canvas.activeSelf;
        canvas.gameObject.SetActive(toggle);

    
    }

    
}
