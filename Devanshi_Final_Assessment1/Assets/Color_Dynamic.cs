using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color_Dynamic : MonoBehaviour
{
    public Material[] materials_group;
    int random_material;
    void Start()
    {
        //random_material = Random.Range(0, 4);
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = materials_group[Random.Range(0, 4)];

    }
}