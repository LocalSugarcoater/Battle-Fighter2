using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target_group_offset : MonoBehaviour
{
    [SerializeField] float cameraoffsetx = 0f;
    [SerializeField] float cameraoffsety = 0f;
    [SerializeField] float cameraoffsetz = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void LateUpdate()
    {
        transform.position = new Vector3(transform.position.x + cameraoffsetx, transform.position.y + cameraoffsety, transform.position.z + cameraoffsetz);
    }
}
