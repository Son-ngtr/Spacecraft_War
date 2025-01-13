using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject destroyShipVfx;

    private void OnParticleCollision(GameObject other)
    {
        Instantiate(destroyShipVfx, this.transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
