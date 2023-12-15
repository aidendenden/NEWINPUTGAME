using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveImageFromKaycode : MonoBehaviour
{
    public RectTransform p;

    public float speed=0.1f;
    
    // Start is called before the first frame update
    void Start()
    {
        GameEventManager.OnKeyDown += KeycodeMove;
    }

    private void KeycodeMove(KeyCode keycode, Vector2 vector2)
    {
        p.transform.DOMove(vector2,speed);

        // 计算移动方向向量
        Vector3 direction = (Vector3)vector2 -  p.position;
        direction.Normalize(); // 将方向向量归一化，使其成为单位向量

        Debug.Log(direction);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  
    
}
