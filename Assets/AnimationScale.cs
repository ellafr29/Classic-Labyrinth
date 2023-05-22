using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[CreateAssetMenu(fileName ="Animation Scale", menuName ="Create Assets/Animation/Scale")]
public class AnimationScale : BaseAnimation
{
    public override void Animate(Transform visual)
    {
        base.Animate(visual);
        visual.parent.DOScale(1.1f, base.duration).SetLoops(-1, LoopType.Yoyo);
    }
}
