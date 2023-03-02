using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class daohang : MonoBehaviour {
    private NavMeshAgent nav;//导航组件
    public Transform muBiao;//目标点
    public Animator an;//动画组件
    public Image img;//怪兽血条组件



	// Use this for initialization
	void Start () {
        nav = GetComponent<NavMeshAgent>();
        an = GetComponent<Animator>();
        nav.destination = new Vector3(-6.53f, 10.81f, -10f);
        an.SetBool("walk", true);
    }
	
	// Update is called once per frame
	void Update () {
        if (img.fillAmount<=0)
        {
            shuaguai.add();
            Destroy(this.gameObject);
        }
	}
    private void OnTriggerEnter(Collider other)
    {
        img.fillAmount -= 0.1f;


    }
}
