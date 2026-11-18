using System.Collections.Generic;
using HutongGames.PlayMaker;
using MSCLoader;
using UnityEngine;

namespace NewHouse;

public class TelefonoBehaviour : MonoBehaviour
{
	public class SaveData
	{
		public List<SaveDataList> save = new List<SaveDataList>();
	}

	public class SaveDataList
	{
		public bool enchufetelf;
	}

	private FsmBool m_guiUseBool;

	private AudioSource m_ringAudioSource;

	private AudioSource telfcogido;

	private AudioSource telfcolgado;

	private GameObject auricular;

	private Collider auricularcol;

	private Collider enchufecol;

	private PlayMakerFSM fsmorigi;

	public PlayMakerFSM fsm2origi;

	private bool cogido;

	public bool enchufado = true;

	private GameObject telefonoon;

	private GameObject telefonooff;

	public float distanciatelf;

	private GameObject log;

	private GameObject sitiomapa;

	private GameObject dardo1;

	private GameObject dardo2;

	private GameObject dardo3;

	private GameObject dardo4;

	private GameObject dardo5;

	private GameObject dardo6;

	private GameObject dardo7;

	private GameObject dardo1clone;

	private GameObject dardo2clone;

	private GameObject dardo3clone;

	private GameObject dardo4clone;

	private GameObject dardo5clone;

	private GameObject dardo6clone;

	private GameObject dardo7clone;

	private CasaBehaviour casa;

	private void Start()
	{
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		casa = ((Component)((Component)this).transform.root).GetComponent<CasaBehaviour>();
		m_guiUseBool = PlayMakerGlobals.Instance.Variables.FindFsmBool("GUIuse");
		if (Object.op_Implicit((Object)(object)GameObject.Find("YARD/Building").transform.FindChild("LIVINGROOM")))
		{
			log = ((Component)((Component)this).transform.FindChild("utiles/telefono")).gameObject;
			auricular = ((Component)log.transform.FindChild("auricular")).gameObject;
			auricularcol = ((Component)log.transform.FindChild("auricularcol")).GetComponent<Collider>();
			m_ringAudioSource = ((Component)auricularcol).GetComponent<AudioSource>();
			telfcogido = log.GetComponent<AudioSource>();
			GameObject gameObject = ((Component)log.transform.FindChild("telefonomodel")).gameObject;
			telfcolgado = gameObject.GetComponent<AudioSource>();
			telefonoon = ((Component)log.transform.FindChild("telefonoon")).gameObject;
			telefonooff = ((Component)log.transform.FindChild("telefonooff")).gameObject;
			telefonooff.SetActive(false);
			enchufecol = ((Component)log.transform.FindChild("enchufe telefono col")).GetComponent<Collider>();
			fsmorigi = GameObject.Find("YARD/Building/LIVINGROOM/Telephone/Logic/PhoneLogic").GetComponent<PlayMakerFSM>();
			fsm2origi = GameObject.Find("YARD/Building/LIVINGROOM/Telephone/Logic/Ring").GetComponent<PlayMakerFSM>();
			Transform val = Object.Instantiate<Transform>(GameObject.Find("YARD/Building/LIVINGROOM/LOD_livingroom").gameObject.transform.FindChild("MAP"));
			sitiomapa = ((Component)((Component)this).transform.FindChild("utiles/posimap")).gameObject;
			((Component)val).transform.SetParent(sitiomapa.transform);
			((Component)val).transform.localPosition = new Vector3(0.1433f, 0f, 0f);
			((Component)val).transform.localRotation = Quaternion.Euler(270f, 225f, 0f);
			dardo1 = GameObject.Find("YARD/Building/LIVINGROOM/LOD_livingroom/MAP/Darts/Shit1").gameObject;
			dardo1clone = ((Component)((Component)this).transform.FindChild("utiles/posimap/MAP(Clone)/Darts/Shit1")).gameObject;
			dardo2 = GameObject.Find("YARD/Building/LIVINGROOM/LOD_livingroom/MAP/Darts/Shit2").gameObject;
			dardo2clone = ((Component)((Component)this).transform.FindChild("utiles/posimap/MAP(Clone)/Darts/Shit2")).gameObject;
			dardo3 = GameObject.Find("YARD/Building/LIVINGROOM/LOD_livingroom/MAP/Darts/Shit3").gameObject;
			dardo3clone = ((Component)((Component)this).transform.FindChild("utiles/posimap/MAP(Clone)/Darts/Shit3")).gameObject;
			dardo4 = GameObject.Find("YARD/Building/LIVINGROOM/LOD_livingroom/MAP/Darts/Shit4").gameObject;
			dardo4clone = ((Component)((Component)this).transform.FindChild("utiles/posimap/MAP(Clone)/Darts/Shit4")).gameObject;
			dardo5 = GameObject.Find("YARD/Building/LIVINGROOM/LOD_livingroom/MAP/Darts/Shit5").gameObject;
			dardo5clone = ((Component)((Component)this).transform.FindChild("utiles/posimap/MAP(Clone)/Darts/Shit5")).gameObject;
			dardo6 = GameObject.Find("YARD/Building/LIVINGROOM/LOD_livingroom/MAP/Darts/Wood1").gameObject;
			dardo6clone = ((Component)((Component)this).transform.FindChild("utiles/posimap/MAP(Clone)/Darts/Wood1")).gameObject;
			dardo7 = GameObject.Find("YARD/Building/LIVINGROOM/LOD_livingroom/MAP/Darts/BoozeJob").gameObject;
			dardo7clone = ((Component)((Component)this).transform.FindChild("utiles/posimap/MAP(Clone)/Darts/BoozeJob")).gameObject;
			Load();
		}
		else
		{
			fsmorigi = null;
			fsm2origi = null;
			log.SetActive(false);
			auricularcol = null;
			enchufecol = null;
			ModConsole.Error("No Phone , Restore Old house");
		}
	}

	private void Load()
	{
		SaveData saveData = SaveLoad.DeserializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, "NewHouse-phone.save");
		if (saveData != null)
		{
			enchufado = saveData.save[0].enchufetelf;
		}
	}

	public void Save(bool vendi)
	{
		if (vendi)
		{
			SaveData saveData = new SaveData();
			SaveDataList item = new SaveDataList
			{
				enchufetelf = enchufado
			};
			saveData.save.Add(item);
			SaveLoad.SerializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, saveData, "NewHouse-phone.save");
		}
	}

	private void Update()
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GameObject.Find("PLAYER") != (Object)null))
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("YARD/Building").transform.FindChild("LIVINGROOM")) && (Object)(object)dardo1clone != (Object)null)
		{
			dardo1clone.SetActive(dardo1.activeSelf);
			dardo2clone.SetActive(dardo2.activeSelf);
			dardo3clone.SetActive(dardo3.activeSelf);
			dardo4clone.SetActive(dardo4.activeSelf);
			dardo5clone.SetActive(dardo5.activeSelf);
			dardo6clone.SetActive(dardo6.activeSelf);
			dardo7clone.SetActive(dardo7.activeSelf);
		}
		RaycastHit[] array = Physics.RaycastAll(Camera.main.ScreenPointToRay(Input.mousePosition), 1.5f);
		foreach (RaycastHit hit in array)
		{
			if (casa.vendido && (Object)(object)fsmorigi != (Object)null)
			{
				SetupTelefono();
				RayTelefono(hit);
			}
		}
	}

	private void SetupTelefono()
	{
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		if (enchufado)
		{
			telefonoon.SetActive(true);
			telefonooff.SetActive(false);
		}
		if (!enchufado)
		{
			telefonoon.SetActive(false);
			telefonooff.SetActive(true);
		}
		if (!cogido && enchufado && ((Component)fsm2origi).gameObject.activeSelf && ((Component)this).GetComponent<ElectricidadBehaviour>().electricidadon)
		{
			if (fsm2origi.FsmVariables.FindFsmString("Topic").Value == "FLEETARISHIT" && !m_ringAudioSource.isPlaying)
			{
				m_ringAudioSource.PlayDelayed(2f);
			}
			if (fsm2origi.FsmVariables.FindFsmString("Topic").Value == "SHIT1" && !m_ringAudioSource.isPlaying)
			{
				m_ringAudioSource.PlayDelayed(2f);
			}
			if (fsm2origi.FsmVariables.FindFsmString("Topic").Value == "DRUNK" && !m_ringAudioSource.isPlaying)
			{
				m_ringAudioSource.PlayDelayed(2f);
			}
			if (fsm2origi.FsmVariables.FindFsmString("Topic").Value == "REPAIR" && !m_ringAudioSource.isPlaying)
			{
				m_ringAudioSource.PlayDelayed(2f);
			}
			if (fsm2origi.FsmVariables.FindFsmString("Topic").Value == "WOOD1" && !m_ringAudioSource.isPlaying)
			{
				m_ringAudioSource.PlayDelayed(2f);
			}
			if (fsm2origi.FsmVariables.FindFsmString("Topic").Value == "ORDER" && !m_ringAudioSource.isPlaying)
			{
				m_ringAudioSource.PlayDelayed(2f);
			}
			if (fsm2origi.FsmVariables.FindFsmString("Topic").Value == "SHIT2" && !m_ringAudioSource.isPlaying)
			{
				m_ringAudioSource.PlayDelayed(2f);
			}
			if (fsm2origi.FsmVariables.FindFsmString("Topic").Value == "SHIT3" && !m_ringAudioSource.isPlaying)
			{
				m_ringAudioSource.PlayDelayed(2f);
			}
			if (fsm2origi.FsmVariables.FindFsmString("Topic").Value == "SHIT4" && !m_ringAudioSource.isPlaying)
			{
				m_ringAudioSource.PlayDelayed(2f);
			}
			if (fsm2origi.FsmVariables.FindFsmString("Topic").Value == "SHIT5" && !m_ringAudioSource.isPlaying)
			{
				m_ringAudioSource.PlayDelayed(2f);
			}
			if (fsm2origi.FsmVariables.FindFsmString("Topic").Value == "FUEL" && !m_ringAudioSource.isPlaying)
			{
				m_ringAudioSource.PlayDelayed(2f);
			}
			if (fsm2origi.FsmVariables.FindFsmString("Topic").Value == "FERNDALE" && !m_ringAudioSource.isPlaying)
			{
				m_ringAudioSource.PlayDelayed(2f);
			}
			if (fsm2origi.FsmVariables.FindFsmString("Topic").Value == "FLEETARIRALLY" && !m_ringAudioSource.isPlaying)
			{
				m_ringAudioSource.PlayDelayed(2f);
			}
		}
		distanciatelf = Vector3.Distance(casa.Player.transform.position, ((Component)auricularcol).transform.position);
	}

	private void RayTelefono(RaycastHit hit)
	{
		if ((Object)(object)hit.collider == (Object)(object)auricularcol)
		{
			if (distanciatelf < 1.5f)
			{
				m_guiUseBool.Value = true;
			}
			if (Input.GetMouseButtonDown(0) && distanciatelf < 1.5f)
			{
				cogido = !cogido;
				if (cogido)
				{
					FsmVariables.GlobalVariables.FindFsmBool("PlayerStop").Value = true;
					auricular.SetActive(false);
					m_ringAudioSource.Stop();
					if (!telfcogido.isPlaying)
					{
						telfcogido.Play();
					}
					if (telfcolgado.isPlaying)
					{
						telfcolgado.Stop();
					}
					if (fsm2origi.Active)
					{
						fsm2origi.FsmVariables.FindFsmBool("Answer").Value = true;
						if (fsm2origi.FsmVariables.FindFsmString("Topic").Value == "FLEETARISHIT")
						{
							fsmorigi.FsmVariables.FindFsmBool("FleetariShit").Value = false;
						}
						if (fsm2origi.FsmVariables.FindFsmString("Topic").Value == "SHIT1")
						{
							fsmorigi.FsmVariables.FindFsmBool("Shit1").Value = false;
						}
						if (fsm2origi.FsmVariables.FindFsmString("Topic").Value == "DRUNK")
						{
							fsmorigi.FsmVariables.FindFsmBool("Drunk").Value = false;
						}
						if (fsm2origi.FsmVariables.FindFsmString("Topic").Value == "REPAIR")
						{
							fsmorigi.FsmVariables.FindFsmBool("RepairReady").Value = false;
						}
						if (fsm2origi.FsmVariables.FindFsmString("Topic").Value == "WOOD1")
						{
							fsmorigi.FsmVariables.FindFsmBool("Wood1").Value = false;
						}
						if (fsm2origi.FsmVariables.FindFsmString("Topic").Value == "ORDER")
						{
							fsmorigi.FsmVariables.FindFsmBool("OrderReady").Value = false;
						}
						if (fsm2origi.FsmVariables.FindFsmString("Topic").Value == "SHIT2")
						{
							fsmorigi.FsmVariables.FindFsmBool("Shit2").Value = false;
						}
						if (fsm2origi.FsmVariables.FindFsmString("Topic").Value == "SHIT3")
						{
							fsmorigi.FsmVariables.FindFsmBool("Shit3").Value = false;
						}
						if (fsm2origi.FsmVariables.FindFsmString("Topic").Value == "SHIT4")
						{
							fsmorigi.FsmVariables.FindFsmBool("Shit4").Value = false;
						}
						if (fsm2origi.FsmVariables.FindFsmString("Topic").Value == "SHIT5")
						{
							fsmorigi.FsmVariables.FindFsmBool("Shit5").Value = false;
						}
						if (fsm2origi.FsmVariables.FindFsmString("Topic").Value == "FUEL")
						{
							fsmorigi.FsmVariables.FindFsmBool("FuelStolen").Value = false;
						}
						if (fsm2origi.FsmVariables.FindFsmString("Topic").Value == "FERNDALE")
						{
							fsmorigi.FsmVariables.FindFsmBool("Ferndale").Value = false;
						}
						if (fsm2origi.FsmVariables.FindFsmString("Topic").Value == "FLEETARIRALLY")
						{
							fsmorigi.FsmVariables.FindFsmBool("FleetariRally").Value = false;
						}
					}
				}
				if (!cogido)
				{
					FsmVariables.GlobalVariables.FindFsmBool("PlayerStop").Value = false;
					auricular.SetActive(true);
					if (!telfcolgado.isPlaying)
					{
						telfcolgado.Play();
					}
					if (telfcogido.isPlaying)
					{
						telfcogido.Stop();
					}
					fsm2origi.FsmVariables.FindFsmBool("Answer").Value = false;
					fsm2origi.FsmVariables.FindFsmString("Topic").Value = "FINISHED";
					((Component)fsm2origi).gameObject.SetActive(false);
					MasterAudio.StopAllOfSound("Teimo");
					MasterAudio.StopAllOfSound("Callers");
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)enchufecol)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				enchufado = !enchufado;
				_ = enchufado;
				_ = enchufado;
			}
		}
	}
}
