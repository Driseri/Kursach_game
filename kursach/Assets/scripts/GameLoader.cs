using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour
{

    public GameObject camera;
    public GameObject hero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position_hero = hero.transform.position;
        position_hero.z -= 20;
        camera.transform.position = position_hero;

    }
}
