using UnityEngine;

public class WindowResolutionClamper : MonoBehaviour
{
    [SerializeField] private int minXSize;
    [SerializeField] private int minYSize;
    private bool currentMousePressing;
    private bool previousMousePressing;
    void Update()
    {
        if(Input.GetKey(KeyCode.Mouse0))
            return;
        
        int actualWidth = Screen.width;
        actualWidth = Mathf.Clamp(actualWidth, minXSize, 99999);

        int actualHeight = Screen.height;
        actualHeight = Mathf.Clamp(actualHeight, minYSize, 99999);

        Screen.SetResolution(actualWidth, actualHeight, false);
    }
}
