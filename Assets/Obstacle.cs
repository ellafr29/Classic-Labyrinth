using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Obstacle : MonoBehaviour
{
    [SerializeField] float duration = 1;
    [SerializeField] List<Transform> position;
    
    int index;
    private void Start()
    {
        Move();
    }
    private void Move()
    {
        var pos = position[index];
        this.transform.DOMove(pos.position, duration).onComplete = Move;

        index+=1;
        if(index == position.Count)
            index = 0;
    }
}
