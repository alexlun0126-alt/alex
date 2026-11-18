using System.Collections;
using System.Collections.Generic;
using MSCLoader;
using UnityEngine;

namespace NewHouse;

public class CosasGarageBehaviour : MonoBehaviour
{
	public class SaveData
	{
		public List<SaveDataList> save = new List<SaveDataList>();
	}

	public class SaveDataList
	{
		public float herramientaposX;

		public float herramientaposY;

		public float herramientaposZ;

		public float herramientarotX;

		public float herramientarotY;

		public float herramientarotZ;

		public float radiposX;

		public float radiposY;

		public float radiposZ;

		public float radirotX;

		public float radirotY;

		public float radirotZ;

		public float garrafasgposX;

		public float garrafasgposY;

		public float garrafasgposZ;

		public float garrafasgrotX;

		public float garrafasgrotY;

		public float garrafasgrotZ;

		public float garrafasdposX;

		public float garrafasdposY;

		public float garrafasdposZ;

		public float garrafasdrotX;

		public float garrafasdrotY;

		public float garrafasdrotZ;

		public float linternposX;

		public float linternposY;

		public float linternposZ;

		public float linternrotX;

		public float linternrotY;

		public float linternrotZ;
	}

	private GameObject jac;

	private GameObject jacclone;

	private Transform posijack;

	private GameObject bateria;

	private GameObject bateriaclone;

	private GameObject herramienta;

	private GameObject herramientas;

	private GameObject lintern;

	private GameObject linterna;

	private GameObject radi;

	private GameObject radio;

	private GameObject hoi;

	private GameObject hoist;

	private Transform posihoist;

	private GameObject garrafasg;

	private GameObject garrafasd;

	private GameObject garrafag;

	private GameObject garrafad;

	private Transform posigarrafa;

	private GameObject Player;

	private GameObject revista;

	public GameObject posirevista;

	private GameObject casavieja;

	private GameObject casanueva;

	private GameObject items;

	public float distancianueva;

	public float distanciavieja;

	public bool ennueva;

	public bool loaded;

	private void Start()
	{
		((MonoBehaviour)this).StartCoroutine(SetupMod());
	}

	private IEnumerator SetupMod()
	{
		while ((Object)(object)GameObject.Find("YARD") == (Object)null)
		{
			yield return null;
		}
		if (GameObject.Find("ITEMS") != null)
		{
			items = GameObject.Find("ITEMS").gameObject;
		}
		else
		{
			ModConsole.Error("No localize ITEMS");
			items = null;
		}
		if (GameObject.Find("ITEMS/parts magazine(itemx)") != null)
		{
			revista = GameObject.Find("ITEMS/parts magazine(itemx)").gameObject;
			posirevista = GameObject.Find("sitiorevista").gameObject;
			revista.transform.SetParent(items.transform);
			revista.transform.localPosition = new Vector3(1.4798f, 0.4261f, -11.267f);
			revista.transform.localRotation = Quaternion.Euler(0f, 280f, 0f);
		}
		else
		{
			ModConsole.Error("No localize part magazine");
			revista = null;
		}
		casanueva = ((Component)this).gameObject;
		casavieja = GameObject.Find("YARD/Building").gameObject;
		if (GameObject.Find("spanner set(itemx)") != null)
		{
			herramientas = GameObject.Find("spanner set(itemx)").gameObject;
			herramienta = Object.Instantiate<GameObject>(herramientas);
			((Object)herramienta).name = "spanner set2(itemx)";
			herramienta.transform.SetParent(posirevista.transform);
		}
		else
		{
			ModConsole.Error("No localize spanner set");
			herramientas = null;
			herramienta = null;
		}
		if (GameObject.Find("flashlight(itemx)") != null)
		{
			linterna = GameObject.Find("flashlight(itemx)").gameObject;
			lintern = Object.Instantiate<GameObject>(linterna);
			((Object)lintern).name = "flashlight2(itemx)";
			lintern.transform.SetParent(posirevista.transform);
		}
		else
		{
			ModConsole.Error("No localize flashlight");
			linterna = null;
			lintern = null;
		}
		if (GameObject.Find("radio(itemx)") != null)
		{
			radio = GameObject.Find("radio(itemx)").gameObject;
			radi = Object.Instantiate<GameObject>(radio);
			((Object)radi).name = "radio2(itemx)";
			radi.transform.SetParent(posirevista.transform);
		}
		else
		{
			ModConsole.Error("No localize radio");
			radio = null;
			radi = null;
		}
		if (GameObject.Find("motor hoist(itemx)") != null)
		{
			hoist = GameObject.Find("motor hoist(itemx)").gameObject;
			posihoist = GameObject.Find("sitiohoist").transform;
			hoi = Object.Instantiate<GameObject>(hoist);
			((Object)hoi).name = "motor hoist(itemx)";
			hoi.transform.SetParent(posihoist);
			hoi.transform.localPosition = new Vector3(0f, 0f, -0.199f);
			hoi.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
		}
		else
		{
			ModConsole.Error("No localize motor hoist");
			hoist = null;
			hoi = null;
		}
		posigarrafa = GameObject.Find("sitiogarrafas").transform;
		if (GameObject.Find("gasoline(itemx)") != null)
		{
			garrafag = GameObject.Find("gasoline(itemx)").gameObject;
			garrafasg = Object.Instantiate<GameObject>(garrafag);
			((Object)garrafasg).name = "gasoline2(itemx)";
		}
		else
		{
			ModConsole.Error("No localize gasoline");
			garrafag = null;
			garrafasg = null;
		}
		if (GameObject.Find("diesel(itemx)") != null)
		{
			garrafad = GameObject.Find("diesel(itemx)").gameObject;
			garrafasd = Object.Instantiate<GameObject>(garrafad);
			((Object)garrafasd).name = "diesel2(itemx)";
		}
		else
		{
			ModConsole.Error("No localize diesel");
			garrafad = null;
			garrafasd = null;
		}
		posijack = GameObject.Find("sitiojack").transform;
		if (GameObject.Find("floor jack(itemx)") != null)
		{
			jac = GameObject.Find("floor jack(itemx)").gameObject;
			jacclone = Object.Instantiate<GameObject>(jac);
			((Object)jacclone).name = "floor jack(itemx)";
			jacclone.transform.SetParent(posijack);
			jacclone.transform.localPosition = new Vector3(0f, 0f, -0.1077329f);
			jacclone.transform.localRotation = Quaternion.Euler(90f, 0f, 0f);
		}
		else
		{
			ModConsole.Error("No localize floor jack");
			jac = null;
			jacclone = null;
		}
		if (GameObject.Find("YARD/Building/Garage/BatteryCharger") != null)
		{
			bateria = GameObject.Find("YARD/Building/Garage/BatteryCharger").gameObject;
			bateriaclone = Object.Instantiate<GameObject>(bateria);
			bateriaclone.transform.SetParent(posirevista.transform);
			bateriaclone.transform.localPosition = new Vector3(0.2f, 0.4922423f, -0.1f);
			bateriaclone.transform.localRotation = Quaternion.Euler(0f, 0f, 180f);
			((Component)bateriaclone.transform.FindChild("Trigger")).GetComponent<PlayMakerFSM>().FsmVariables.FindFsmFloat("ChargingSpeed").Value = 0.7f;
		}
		else
		{
			ModConsole.Error("No localize batterycharger");
			bateria = null;
			bateriaclone = null;
		}
		ennueva = false;
		Load();
	}

	public void Save()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		SaveData saveData = new SaveData();
		SaveDataList item = new SaveDataList
		{
			herramientaposX = herramienta.transform.position.x,
			herramientaposY = herramienta.transform.position.y,
			herramientaposZ = herramienta.transform.position.z,
			herramientarotX = herramienta.transform.eulerAngles.x,
			herramientarotY = herramienta.transform.eulerAngles.y,
			herramientarotZ = herramienta.transform.eulerAngles.z,
			radiposX = radi.transform.position.x,
			radiposY = radi.transform.position.y,
			radiposZ = radi.transform.position.z,
			radirotX = radi.transform.eulerAngles.x,
			radirotY = radi.transform.eulerAngles.y,
			radirotZ = radi.transform.eulerAngles.z,
			garrafasgposX = garrafasg.transform.position.x,
			garrafasgposY = garrafasg.transform.position.y,
			garrafasgposZ = garrafasg.transform.position.z,
			garrafasgrotX = garrafasg.transform.eulerAngles.x,
			garrafasgrotY = garrafasg.transform.eulerAngles.y,
			garrafasgrotZ = garrafasg.transform.eulerAngles.z,
			garrafasdposX = garrafasd.transform.position.x,
			garrafasdposY = garrafasd.transform.position.y,
			garrafasdposZ = garrafasd.transform.position.z,
			garrafasdrotX = garrafasd.transform.eulerAngles.x,
			garrafasdrotY = garrafasd.transform.eulerAngles.y,
			garrafasdrotZ = garrafasd.transform.eulerAngles.z,
			linternposX = lintern.transform.position.x,
			linternposY = lintern.transform.position.y,
			linternposZ = lintern.transform.position.z,
			linternrotX = lintern.transform.eulerAngles.x,
			linternrotY = lintern.transform.eulerAngles.y,
			linternrotZ = lintern.transform.eulerAngles.z
		};
		saveData.save.Add(item);
		SaveLoad.SerializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, saveData, "NewHouse-garage.save");
	}

	private void Load()
	{
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		SaveData saveData = SaveLoad.DeserializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, "NewHouse-garage.save");
		if (saveData != null)
		{
			herramienta.transform.position = new Vector3(saveData.save[0].herramientaposX, saveData.save[0].herramientaposY, saveData.save[0].herramientaposZ);
			herramienta.transform.eulerAngles = new Vector3(saveData.save[0].herramientarotX, saveData.save[0].herramientarotY, saveData.save[0].herramientarotZ);
			lintern.transform.position = new Vector3(saveData.save[0].linternposX, saveData.save[0].linternposY, saveData.save[0].linternposZ);
			lintern.transform.eulerAngles = new Vector3(saveData.save[0].linternrotX, saveData.save[0].linternrotY, saveData.save[0].linternrotZ);
			radi.transform.position = new Vector3(saveData.save[0].radiposX, saveData.save[0].radiposY, saveData.save[0].radiposZ);
			radi.transform.eulerAngles = new Vector3(saveData.save[0].radirotX, saveData.save[0].radirotY, saveData.save[0].radirotZ);
			garrafasd.transform.position = new Vector3(saveData.save[0].garrafasdposX, saveData.save[0].garrafasdposY, saveData.save[0].garrafasdposZ);
			garrafasd.transform.eulerAngles = new Vector3(saveData.save[0].garrafasdrotX, saveData.save[0].garrafasdrotY, saveData.save[0].garrafasdrotZ);
			garrafasg.transform.position = new Vector3(saveData.save[0].garrafasgposX, saveData.save[0].garrafasgposY, saveData.save[0].garrafasgposZ);
			garrafasg.transform.eulerAngles = new Vector3(saveData.save[0].garrafasgrotX, saveData.save[0].garrafasgrotY, saveData.save[0].garrafasgrotZ);
		}
		else
		{
			herramienta.transform.localPosition = new Vector3(0f, 0.2f, 0f);
			herramienta.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
			lintern.transform.localPosition = new Vector3(0f, 0.4f, 0f);
			lintern.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
			radi.transform.localPosition = new Vector3(0f, 0.6f, 0f);
			radi.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
			garrafasd.transform.position = new Vector3(-1739.412f, 7.037001f, -171.638f);
			garrafasd.transform.eulerAngles = new Vector3(270f, 172.2427f, 0f);
			garrafasg.transform.position = new Vector3(-1739.059f, 7.037001f, -171.6625f);
			garrafasg.transform.eulerAngles = new Vector3(270f, 174.5802f, 0f);
		}
		loaded = true;
	}

	private void Update()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)((Component)this).transform).GetComponent<CasaBehaviour>().playerspawn)
		{
			return;
		}
		if ((Object)(object)Player == (Object)null)
		{
			Player = GameObject.Find("PLAYER").gameObject;
			return;
		}
		if (!loaded)
		{
			Load();
		}
		distancianueva = Vector3.Distance(Player.transform.position, casanueva.transform.position);
		distanciavieja = Vector3.Distance(Player.transform.position, casavieja.transform.position);
		if ((Object)(object)revista != (Object)null)
		{
			if (distancianueva <= 40f && !ennueva)
			{
				revista.transform.localPosition = new Vector3(0f, 0f, -0.15f);
				revista.transform.localRotation = Quaternion.Euler(0f, 90f, 90f);
				ennueva = true;
			}
			if (distanciavieja <= 40f && ennueva)
			{
				revista.transform.localPosition = new Vector3(1.4798f, 0.4261f, -11.267f);
				revista.transform.localRotation = Quaternion.Euler(0f, 280f, 0f);
				ennueva = false;
			}
		}
	}
}
