using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    protected GameObject player;
    protected PlayerController playerController;
    protected int change;

    // Start is called before the first frame update
    protected void Start()
    {
        player = GameObject.Find("Player");
        playerController = player.GetComponent<PlayerController>();
        SetChange(change);
    }

    public virtual void ChangePoints(){
        playerController.SetPoints(change);
    }

    protected void SetChange(int newChange){
        change = newChange;
    }
}
