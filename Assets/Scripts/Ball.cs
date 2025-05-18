using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject sceneManager;
    public float playerSpeed = 1000;
    public float directionalSpeed = 35;
    public AudioClip scoreUp;
    public AudioClip damage;
    public Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().linearVelocity = Vector3.forward * playerSpeed * Time.deltaTime;
        transform.Rotate(Vector3.right * GetComponent<Rigidbody>().linearVelocity.z / 4);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Score Up")
        {
            GetComponent<AudioSource>().PlayOneShot(scoreUp, 1.0f);
        }

        if (other.gameObject.tag == "Triangles")
        {
            GetComponent<AudioSource>().PlayOneShot(damage, 1.0f);
            sceneManager.GetComponent<App_Initialize>().GameOver();
        }
    }
}
