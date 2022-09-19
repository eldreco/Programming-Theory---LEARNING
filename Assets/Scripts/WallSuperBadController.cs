using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//INHERITANCE
public class WallSuperBadController : WallController
{
    new int change = 20;
        //POLYMORPHISM
    public override void ChangePoints()
    {
        playerController.SetPoints(-change);
    }
}
