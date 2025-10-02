using UnityEngine;

public class FreeLookCamera : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // movement
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float upDown = 0f;

        if(Input.GetKey(KeyCode.Q)) upDown = -1f; // move down
        if(Input.GetKey(KeyCode.E)) upDown = 1f; // move up

        Vector3 moveDirection = new Vector3(horizontal, upDown, vertical);
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        // rotation (using right click and drag)
        if (Input.GetMouseButton(1))  { // right click
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");
            transform.Rotate(Vector3.up, mouseX * rotationSpeed, Space.World);
            transform.Rotate(Vector3.left, mouseY * rotationSpeed, Space.Self);
        }
    }
}
