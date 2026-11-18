using HutongGames.PlayMaker;
using UnityEngine;

namespace NewHouse;

public class CartaBehaviour : MonoBehaviour
{
	private ElectricidadBehaviour consumo;

	private FsmBool m_guiUseBool;

	private FsmString m_guiInteractString;

	private GameObject sheets;

	private GameObject player;

	public bool muestrafactura;

	public FsmBool _playerInMenu;

	public bool checkplayer;

	private void Start()
	{
		consumo = ((Component)((Component)this).transform.root).GetComponent<ElectricidadBehaviour>();
		m_guiUseBool = PlayMakerGlobals.Instance.Variables.FindFsmBool("GUIuse");
		m_guiInteractString = PlayMakerGlobals.Instance.Variables.FindFsmString("GUIinteraction");
		_playerInMenu = PlayMakerGlobals.Instance.Variables.GetFsmBool("PlayerInMenu");
	}

	public void Loapagado(float factura)
	{
		FsmFloat val = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
		val.Value -= factura;
		_playerInMenu.Value = false;
		sheets.SetActive(false);
		FsmVariables.GlobalVariables.FindFsmBool("PlayerStop").Value = false;
		muestrafactura = false;
		consumo.consumor = 0f;
		((Component)((Component)this).transform.root).GetComponent<CasaBehaviour>().pagado = true;
		((Component)((Component)this).transform.root).GetComponent<CasaBehaviour>().semanassinpagar = 0;
		((Component)((Component)this).transform.root).GetComponent<CasaBehaviour>().moroso = false;
		if (((Component)((Component)this).transform.root).GetComponent<CasaBehaviour>().checkmoroso)
		{
			((Component)((Component)this).transform.root).GetComponent<ElectricidadBehaviour>().electricidadon = true;
		}
		((Component)this).gameObject.SetActive(false);
	}

	private void Update()
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)player == (Object)null)
		{
			player = GameObject.Find("PLAYER").gameObject;
			return;
		}
		if (!checkplayer)
		{
			sheets = ((Component)Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("FacturaLuz")).AddComponent<FacturaBehaviour>()).gameObject;
			sheets.transform.SetParent(GameObject.Find("PLAYER/Pivot/AnimPivot/Camera/FPSCamera/FPSCamera").transform);
			sheets.transform.localPosition = new Vector3(0f, 0f, 0.4f);
			sheets.transform.localEulerAngles = new Vector3(90f, 180f, 0f);
			checkplayer = true;
		}
		if ((Object)(object)consumo == (Object)null)
		{
			consumo = ((Component)((Component)this).transform.root).GetComponent<ElectricidadBehaviour>();
		}
		if (Vector3.Distance(((Component)GameObject.Find("PLAYER")).transform.position, transform.position) <= 10f)
		{
		RaycastHit[] array = Physics.RaycastAll(Camera.main.ScreenPointToRay(Input.mousePosition), 1.5f);
		for (int i = 0; i < array.Length; i++)
		{
			RaycastHit val = array[i];
			if ((Object)(object)val.collider == (Object)(object)((Component)this).GetComponent<Collider>())
			{
				m_guiUseBool.Value = true;
				m_guiInteractString.Value = "OPEN ENVELEOPE";
				if (Input.GetMouseButtonDown(0))
				{
					muestrafactura = true;
					sheets.GetComponent<FacturaBehaviour>().GetConsumo(consumo.consumor);
				}
			}
		}
		}
		if (muestrafactura)
		{
			sheets.SetActive(true);
			_playerInMenu.Value = true;
			FsmVariables.GlobalVariables.FindFsmBool("PlayerStop").Value = true;
		}
		if (!muestrafactura)
		{
			sheets.SetActive(false);
		}
	}
}
