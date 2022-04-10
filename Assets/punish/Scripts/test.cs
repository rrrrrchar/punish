using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class test : MonoBehaviour
{
    MyInputAction inputActions;

    private void Awake()
    {
        inputActions = new MyInputAction();
    }
    private void OnEnable()
    {
        inputActions.Enable();

        inputActions.GamePlay.Jump.performed += Jump_performed;
    }

    private void Jump_performed(InputAction.CallbackContext obj)
    {
        Debug.Log("jumpjump");
        //throw new System.NotImplementedException();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
