using UnityEngine;

public class ThreePlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float boundaryX = 2f;  // Adjust these to fit your table size
    public float boundaryZ = 2f;

    void Update()
    {
        MoveWithMouse();
    }

    void MoveWithMouse()
    {
        // Get the mouse position in the game world
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, Camera.main.transform.position.y - transform.position.y));

        // Clamp the position to prevent the paddle from going out of bounds
        float clampedX = Mathf.Clamp(mousePosition.x, -boundaryX, boundaryX);
        float clampedZ = Mathf.Clamp(mousePosition.z, -boundaryZ, boundaryZ);

        // Move the paddle to the new position
        transform.position = new Vector3(clampedX, transform.position.y, clampedZ);
    }
}
