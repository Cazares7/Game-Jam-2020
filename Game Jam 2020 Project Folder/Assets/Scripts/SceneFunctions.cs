using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneFunctions : MonoBehaviour
{
   public void LoadLevel(string name) {
       SceneManager.LoadScene(name);
   }

   public void RestartLevel() {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}
