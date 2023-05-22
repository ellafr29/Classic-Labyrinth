using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Coin : MonoBehaviour
{
    [SerializeField] int value;
    [SerializeField] Transform visual;
    public int Value
    {
        get => value;
    }

    private void Start()
    {
        Animate();
    }
    
    public void Animate()
    {
        var seq = DOTween.Sequence();
        seq.Append(visual.DOLocalRotate(new Vector3 (visual.eulerAngles.x, 180, 0), 0.5f));
        seq.Append(visual.DOLocalRotate(new Vector3 (visual.eulerAngles.x, 360, 0), 0.5f));
        seq.SetLoops(-1);
    }
}
