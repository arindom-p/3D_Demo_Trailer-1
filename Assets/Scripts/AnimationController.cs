using UnityEngine;
using DG.Tweening;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private CanvasGroup cg1, cg2, cg3;

    private void Start()
    {
        DOTween.Sequence().AppendInterval(22.45f).Append(cg1.DOFade(1, 0.4f)).Append(cg1.DOFade(0, 0.4f));
        Invoke(nameof(SetPanel), 40f);
    }

    private void SetPanel(){
        Time.timeScale = 0.3f;
        DOTween.Sequence()
            .AppendInterval(1)
            .AppendCallback(() => Time.timeScale = 1)
            .Append(cg1.DOFade(1, 1))
            .Append(cg2.DOFade(1, 1))
            .AppendInterval(2)
            .Append(cg2.DOFade(0, 1))
            .AppendInterval(0.5f)
            .Append(cg3.DOFade(1, 1))
            .AppendInterval(1)
            .Append(cg3.DOFade(0, 1));
    }
}
