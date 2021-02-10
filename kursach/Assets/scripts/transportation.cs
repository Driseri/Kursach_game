using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transportation : MonoBehaviour
{

    public GameObject hero;
    public float speed = 0.3f;

    void OnMouseDown()
    {
        while (transform.position.x <= 192)
        {
            Vector2 position = transform.position;
            position.x += position.x + speed * 1 * Time.deltaTime;

            if (transform.position.y <= 9.7)
            {
                position.y += position.y + speed * 0.2f * Time.deltaTime;
            }

            transform.position = position;
            hero.transform.position = transform.position;

            StartCoroutine(ExampleCoroutine());
        }
    }

    IEnumerator ExampleCoroutine()
    {
        Debug.Log("Sosi");
        yield return new WaitForSeconds(5f);
    }
        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
