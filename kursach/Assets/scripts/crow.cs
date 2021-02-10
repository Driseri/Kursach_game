using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crow : MonoBehaviour
{
    public GameObject hero;
    public Sprite LeftCrowSprite;
    public Sprite RightCrowSprite;
    public float speed = 2f;
    public int RL = 0; // 1 - right; 0 - left
    public int rage = 0; // 0-neiral 1-agresive
    public float HP = 25f;
    public Rigidbody2D _rBody;
    public float pushPower = 10f;
  //  public BoxCollider2D collider = GetComponent<BoxCollider2D>();


/*
    public void PushAway(Vector2 pushFrom, float pushPower)
    {
        _rBody = GetComponent<Rigidbody2D>();
        // Если нет прикреплённого Rigidbody2D, то выйдем из функции
        if (_rBody == null || pushPower == 0)
        {
            return;
        }

        // Определяем в каком направлении должен отлететь объект
        // А также нормализуем этот вектор, чтобы можно было точно указать силу "отскока"
        Vector2 m_NewForce = new Vector2(1.0f, 0f);
        
        // Толкаем объект в нужном направлении с силой pushPower
        _rBody.AddForce(m_NewForce, ForceMode2D.Force);
    }
*/
    /*
    void Kick()
    {
        
        Vector2 crow_position = transform.position;
        if (collision.gameObject.name = "hero")
        {
            PushAway(crow_position, pushPower);
        }
    }
    */


    void RightRunning()
    {
        this.GetComponent<SpriteRenderer>().sprite = RightCrowSprite;
    }
    void LeftRunning()
    {
        this.GetComponent<SpriteRenderer>().sprite = LeftCrowSprite;
        
    }

    
    int Moving(int rage, int RL)
    {
        float dx;
        float dy;
        float dc;
        Vector2 hero_position = hero.transform.position;
        Vector2 crow_position = transform.position;
        dx = hero_position.x - crow_position.x;
        dy = hero_position.y - crow_position.y;
        dc = dx * dx + dy * dy;
        if (dc < 50)
        {
            rage = 1;
        }
        else { rage = 0; }

        if (rage != 0)
        {
            if (dx < 0)
            {
                crow_position.x -= speed * Time.deltaTime;
                transform.position = crow_position;
                LeftRunning();
            }
            if (dx > 0)
            {
                crow_position.x += speed * Time.deltaTime;
                transform.position = crow_position;
                RightRunning();
            }
            if (dy > 0)
            {
                crow_position.y += speed * Time.deltaTime;
                transform.position = crow_position;
            }
            if (dy < 0)
            {
                crow_position.y -= speed * Time.deltaTime;
                transform.position = crow_position;
            }
            
        }
        return (RL);
    }
   
    

    // Update is called once per frame
    void Update()
    {
        RL = Moving(rage, RL);
       // Kick();
    }
}
