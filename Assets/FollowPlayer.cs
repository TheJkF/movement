using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform Ch19_nonPBR;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = Ch19_nonPBR.position + offset; 
    }
}
