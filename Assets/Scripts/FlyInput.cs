using UnityEngine;
using UnityEngine.InputSystem;
public class FlyInput : MonoBehaviour
{
    [SerializeField] private FlyController _controller;

    private bool _isMousePressed = false;

    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            _isMousePressed = true;
        }
    }

    private void FixedUpdate()
    {
        if(_isMousePressed)
        {
            _controller.MoveUp();
            _isMousePressed = false;
        }
        _controller.Rotate();
    }


}
