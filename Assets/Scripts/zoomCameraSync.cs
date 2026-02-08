using UnityEngine;

public class zoomCameraSync : MonoBehaviour
{

    public Transform lens;
    public Transform xrCam;
    public Transform lensCam;
    void LateUpdate() {

        Vector3 direction = lens.position - xrCam.position;

        lensCam.rotation = Quaternion.LookRotation(direction, lens.up);
    }

}
