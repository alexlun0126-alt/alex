using System.Collections.Generic;
using HutongGames.PlayMaker;
using MSCLoader;
using UnityEngine;

namespace NewHouse;

public class MandoBehaviour : MonoBehaviour
{
	public class SaveData
	{
		public List<SaveDataList> save = new List<SaveDataList>();
	}

	public class SaveDataList
	{
		public float posX;

		public float posY;

		public float posZ;

		public float rotX;

		public float rotY;

		public float rotZ;
	}

	private Collider botonmando;

	private GameObject receptormando;

	public bool aperturagate;

	private CasaBehaviour general;

	private PuertaBehaviour puertas;

	private FsmBool m_guiUseBool;

	private void Start()
	{
		((Object)((Component)this).gameObject).name = "Remote Control Gate(Clone)";
		((Component)this).gameObject.layer = LayerMask.NameToLayer("Parts");
		((Component)this).gameObject.tag = "PART";
		general = GameObject.Find("caseron(Clone)").GetComponent<CasaBehaviour>();
		receptormando = ((Component)((Component)general).transform.FindChild("receptormando")).gameObject;
		botonmando = ((Component)((Component)this).transform.FindChild("remoto/zer06/botonmando")).GetComponent<Collider>();
		m_guiUseBool = PlayMakerGlobals.Instance.Variables.FindFsmBool("GUIuse");
		puertas = ((Component)((Component)general).transform.FindChild("utiles/puertas")).GetComponent<PuertaBehaviour>();
		Load();
	}

	public void Save()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		if (general.vendido)
		{
			SaveData saveData = new SaveData();
			SaveDataList item = new SaveDataList
			{
				posX = ((Component)this).transform.position.x,
				posY = ((Component)this).transform.position.y,
				posZ = ((Component)this).transform.position.z,
				rotX = ((Component)this).transform.eulerAngles.x,
				rotY = ((Component)this).transform.eulerAngles.y,
				rotZ = ((Component)this).transform.eulerAngles.z
			};
			saveData.save.Add(item);
			SaveLoad.SerializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, saveData, "NewHouse-remote.save");
		}
	}

	private void Load()
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		SaveData saveData = SaveLoad.DeserializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, "NewHouse-remote.save");
		if (saveData != null)
		{
			((Component)this).transform.position = new Vector3(saveData.save[0].posX, saveData.save[0].posY, saveData.save[0].posZ);
			((Component)this).transform.eulerAngles = new Vector3(saveData.save[0].rotX, saveData.save[0].rotY, saveData.save[0].rotZ);
		}
		else
		{
			((Component)this).transform.localPosition = new Vector3(-2.108005f, 1f, -5.223052f);
		}
	}

	private void Update()
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GameObject.Find("PLAYER") != (Object)null))
		{
			return;
		}
		if (Input.GetKey((KeyCode)308) && Input.GetKeyDown((KeyCode)114))
		{
			((Component)this).transform.SetParent(((Component)general).transform);
			((Component)this).transform.localPosition = new Vector3(-2.108f, 0.956f, -5.223f);
			((Component)this).transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
		}
		RaycastHit[] array = Physics.RaycastAll(Camera.main.ScreenPointToRay(Input.mousePosition), 1.5f);
		for (int i = 0; i < array.Length; i++)
		{
			RaycastHit val = array[i];
			if (!((Object)(object)val.collider == (Object)(object)botonmando))
			{
				continue;
			}
			m_guiUseBool.Value = true;
			if (!cInput.GetButtonDown("Use") || !((Component)general).GetComponent<ElectricidadBehaviour>().electricidadon)
			{
				continue;
			}
			RaycastHit[] array2 = Physics.SphereCastAll(((Component)this).transform.position, 20f, ((Component)this).transform.forward);
			for (int j = 0; j < array2.Length; j++)
			{
				RaycastHit val2 = array2[j];
				if ((Object)(object)val2.collider == (Object)(object)receptormando.GetComponent<Collider>())
				{
					aperturagate = !aperturagate;
					puertas.Operapuerta(aperturagate);
				}
			}
		}
	}
}
