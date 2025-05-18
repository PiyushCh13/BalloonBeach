using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    private LevelGeneration levelGeneration;
    void Start()
    {
        levelGeneration = transform.parent.GetComponent<LevelGeneration>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            levelGeneration.SetPositionCoroutine();
        }
    }
}
