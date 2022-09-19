using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = new Vector3(this.transform.position.x, this.transform.position.y, player.transform.position.z - 7f);
        this.transform.position = position;
    }
}
