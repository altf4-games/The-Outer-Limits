using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGenerator : MonoBehaviour
{
    [SerializeField] private Vector3[] spawnLocations;
    [SerializeField] private GameObject firePrefab;
    [SerializeField] private GameObject ship;

    public void GenerateFire()
    {
        GameObject fire = Instantiate(firePrefab,spawnLocations[Random.Range(0,spawnLocations.Length)],Quaternion.identity);
        fire.transform.SetParent(ship.transform);
    }
}