using UnityEngine;

public class CopyPestPoses : MonoBehaviour
{
    [SerializeField] private Transform[] posHolders;
    [SerializeField] private Transform[] targetTransforms;

    [InspectorButton("OnCopy")]
    public bool Copy;

    [InspectorButton("OnPaste")]
    public bool Paste;

    private void OnCopy() => DoAction(true);
    private void OnPaste() => DoAction(false);

    private void DoAction(bool copy)
    {
        if (posHolders.Length != targetTransforms.Length)
        {
            Debug.LogError("Container sizes are not equel");
        }
        Transform[] from;
        Transform[] to;
        if (copy)
        {
            from = targetTransforms;
            to = posHolders;
        }
        else
        {
            from = posHolders;
            to = targetTransforms;
        }
        for (int i = 0; i < from.Length; i++)
        {
            if (from[i] == null || to[i] == null)
            {
                Debug.LogError("Null detected. index: " + i);
                break;
            }
            to[i].position = from[i].position;
        }
    }
}