using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TrapAnimator : MonoBehaviour
{
    public Vector3 direction = Vector3.up;
    public float time = 1;
    public Ease ease;
    public float offset = 0;

    void Start()
    {
        Invoke(nameof(Move), offset);
    }

    void Move()
    {
        var endPos = transform.position;
        endPos += direction;

        transform.DOMove(endPos, time / 2).SetLoops(-1, LoopType.Yoyo).SetEase(ease);
    }
}
