using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform player;
    public Vector3 playercamDistance;


    void Update()
    {
        transform.position = player.transform.position - playercamDistance;
    }
}
