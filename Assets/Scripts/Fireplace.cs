using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireplace : MonoBehaviour
{
    public GameObject firePrefab;
    private Vector3 spawnPosition;
    private GameObject fireHolder;

    private List<GameObject> tempPrefab;

    private void Awake()
    {
        tempPrefab = new List<GameObject>();
        spawnPosition = transform.position + Vector3.up * 2;
    }

    private void Start()
    {
        GameObject temp = Instantiate(firePrefab, spawnPosition, transform.rotation);
        tempPrefab.Add(temp);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(tempPrefab==null)
        {
            GameObject temp = Instantiate(firePrefab, spawnPosition, transform.rotation);
            tempPrefab.Add(temp);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        tempPrefab.Clear();

        GameObject temp = Instantiate(firePrefab, spawnPosition, transform.rotation);
        tempPrefab.Add(temp);

        Debug.Log(other.gameObject.name);
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
