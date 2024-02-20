using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubo : MonoBehaviour
{
    // Start is called before the first frame update 
    public int puntos;
    void Start()
    {
        puntos =0;
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision c){ 

         Debug.Log("Choque tipo trigger");
        puntos++;
    }
}
