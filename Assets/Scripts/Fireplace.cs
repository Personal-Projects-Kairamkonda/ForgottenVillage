using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireplace : MonoBehaviour
{
    public GameObject firePrefab;
    private Vector3 spawnPosition;
    private GameObject fireHolder;

    private void Awake()
    {
        spawnPosition = transform.position + Vector3.up * 2;
    }

    private void Update()
    {
        SpawnPrefab();
    }

    public void SpawnPrefab()
    {
        if (fireHolder == null)
        {
            GameObject temp = Instantiate(firePrefab, spawnPosition, transform.rotation);
            //temp.gameObject.transform.SetParent(this.transform);
            fireHolder = temp;
        }
    }



}
