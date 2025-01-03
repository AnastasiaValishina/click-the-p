using TMPro;
using UnityEngine;

public class StatsUi : MonoBehaviour
{
	[SerializeField] TMP_Text _statsText;
	[SerializeField] TMP_Text _levelText;
	[SerializeField] TMP_Text _attackText;
	[SerializeField] TMP_Text _hpText;
	[SerializeField] TMP_Text _defenceText;

	private void Start()
	{
		
	}

	public void UpdateStats(int statsValue)
	{
		_statsText.text = statsValue.ToString();
	}
}
