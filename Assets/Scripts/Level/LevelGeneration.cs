using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneration : MonoBehaviour
{
    public void SetPositionCoroutine()
    {
        StartCoroutine(SetPosition());
    }

    private IEnumerator SetPosition() 
    {
        yield return new WaitForSeconds(1f);
        transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z + 400f);
    }
}
