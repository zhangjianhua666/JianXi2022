using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class daziji : MonoBehaviour {
    private float time;//计时器
    public string strTxt;//要显示的文字
    private int count=0;//数组下标
    public Text txt;//文本组件
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if (count<=strTxt.Length)
        {
            if (time>=0.1f)
            {
                txt.text = strTxt.Substring(0, count);
                count++;
                time = 0;
            }
        }
	}
}
