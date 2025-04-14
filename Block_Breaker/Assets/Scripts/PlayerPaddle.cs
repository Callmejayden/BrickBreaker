using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPaddle : MonoBehaviour
{
    //vars
    protected Vector3 movementDirection = Vector3.zero;
    [SerializeField,Range(1,20) ]protected float movSpeed = 1f;
    //[SerializeField,Range(10,29) ]protected float maxSpeed = 20f;



    //methods

    private void Update()
    {
        MovePaddle();
    }

    public void MoveInput(InputAction.CallbackContext aContext)
    {
        Vector2 av2 = aContext.ReadValue<Vector2>();

        movementDirection.x = av2.x;
    }

    public void MovePaddle()
    {
        transform.Translate(movementDirection * movSpeed * Time.deltaTime);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }


}
