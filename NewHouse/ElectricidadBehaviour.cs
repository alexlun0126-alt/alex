using System.Collections;
using System.Collections.Generic;
using MSCLoader;
using UnityEngine;

namespace NewHouse;

public class ElectricidadBehaviour : MonoBehaviour
{
	public class SaveData
	{
		public List<SaveDataList> save = new List<SaveDataList>();
	}

	public class SaveDataList
	{
		public float consumo;
	}

	public float consumor;

	public float consumoluces1 = 5E-05f;

	public float consumoluces2 = 5E-05f;

	public float consumoluces3 = 5E-05f;

	public float consumoluces4 = 5E-05f;

	public float consumoluces5 = 5E-05f;

	public float consumoluces6 = 5E-05f;

	public float consumoluces7 = 5E-05f;

	public float consumoluces8 = 5E-05f;

	public float consumoluces9 = 5E-05f;

	public float consumoluces10 = 5E-05f;

	public float consumoluces11 = 5E-05f;

	public float consumoradio = 8E-05f;

	public float consumotele = 0.00013f;

	public float consumotelefono = 5E-05f;

	public float consumojacuzi = 0.00016f;

	public float consumonevera = 0.00015f;

	public float puertagaragepeq = 0.00045f;

	public float puertagaragegrande = 0.00055f;

	private LucesBehaviour luces;

	private CasaBehaviour general;

	private GrifoSaunaBehaviour jacuzi;

	private PuertaBehaviour puertagarage;

	private RadiooBehaviour radio;

	private float timer;

	private float timer2;

	public bool reusado;

	public bool reusado2;

	public bool electricidadon = true;

	public bool storevalues;

	public int intensidad;

	public int totalintensidad;

	public bool loaded;

	private void Start()
	{
		luces = ((Component)((Component)this).transform.FindChild("utiles/luces")).GetComponent<LucesBehaviour>();
		general = ((Component)((Component)this).transform).GetComponent<CasaBehaviour>();
		puertagarage = ((Component)((Component)this).transform.FindChild("utiles/puertas")).GetComponent<PuertaBehaviour>();
	}

	public void Save()
	{
		if (general.vendido)
		{
			SaveData saveData = new SaveData();
			SaveDataList item = new SaveDataList
			{
				consumo = consumor
			};
			saveData.save.Add(item);
			SaveLoad.SerializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, saveData, "NewHouse-electrics.save");
		}
	}

	private void Load()
	{
		SaveData saveData = SaveLoad.DeserializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, "NewHouse-electrics.save");
		if (saveData != null)
		{
			consumor = saveData.save[0].consumo;
		}
		loaded = true;
	}

	private void StoreValues()
	{
		luces.luzz1 = luces.storeluzz1;
		luces.luzz2 = luces.storeluzz2;
		luces.luzz3 = luces.storeluzz3;
		luces.luzz4 = luces.storeluzz4;
		luces.luzz5 = luces.storeluzz5;
		luces.luzz6 = luces.storeluzz6;
		luces.luzz7 = luces.storeluzz7;
		luces.luzz8 = luces.storeluzz8;
		luces.luzz9 = luces.storeluzz9;
		if (general.piscinacomprada)
		{
			luces.luzz10 = luces.storeluzz10;
		}
		luces.luzz11 = luces.storeluzz11;
		if (general.radiocomprada)
		{
			radio.radioencendida = general.storeradio;
		}
		if (general.telecomprada)
		{
			general.teleencendida = general.storetele;
		}
	}

	private void RestoreValues()
	{
		luces.storeluzz1 = luces.luzz1;
		luces.storeluzz2 = luces.luzz2;
		luces.storeluzz3 = luces.luzz3;
		luces.storeluzz4 = luces.luzz4;
		luces.storeluzz5 = luces.luzz5;
		luces.storeluzz6 = luces.luzz6;
		luces.storeluzz7 = luces.luzz7;
		luces.storeluzz8 = luces.luzz8;
		luces.storeluzz9 = luces.luzz9;
		if (general.piscinacomprada)
		{
			luces.storeluzz10 = luces.luzz10;
		}
		luces.storeluzz11 = luces.luzz11;
		if (general.radiocomprada)
		{
			general.storeradio = radio.radioencendida;
		}
		if (general.telecomprada)
		{
			general.storetele = general.teleencendida;
		}
	}

	private void SinLuz()
	{
		luces.luzz1 = false;
		luces.luzz2 = false;
		luces.luzz3 = false;
		luces.luzz4 = false;
		luces.luzz5 = false;
		luces.luzz6 = false;
		luces.luzz7 = false;
		luces.luzz8 = false;
		luces.luzz9 = false;
		if (general.piscinacomprada)
		{
			luces.luzz10 = false;
		}
		luces.luzz11 = false;
		if (general.radiocomprada)
		{
			general.storeradio = false;
		}
		if (general.telecomprada)
		{
			general.storetele = false;
		}
	}

	private IEnumerator Espera()
	{
		yield return (object)new WaitForSeconds(4f);
		Load();
	}

	private void Update()
	{
		if (!loaded)
		{
			((MonoBehaviour)this).StartCoroutine(Espera());
		}
		if (!general.vendido)
		{
			electricidadon = false;
			consumor = 0f;
		}
		if (!((Object)(object)GameObject.Find("PLAYER") != (Object)null) || ((Component)((Component)this).transform).GetComponent<CasaBehaviour>()._playerInMenu.Value || !general.vendido)
		{
			return;
		}
		if (general.saunacomprada && (Object)(object)jacuzi == (Object)null)
		{
			jacuzi = ((Component)((Component)this).transform.FindChild("utiles/saunamadera")).GetComponent<GrifoSaunaBehaviour>();
		}
		if (general.radiocomprada && (Object)(object)radio == (Object)null)
		{
			radio = ((Component)((Component)this).transform.FindChild("utiles/radiopepino")).GetComponent<RadiooBehaviour>();
		}
		if (electricidadon)
		{
			if (storevalues)
			{
				StoreValues();
				storevalues = false;
			}
			consumor += consumonevera;
			if (general.saunacomprada)
			{
				totalintensidad = luces.intensidad + general.intensidad + jacuzi.intensidad;
			}
			if (!general.saunacomprada)
			{
				totalintensidad = luces.intensidad + general.intensidad;
			}
			intensidad = totalintensidad;
			if (luces.luzz1)
			{
				consumor += consumoluces1;
			}
			if (luces.luzz2)
			{
				consumor += consumoluces2;
			}
			if (luces.luzz3)
			{
				consumor += consumoluces3;
			}
			if (luces.luzz4)
			{
				consumor += consumoluces4;
			}
			if (luces.luzz5)
			{
				consumor += consumoluces5;
			}
			if (luces.luzz6)
			{
				consumor += consumoluces6;
			}
			if (luces.luzz7)
			{
				consumor += consumoluces7;
			}
			if (luces.luzz8)
			{
				consumor += consumoluces8;
			}
			if (luces.luzz9)
			{
				consumor += consumoluces9;
			}
			if (general.piscinacomprada && luces.luzz10)
			{
				consumor += consumoluces10;
			}
			if (luces.luzz11)
			{
				consumor += consumoluces11;
			}
			if (general.teleencendida && general.telecomprada)
			{
				consumor += consumotele;
			}
			if (general.radiocomprada && radio.radioencendida)
			{
				consumor += consumoradio;
			}
			if (general.saunacomprada && jacuzi.lleno)
			{
				consumor += consumojacuzi;
			}
			if (puertagarage.abiertaparking && !reusado)
			{
				timer += Time.deltaTime;
				consumor += puertagaragepeq;
				if (timer > 3f)
				{
					reusado = true;
					puertagarage.intensidad--;
					timer = 0f;
					return;
				}
			}
			if (!puertagarage.abiertaparking && !reusado)
			{
				timer += Time.deltaTime;
				consumor += puertagaragepeq;
				if (timer > 3f)
				{
					reusado = true;
					timer = 0f;
					return;
				}
			}
			if (puertagarage.puertavallagarageopen && !reusado2)
			{
				timer2 += Time.deltaTime;
				consumor += puertagaragegrande;
				if (timer2 > 3f)
				{
					reusado2 = true;
					timer2 = 0f;
					return;
				}
			}
			if (!puertagarage.puertavallagarageopen && !reusado2)
			{
				timer2 += Time.deltaTime;
				consumor += puertagaragegrande;
				if (timer2 > 3f)
				{
					reusado2 = true;
					timer2 = 0f;
					return;
				}
			}
		}
		if (!electricidadon)
		{
			if (!storevalues)
			{
				RestoreValues();
				storevalues = true;
			}
			if (storevalues)
			{
				SinLuz();
			}
		}
	}
}
