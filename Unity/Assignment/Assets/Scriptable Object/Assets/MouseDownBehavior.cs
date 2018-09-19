using UnityEngine;
using UnityEngine.Events;

public class MouseDownBehavior : MonoBehaviour
{
    public UnityEvent Event;

    private void OnMouseDown()
    {
        Event.Invoke();
    }
}
