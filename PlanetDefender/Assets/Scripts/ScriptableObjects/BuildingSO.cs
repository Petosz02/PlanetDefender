using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Building", menuName ="Scriptables/New Building")]
public class BuildingSO : ScriptableObject
{
    public string buildingName;
    public int buildingCost;
    public int buildingHP;
    public GameObject buildingPrefab;
}
