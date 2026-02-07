using Unity.VisualScripting;
using UnityEngine;

public interface Interactable
{
    void interact();
}

public class camray : MonoBehaviour
{
    RaycastHit hit;
    Outline outline;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0)); // Center of screen
            if (Physics.Raycast(ray, out RaycastHit hit, 3.0f))
            {
                Debug.DrawRay(ray.origin, ray.direction * hit.distance, Color.red,3.0f);

                if (hit.collider.TryGetComponent(out Interactable interactable)) 
                {   
                    interactable.interact();
                }

            }
            else
            {
                // Ray did not hit anything within max distance (e.g., 100 units)
                float maxDistance = 100f; // Replace with your actual max distance if applicable
                Debug.DrawRay(ray.origin, ray.direction * maxDistance, Color.blue);
            }
        }
    }
}
