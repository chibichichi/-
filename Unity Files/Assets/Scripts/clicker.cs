using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clicker : MonoBehaviour
{
  public UnityEngine.UI.Text Point;
  public int point = 0; //현재 포인트를 알려줌
  public int pointperclick = 50;  // 클릭 당 얻는 포인트를 알려줌

  void Update() {
    Point.text = "획득 쥬얼 : " + point;
  }

  public void clicked() {
    point += pointperclick;
  }
}
