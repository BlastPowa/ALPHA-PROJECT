using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    public float speed = 15.0f;

    void Update()
    {
        // Move the NPC car straight forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
