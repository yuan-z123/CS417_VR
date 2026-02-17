using UnityEngine;
using UnityEngine.InputSystem;

public class Switch : MonoBehaviour
{
    public Transform player;
    public Transform outsidePoint;
    public InputActionReference action;

    private Vector3 insidePosition;
    private bool isOutside = false;

    void Start()
    {
        insidePosition = player.position;

        action.action.Enable();
        action.action.performed += ctx =>
        {
            if (isOutside)
            {
                player.position = insidePosition;
            }
            else
            {
                player.position = outsidePoint.position;
            }

            isOutside = !isOutside;
        };
    }

    void Update()
    {

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            if (isOutside)
            {
                player.position = insidePosition;
            }
            else
            {
                player.position = outsidePoint.position;
            }

            isOutside = !isOutside;
        }
    }
}
