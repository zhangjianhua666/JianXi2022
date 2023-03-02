using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttCl1 : MonoBehaviour {
    /// <summary>
    /// 关闭
    /// </summary>
    public void offPlay() {

        Application.Quit();
    }
    /// <summary>
    /// 重启
    /// </summary>
    public void ChonQiPlay() {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
