﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGen : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine("Transfer");
        

    }

    IEnumerator Transfer()
    {
        yield return new WaitForSeconds(1);
        transform.parent.position = new Vector3(0, 0, transform.parent.position.z + 200);
    }
}
