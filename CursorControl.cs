using UnityEngine;

public class CursorControl : MonoBehaviour
{
    public MouseLook mouseLook;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.LeftShift))
       {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            mouseLook.enabled = false;
       }
       else if (Input.GetKeyUp(KeyCode.LeftShift))
       {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            mouseLook.enabled = true;
       }
    }
}
