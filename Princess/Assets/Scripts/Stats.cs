using UnityEngine;

public class Stats : MonoBehaviour
{
	[SerializeField] StatsUi _statsUi;

	public int StatValue { get; private set; }
	public int Level { get; private set; }
	public int Attack { get; private set; }
	public int Hp { get; private set; }
	public int Defence { get; private set; }

	public void SetStats(int level, int attack, int hp, int defence)
	{
		Level = level;
		Attack = attack;
		Hp = hp;
		Defence = defence;
	}

	public void AddStats(int statsToAdd)
	{
		StatValue += statsToAdd;
		_statsUi.UpdateStats(StatValue);
	}
}
