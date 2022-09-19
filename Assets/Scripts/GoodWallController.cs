using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class GoodWallController : WallController
{
    private new int change = 10;
    //POLYMORPHISM
    public override void ChangePoints()
    {
        playerController.SetPoints(change);
    }
}
