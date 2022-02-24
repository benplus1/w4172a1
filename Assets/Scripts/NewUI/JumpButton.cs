using UnityEngine.EventSystems;
using UnityEngine.UI;

public class JumpButton : Button
{
    public bool isPressed = false;

    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        isPressed = true;
    }

    // Release button.
    public override void OnPointerUp(PointerEventData eventData)
    {
        base.OnPointerUp(eventData);
        isPressed = false;
    }
}
