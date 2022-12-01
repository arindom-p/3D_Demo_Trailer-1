using UnityEngine;
using DG.Tweening;

public class AnimationController : MonoBehaviour
{
    [SerializeField]
    private GameObject humanObj,
        butterflyObj,
        monsterObj;

    private void Start()
    {
        ManageButterfly();
    }

    private void ManageButterfly()
    {
        DOTween.Sequence().AppendInterval(2.8f)
            .AppendCallback(() => butterflyObj.SetActive(true))
            .AppendInterval(3.5f)
            .AppendCallback(() => butterflyObj.SetActive(false));
    }
}
