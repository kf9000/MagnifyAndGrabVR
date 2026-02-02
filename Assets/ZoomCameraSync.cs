using UnityEngine;

public class ZoomCameraSync : MonoBehaviour
{

    public Transform lens;
    public Transform xrCam;
    public Transform lensCam;
void Update() {

    Vector3 viewDir = lens.position - xrCam.position;

    lensCam.transform.rotation = Quaternion.LookRotation(viewDir);
}

}
