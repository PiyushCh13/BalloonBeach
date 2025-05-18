using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.Events;

public class LevelManager : MonoBehaviour
{
    [SerializeField] float _Curvature;
    [SerializeField] float _Trimming;

    private Transform player;

    public Transform[] all_Triangles;

    private int randomIndex;
    private int previousRandomIndex = -1;
    public Vector3 spawnPos;
    public float posOffset;

    public float timeToSpawn = 0f;
    public float maxTimeToSpawn = 5.0f;

    void Awake()
    {
        Shader.SetGlobalFloat("_Curvature", _Curvature);
        Shader.SetGlobalFloat("_Trimming", _Trimming);
        player = ManagerHandler.Instance.game_Manager.player.transform;
    }

    private void Start()
    {
        spawnPos = new Vector3(0, 0, posOffset);
    }

    void Update()
    {
        timeToSpawn += Time.deltaTime;

        if (timeToSpawn >= maxTimeToSpawn)
        {
            InstantiateTriangles();
            timeToSpawn = 0.0f;
        }
    }

    public void InstantiateTriangles()
    {
        randomIndex = Random.Range(0, all_Triangles.Length);

        if(randomIndex == previousRandomIndex) 
        {
            randomIndex = (randomIndex + 1) % all_Triangles.Length;
        }

        Transform currentTriangePrefab = all_Triangles[randomIndex];
        SetSpawnPosition(currentTriangePrefab);
        previousRandomIndex = randomIndex;
    }

    public void SetSpawnPosition(Transform triangle)
    {
        spawnPos = new Vector3(triangle.transform.position.x, triangle.transform.position.y, player.position.z + posOffset);
        triangle.transform.position = spawnPos;
        triangle.gameObject.SetActive(true);
    }
}
