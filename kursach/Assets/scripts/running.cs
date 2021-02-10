using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class running : MonoBehaviour
{

    public Sprite LeftRunningSprite;
    public Sprite RightRunningSprite;
    public Sprite RightSwordSprite;
    public Sprite LeftSwordSprite;
    public float speed = 4f;
    public int RL = 1; // 1 - right; 0 - left
    public int ItemsInArm = 0;
    public float HP = 100f;
    
    

    void RightRunning(int weapon)
    {
        if (weapon == 0) 
        {
            this.GetComponent<SpriteRenderer>().sprite = RightRunningSprite;
        }
        if (weapon == 1)
        {
            this.GetComponent<SpriteRenderer>().sprite = RightSwordSprite;
        }
    }
    void LeftRunning(int weapon)
    {
        if (weapon == 0) 
        {
            this.GetComponent<SpriteRenderer>().sprite = LeftRunningSprite;
        }
        if (weapon == 1)
        {
            this.GetComponent<SpriteRenderer>().sprite = LeftSwordSprite;
        }
    }

    int Moving(int weapon,int RL)
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 position = transform.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;
        if (horizontal > 0) { RightRunning(weapon); RL = 1; }
        if (horizontal < 0) { LeftRunning(weapon); RL = 0; }
        transform.position = position;
        if (weapon == 1)
        {
            speed = 3f;
        }
        else
        {
            speed = 4f;
        }
        return (RL);
    }

     int WeaponChange(int Items, int RL)
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Items = 0;
            if (RL == 1)
            {
                RightRunning(Items);
            }
            else
            {
                LeftRunning(Items);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Items = 1;
            if (RL == 1)
            {
                RightRunning(Items);
            }
            else
            {
                LeftRunning(Items);
            }
        }
        return (Items);
    }




    // Update is called once per frame
    void Update()
    {
        RL = Moving(ItemsInArm,RL);
        ItemsInArm = WeaponChange(ItemsInArm,RL);
    }
}
