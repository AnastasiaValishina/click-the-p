using TMPro;
using UnityEngine;

public class Mission : FieldButton
{	
	[SerializeField] TMP_Text _nameText;	
	[SerializeField] int _reward;

	public override void OnButtonClick()
	{
		_hp -= 20;

		_fillImage.fillAmount = (float)_hp / _maxHp;

		if (_hp <= 0)
		{
			IsCompleted = true;
		}
	}
}
