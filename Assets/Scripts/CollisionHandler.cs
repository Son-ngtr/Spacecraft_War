using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] GameObject destroyVFX; 

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(destroyVFX, transform.position, Quaternion.identity);
        // Debug.Log("Hit " + other.gameObject.name);
        Debug.Log($"Hit {other.gameObject.name}");
        Destroy(gameObject);

    }
}
