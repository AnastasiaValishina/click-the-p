using UnityEngine;
using UnityEngine.UI;

public abstract class FieldButton : MonoBehaviour
{
	[SerializeField] protected Image _fillImage;
	[SerializeField] protected int _maxHp;

	public bool IsCompleted { get; set; }
	public bool IsClaimed { get; set; }

	protected float _hp;

	Button _button;

	private void Awake()
	{
		_button = GetComponent<Button>();
		_button.onClick.AddListener(OnButtonClick);
		_hp = _maxHp;
		_fillImage.fillAmount = 1;
	}

	public abstract void OnButtonClick();

/*	public void Claim()
	{
		IsClaimed = true;
	}

	public void Reset()
	{
		IsCompleted = false;
		IsClaimed = false;
		_hp = _maxHp;
	}*/
}
