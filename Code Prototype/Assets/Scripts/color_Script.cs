using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color_Script : MonoBehaviour
{
    [SerializeField]
    Renderer m_ObjectRenderer;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV(01, 1f, 1f, 1f, 0.5f, 1f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
