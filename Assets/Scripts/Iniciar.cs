using UnityEngine;
using UnityEngine.SceneManagement;

public class Iniciar : MonoBehaviour
{
  

    void Update()
    {
 
        if (Input.GetKeyDown(KeyCode.D))
        {
            SceneManager.LoadScene("EscenaPrincipal");  
        }
    }
}
