using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{

    void OnTriggerEnter(Collider Collider)
    {
        if (Collider.gameObject.tag == "Player")
        {
            Debug.Log("You Win!");
        }
    }
}
