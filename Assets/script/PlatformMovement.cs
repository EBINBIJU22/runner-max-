using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float speed = 5f;  // Movement speed

    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);

        // Destroy when off-screen (adjust -15 based on your camera setup)
        if (transform.position.z < -15f)
        {
            Destroy(gameObject);
        }
    }
}