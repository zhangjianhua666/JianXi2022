using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xiangJiKonZhi : MonoBehaviour {
    /// <summary>
    /// 主相机
    /// </summary>
    public GameObject mianXiangJi;
    /// <summary>
    /// 二号相机
    /// </summary>
    public GameObject XiangJI2;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float mouseX = Input.GetAxis("Mouse X") * 10.0f;
        float mouseY = Input.GetAxis("Mouse Y") * 10.0f;
        //Camera.main.transform.localRotation = Camera.main.transform.localRotation * Quaternion.Euler(-mouseY,0,0);
        Camera.main.transform.localRotation = Camera.main.transform.localRotation * Quaternion.Euler(0, mouseX, 0);
    }
}
