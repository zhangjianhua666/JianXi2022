using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shuaguai : MonoBehaviour {
    public GameObject ga;//怪物预制体
    public GameObject jian;//剑预制体
    public Transform jianTR;//剑位置
    private float timer;//计时器
    public Transform[] MuBiaoDian;//刷新点
    public Image imgHP;//血条
    public Text txt;//文本组件
    private static int num;//积分
    public GameObject UiCg;
    public GameObject UiSb;
    public GameObject xianjiZhu;//主相机
    public GameObject xiangJiFu;//副相机

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer>=8f)
        {
            for (int i = 0; i < MuBiaoDian.Length; i++)
            {
                Instantiate(ga, MuBiaoDian[i].transform.position, MuBiaoDian[i].transform.rotation);
            }
            timer = 0f;

        }
        txt.text = "击杀怪物数：" + num;
        if (num>=30)
        {
            UiCg.SetActive(true);
            xianjiZhu.SetActive(false);
            xiangJiFu.SetActive(true);
        }
        if (imgHP.fillAmount<=0)
        {
            UiSb.SetActive(true);
            xianjiZhu.SetActive(false);
            xiangJiFu.SetActive(true);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(jian,jianTR.position,jianTR.rotation);
        }
        
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="guai")
        {
            Destroy(other.gameObject);
            imgHP.fillAmount -= 0.1f;
        }
      
    }
    /// <summary>
    /// 加分方法
    /// </summary>
    public static void add() { num++; }
}
