using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] GameObject[] lazers;
    [SerializeField] RectTransform crosshair;

    // state of the weapon
    bool isFiring = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.visible = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        ProcessFiring();
        MoveCrossHair();
    }

    private void ProcessFiring()
    {
        foreach (var weapon in lazers)
        {
            var emmissionModule = weapon.GetComponent<ParticleSystem>().emission;
            emmissionModule.enabled = isFiring;
        }
    }

    public void OnFire(InputValue inputValue)
    {
        isFiring = inputValue.isPressed;
    }

    void MoveCrossHair()
    {
        crosshair.position = Input.mousePosition;
    }
}
