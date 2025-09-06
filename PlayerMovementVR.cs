using UnityEngine;

public class PlayerMovementVR : MonoBehaviour
{
    public float moveSpeed = 2f;
    public Transform vrCamera;

    void Update()
    {
        // Movimento simples para VR (WASD segue direção da câmera)
        Vector3 forward = vrCamera.forward;
        forward.y = 0; // ignora inclinação vertical
        forward.Normalize();

        Vector3 right = vrCamera.right;
        right.y = 0;
        right.Normalize();

        Vector3 direction = forward * Input.GetAxis("Vertical") + right * Input.GetAxis("Horizontal");
        transform.position += direction * moveSpeed * Time.deltaTime;
    }
}
