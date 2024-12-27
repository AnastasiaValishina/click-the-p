using UnityEngine;

public class Monster : FieldButton
{
	[SerializeField] float _restoreAmount;
	[SerializeField] private float _restoreInterval;

	bool _isRestoring = false;
	float _restoreTimer = 0f;


	private void Update()
	{
		if (_isRestoring && _hp < _maxHp)
		{
			_restoreTimer += Time.deltaTime;

			if (_restoreTimer >= _restoreInterval)
			{
				_hp += _restoreAmount;
				_hp = Mathf.Min(_hp, _maxHp); 

				_fillImage.fillAmount = _hp / _maxHp;

				_restoreTimer = 0f;
			}

			if (_hp >= _maxHp)
			{
				_isRestoring = false;
			}
		}
	}

	public override void OnButtonClick()
	{
		_hp -= 20;

		_fillImage.fillAmount = (float)_hp / _maxHp;

		_isRestoring = true;

		if (_hp <= 0)
		{
			IsCompleted = true;
			_isRestoring = false;
		}
	}
}
