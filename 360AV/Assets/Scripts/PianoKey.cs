using UnityEngine;
using UnityEngine.Events;

public class PianoKey : MonoBehaviour
{
    public float pressedRotation = -83f;
    public float releasedRotation = -90f;
    public float returnSpeed = 5f;

    public UnityEvent onKeyPressed;
    public UnityEvent onKeyReleased;
    
    private bool isPressed = false;
    

    public void PressKey()
    {
        if (!isPressed)
        {
            transform.localRotation = Quaternion.Euler(pressedRotation, 0, 0);
            isPressed = true;
            onKeyPressed.Invoke();
        }
    }

    public void ReleaseKey() 
    {
        isPressed = false;
        onKeyReleased.Invoke();
    }

    void Update()
    {
        if (!isPressed)
        {
            transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(releasedRotation, 0, 0), Time.deltaTime * returnSpeed);
        }
    }
}
