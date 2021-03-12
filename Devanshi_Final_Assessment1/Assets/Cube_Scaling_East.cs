using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Scaling_South : MonoBehaviour
{
    float i = 1;
    // Start is called before the first frame update
    public void scaling_cube()
    {
        i = i + 1f;
        transform.localScale = new Vector3(i, 1f, 1f);
    }

    public void OnCollisionEnter(Collision collision)
    {
        Color objColor = GetComponent<Renderer>().material.color;
        Color obsColor = collision.gameObject.GetComponent<Renderer>().material.color;
        if (objColor.Equals(obsColor) || collision.gameObject.CompareTag("center_cube"))
        {
            i = 1;
            transform.localScale = new Vector3(1, 1, 1);
            Destroy(collision.gameObject);
        }
    }
}


