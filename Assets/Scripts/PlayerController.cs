using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Transform playerTransform;
    public int moveSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);
        playerTransform.Translate(direction * moveSpeed * Time.deltaTime);
    }
}
