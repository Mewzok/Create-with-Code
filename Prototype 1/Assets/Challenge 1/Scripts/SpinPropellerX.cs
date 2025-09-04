using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private float rotationSpeed = 3500.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // rotate propeller
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
