using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Mission : MonoBehaviour
{
	[SerializeField] Image _fillImage;
	[SerializeField] TMP_Text _nameText;
	[SerializeField] int _maxHp = 450;

	public bool IsCompleted { get; set; }
	public bool IsClaimed { get; set; }

	Button _button;
	int _hp;

	private void Awake()
	{
		_button = GetComponent<Button>();
		_button.onClick.AddListener(OnMissionClick);
		_hp = _maxHp;
		_fillImage.fillAmount = 1;
	}

	private void OnMissionClick()
	{
		_hp -= 10;

		_fillImage.fillAmount = (float)_hp / _maxHp;

		if (_hp <= 0)
		{
			IsCompleted = true;
		}
	}

	public void Claim()
	{
		IsClaimed = true;
	}

	public void Reset()
	{
		IsCompleted = false;
		IsClaimed = false;
		_hp = _maxHp;
	}
}
