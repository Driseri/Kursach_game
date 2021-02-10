using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartWindow : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("for testing");
    }

    // Start is called before the first frame update
    void Start()
    {
    }

   /* void OnMauseUP()
    {
        
        print("Let the battle begins");
    } 
    */

    // Update is called once per frame
    void Update()
    {
    }
}
