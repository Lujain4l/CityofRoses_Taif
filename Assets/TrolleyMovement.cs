using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TrolleyMovement : MonoBehaviour
{
    // Adjust this speed as needed
    public float movementSpeed = 5f;

    private XRGrabInteractable grabInteractable;
    private Vector3 initialGrabOffset;

    private void Start()
    {
        // Get the XRGrabInteractable component
        grabInteractable = GetComponent<XRGrabInteractable>();

        // Subscribe to grab events
        grabInteractable.onSelectEnter.AddListener(OnGrab);
        grabInteractable.onSelectExit.AddListener(OnRelease);
    }

    // Called when the trolley is grabbed
    private void OnGrab(XRBaseInteractor interactor)
    {
        // Store the initial offset between the trolley and the interactor's position
        initialGrabOffset = interactor.transform.position - transform.position;
    }

    // Called when the trolley is released
    private void OnRelease(XRBaseInteractor interactor)
    {
        // Reset the initial grab offset
        initialGrabOffset = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the trolley is being grabbed
        if (grabInteractable.isSelected)
        {
            // Get the movement input from the user
            float movementInput = Input.GetAxis("Horizontal");

            // Move the trolley only along the X-axis
            Vector3 movement = new Vector3(movementInput, 0f, 0f) * movementSpeed * Time.deltaTime;

            // If the trolley is grabbed, move it along the X-axis while maintaining the initial grab offset
            transform.position += new Vector3(movement.x, 0f, 0f);

            // Reset the Y and Z positions based on the initial grab offset to prevent vertical and depth movement
            transform.position = new Vector3(transform.position.x, transform.position.y + initialGrabOffset.y, transform.position.z + initialGrabOffset.z);
        }
    }
}
