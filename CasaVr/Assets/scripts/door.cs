using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    bool BoolDoor;
    public Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();

        BoolDoor = anim.GetBool("open");
    }
    public void openDorr()
    {
        if (BoolDoor == false)
        {
        anim.SetBool("open",true);
        BoolDoor = anim.GetBool("open");
            print(BoolDoor);
        }
           

        else
        {
            anim.SetBool("open", false);
            BoolDoor = anim.GetBool("open");
            print(BoolDoor);
        }

    }
}
