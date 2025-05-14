using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/LevelGoal")]
public class LevelGoal : ScriptableObject
{
    public int targetValue;
    public int targetAmount;
}
