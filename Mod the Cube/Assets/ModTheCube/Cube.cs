using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private float colorNum = 0.0f;
    private Material material;


    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        transform.localScale = Vector3.one;
        
        material = Renderer.material;
    }
    
    void Update()
    {
        transform.Rotate(Random.Range(0.0f, 10.0f) * Time.deltaTime, 0.0f, 0.0f);

        colorNum += 0.0001f;
        material.color = new Color(colorNum, 1.0f, colorNum - .7f, 0.4f);
    }
}
