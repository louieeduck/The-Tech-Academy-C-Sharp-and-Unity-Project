using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDetect : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < -10)
        {
            player.transform.position = new Vector3(-4, 1, 4);
            print("You died, lets try not to do that :)");
        }
    }
}
