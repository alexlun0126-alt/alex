using HutongGames.PlayMaker;
using UnityEngine;

namespace NewHouse;

public class CajaSofaBehaviour : MonoBehaviour
{
	private FsmBool m_guiUseBool;

	private AudioSource audi;

	private AudioClip audiclip;

	public FsmBool _playerInMenu;

	public bool showGUI;

	private readonly Rect _guiBox = new Rect((float)(Screen.width / 2 - 190), (float)(Screen.height / 2 - 200), 280f, 180f);

	public bool blanco;

	public bool verde;

	public bool azul;

	public bool raro;

	public bool confirmado;

	private void OnGUI()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		GUIStyle val = new GUIStyle
		{
			alignment = (TextAnchor)1
		};
		val.normal.textColor = Color.red;
		val.fontSize = 20;
		if (showGUI)
		{
			GUI.ModalWindow(299, _guiBox, (WindowFunction)GuiSettingsWindow, "Purchase Furniture Options");
		}
	}

	private void GuiSettingsWindow(int windowId)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		GUI.skin.GetStyle("Label").alignment = (TextAnchor)1;
		if (GUI.Button(new Rect(30f, 150f, 100f, 30f), "Exit"))
		{
			_playerInMenu.Value = false;
			showGUI = false;
		}
		if (GUI.Button(new Rect(150f, 150f, 100f, 30f), "Confirm"))
		{
			confirmado = true;
			_playerInMenu.Value = false;
			showGUI = false;
		}
		blanco = GUI.Toggle(new Rect(10f, 30f, 300f, 30f), blanco, "White.");
		verde = GUI.Toggle(new Rect(10f, 60f, 300f, 30f), verde, "Green.");
		azul = GUI.Toggle(new Rect(10f, 90f, 300f, 30f), azul, "Blue.");
		raro = GUI.Toggle(new Rect(10f, 120f, 300f, 30f), raro, "Strange");
	}

	private void Start()
	{
		((Object)((Component)this).gameObject).name = "CARDBOARD(Clone)";
		((Component)this).gameObject.layer = LayerMask.NameToLayer("Parts");
		((Component)this).gameObject.tag = "PART";
		m_guiUseBool = PlayMakerGlobals.Instance.Variables.FindFsmBool("GUIuse");
		audi = ((Component)this).GetComponent<AudioSource>();
		audiclip = audi.clip;
		_playerInMenu = PlayMakerGlobals.Instance.Variables.GetFsmBool("PlayerInMenu");
	}

	private void Update()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GameObject.Find("PLAYER") != (Object)null))
		{
			return;
		}
		if (showGUI)
		{
			_playerInMenu.Value = true;
		}
		if (blanco && confirmado)
		{
			SofaBehaviour sofaBehaviour = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("SofaBlancoPrefab")).AddComponent<SofaBehaviour>();
			((Component)sofaBehaviour).transform.position = ((Component)this).transform.position;
			sofaBehaviour.blanco = true;
			sofaBehaviour.verde = false;
			sofaBehaviour.azul = false;
			sofaBehaviour.raro = false;
			AudioSource.PlayClipAtPoint(audiclip, ((Component)this).transform.position, 1f);
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
		if (verde && confirmado)
		{
			SofaBehaviour sofaBehaviour2 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("SofaVerdePrefab")).AddComponent<SofaBehaviour>();
			((Component)sofaBehaviour2).transform.position = ((Component)this).transform.position;
			sofaBehaviour2.blanco = false;
			sofaBehaviour2.verde = true;
			sofaBehaviour2.azul = false;
			sofaBehaviour2.raro = false;
			AudioSource.PlayClipAtPoint(audiclip, ((Component)this).transform.position, 1f);
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
		if (azul && confirmado)
		{
			SofaBehaviour sofaBehaviour3 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("SofaAzulPrefab")).AddComponent<SofaBehaviour>();
			((Component)sofaBehaviour3).transform.position = ((Component)this).transform.position;
			sofaBehaviour3.blanco = false;
			sofaBehaviour3.verde = false;
			sofaBehaviour3.azul = true;
			sofaBehaviour3.raro = false;
			AudioSource.PlayClipAtPoint(audiclip, ((Component)this).transform.position, 1f);
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
		if (raro && confirmado)
		{
			SofaBehaviour sofaBehaviour4 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("SofaRaroPrefab")).AddComponent<SofaBehaviour>();
			((Component)sofaBehaviour4).transform.position = ((Component)this).transform.position;
			sofaBehaviour4.blanco = false;
			sofaBehaviour4.verde = false;
			sofaBehaviour4.azul = false;
			sofaBehaviour4.raro = true;
			AudioSource.PlayClipAtPoint(audiclip, ((Component)this).transform.position, 1f);
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
		if (Vector3.Distance(((Component)GameObject.Find("PLAYER")).transform.position, transform.position) <= 10f)
		{
		RaycastHit[] array = Physics.RaycastAll(Camera.main.ScreenPointToRay(Input.mousePosition), 1f);
		for (int i = 0; i < array.Length; i++)
		{
			RaycastHit val = array[i];
			if ((Object)(object)((Component)val.collider).gameObject == (Object)(object)((Component)this).gameObject)
			{
				m_guiUseBool.Value = true;
				if (cInput.GetButtonDown("Use"))
				{
					showGUI = true;
				}
			}
		}
		}
	}

	public CajaSofaBehaviour()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
	}
}
