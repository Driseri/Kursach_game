using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroKick : MonoBehaviour
{
    public Sprite RightSwordSprite;
    public Sprite LeftSwordSprite;
    public Sprite RightSwordKickSprite;
    public Sprite LeftSwordKickSprite;
    int RL;
    int ItemsInArm;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RL = this.GetComponent<running>().RL;
        ItemsInArm = this.GetComponent<running>().ItemsInArm;
        if (ItemsInArm == 1 && Input.GetKeyDown(KeyCode.Space))
        {
            print("PIZDA");
            if (RL == 1)
            {
                this.GetComponent<SpriteRenderer>().sprite = RightSwordKickSprite;
                
            }
            else
            {
                this.GetComponent<SpriteRenderer>().sprite = LeftSwordKickSprite;
                this.GetComponent<SpriteRenderer>().sprite = LeftSwordSprite;
            }
        }
    }
}
