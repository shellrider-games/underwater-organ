using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PianoKey : MonoBehaviour
{
    public float pressedRotation = -83f;
    public float releasedRotation = -90f;
    public float returnSpeed = 5f;
    private bool isPressed = false;

    public void PressKey()
    {
        if (!isPressed)
        {
            transform.localRotation = Quaternion.Euler(pressedRotation, 0, 0);
            isPressed = true;
        }
    }

    public void ReleaseKey() 
    {
        isPressed = false;
    }

    void Update()
    {
        if (!isPressed)
        {
            transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(releasedRotation, 0, 0), Time.deltaTime * returnSpeed);
        }
    }
}
