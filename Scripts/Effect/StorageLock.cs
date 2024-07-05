using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageLock : EffectBase
{
    private Coroutine effectC = null;

    public override void DoEffect()
    {
        effectC = StartCoroutine(A_Effect());
    }
    private IEnumerator A_Effect()
    {
        EpisodeManager.ObjLockStorageAll();
        yield return null;
        EndEffect();
    }

    public override void ShowResult()
    {
    }

    public override void StopAll()
    {
        if (effectC != null)
            StopCoroutine(effectC);
    }
}