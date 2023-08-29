using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.Pool;

public class HalfSusScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject HalfSus = ObjectPoolScript.SharedInstance.GetPooledObject();
        if (HalfSus != null)
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
