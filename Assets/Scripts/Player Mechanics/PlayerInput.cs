using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    private BoxCatcher _boxCatcher;
    
    private Vector2 _move;
    private bool _isCatching;

    public Vector2 Move => _move;
    public bool IsCatching => _isCatching;

    void Start()
    {
        _boxCatcher=GetComponent<BoxCatcher>();
    }

    public void OnMove(InputAction.CallbackContext context) => _move = context.ReadValue<Vector2>();

    public void OnCatch(InputAction.CallbackContext context)
    {
        _isCatching = context.ReadValueAsButton();
        _boxCatcher.InputCatch(context);
    }

}
