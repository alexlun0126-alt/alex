using System.Collections;
using System.Collections.Generic;
using System.IO;
using HutongGames.PlayMaker;
using MSCLoader;
using UnityEngine;

namespace NewHouse;

public class RadiooBehaviour : MonoBehaviour
{
	private AudioSource m_radioChannel1Source;

	private AudioSource m_radioFolkSource;

	private AudioSource altavoz1;

	public bool radioencendida;

	public bool folk;

	public bool channel;

	public bool radioplay;

	public bool disco;

	public int volumen;

	public int pista = 1;

	public int maxpista;

	public double tiempo2;

	public double maxtiempo2;

	private CasaBehaviour root;

	private FsmBool m_guiUseBool;

	private FsmString m_guiInteractString;

	private GameObject Player;

	private string path;

	private Collider radioencendido;

	private Collider radioatras;

	private Collider radioalante;

	private Collider radioreproducir;

	private Collider radioparar;

	private Collider volumenradio;

	private Collider radiocambiocd;

	private Transform pivotvolumenradio;

	private Transform pivotvolumenradio0;

	private Transform pivotvolumenradio1;

	private Transform pivotvolumenradio2;

	private Transform pivotvolumenradio3;

	private Transform pivotvolumenradio4;

	private Transform pivotvolumenradio5;

	private Transform pivotvolumenradio6;

	private Transform pivotvolumenradio7;

	private Transform pivotvolumenradio8;

	private TextMesh texto;

	private List<string> clips;

	public bool sinmusica;

	public bool pausa;

	private FileInfo[] files;

	public bool musicacargada;

	public bool musicacargada2;

	private FsmBool _playerInMenu;

	public bool showGUI;

	public ElectricidadBehaviour electricidad;

	private readonly Rect _guiBox = new Rect((float)(Screen.width / 2 - 190), (float)(Screen.height / 2 - 200), 280f, 390f);

	private ModAudio MAudio;

	private bool drink3Running;

	private void Start()
	{
		radioencendido = GameObject.Find("radioencendido").GetComponent<Collider>();
		radioatras = GameObject.Find("radioatras").GetComponent<Collider>();
		radioalante = GameObject.Find("radioalante").GetComponent<Collider>();
		radioreproducir = GameObject.Find("radioreproducir").GetComponent<Collider>();
		radioparar = GameObject.Find("radioparar").GetComponent<Collider>();
		volumenradio = GameObject.Find("volumenradio").GetComponent<Collider>();
		radiocambiocd = GameObject.Find("radiocambiocd").GetComponent<Collider>();
		pivotvolumenradio = GameObject.Find("pivotvolumenradio").transform;
		pivotvolumenradio0 = GameObject.Find("pivotvolumenradio0").transform;
		pivotvolumenradio1 = GameObject.Find("pivotvolumenradio1").transform;
		pivotvolumenradio2 = GameObject.Find("pivotvolumenradio2").transform;
		pivotvolumenradio3 = GameObject.Find("pivotvolumenradio3").transform;
		pivotvolumenradio4 = GameObject.Find("pivotvolumenradio4").transform;
		pivotvolumenradio5 = GameObject.Find("pivotvolumenradio5").transform;
		pivotvolumenradio6 = GameObject.Find("pivotvolumenradio6").transform;
		pivotvolumenradio7 = GameObject.Find("pivotvolumenradio7").transform;
		pivotvolumenradio8 = GameObject.Find("pivotvolumenradio8").transform;
		texto = GameObject.Find("pantallaradio").GetComponent<TextMesh>();
		altavoz1 = GameObject.Find("altavoz3").GetComponent<AudioSource>();
		MAudio = ((Component)altavoz1).gameObject.AddComponent<ModAudio>();
		root = ((Component)((Component)this).transform.root).GetComponent<CasaBehaviour>();
		m_guiUseBool = PlayMakerGlobals.Instance.Variables.FindFsmBool("GUIuse");
		path = NewHouse.configPath;
		m_radioChannel1Source = GameObject.Find("RADIO/RadioChannels/Channel1").GetComponent<AudioSource>();
		m_radioFolkSource = GameObject.Find("RADIO/RadioChannels/Folk").GetComponent<AudioSource>();
		DirectoryInfo directoryInfo = new DirectoryInfo(path);
		files = new FileInfo[10];
		files = directoryInfo.GetFiles("*.mp3");
		if (files.Length == 0)
		{
			ModConsole.Error("Warning no songs loaded in path " + directoryInfo.FullName);
			sinmusica = true;
		}
		else if (files.Length > 10)
		{
			maxpista = 10;
		}
		else if (files.Length <= 10)
		{
			maxpista = files.Length;
		}
		radioencendida = false;
		radioplay = false;
		folk = false;
		channel = true;
		volumen = 0;
		disco = false;
		_playerInMenu = PlayMakerGlobals.Instance.Variables.GetFsmBool("PlayerInMenu");
		m_guiInteractString = PlayMakerGlobals.Instance.Variables.FindFsmString("GUIinteraction");
		electricidad = Object.FindObjectOfType<ElectricidadBehaviour>();
	}

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
			GUI.ModalWindow(939, _guiBox, (WindowFunction)GuiSettingsWindow, "Radio MP3 Options");
		}
	}

	private void GuiSettingsWindow(int windowId)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		GUI.skin.GetStyle("Label").alignment = (TextAnchor)1;
		if (GUI.Button(new Rect(160f, 30f, 80f, 30f), "No Songs"))
		{
			_playerInMenu.Value = false;
			sinmusica = true;
			disco = false;
			musicacargada = false;
			showGUI = false;
		}
		if (GUI.Button(new Rect(30f, 30f, 90f, 30f), "Load Songs"))
		{
			LoadSong();
			musicacargada = true;
			sinmusica = false;
			_playerInMenu.Value = false;
			showGUI = false;
		}
		if (files.Length == 0)
		{
			GUI.Label(new Rect(40f, 60f, 250f, 30f), "no songs detected.");
			return;
		}
		GUI.Label(new Rect(40f, 60f, 200f, 30f), "Songs detected list:");
		GUI.Label(new Rect(40f, 90f, 200f, 30f), files[0].Name);
		GUI.Label(new Rect(40f, 120f, 200f, 30f), files[1].Name);
		GUI.Label(new Rect(40f, 150f, 200f, 30f), files[2].Name);
		GUI.Label(new Rect(40f, 180f, 200f, 30f), files[3].Name);
		GUI.Label(new Rect(40f, 210f, 200f, 30f), files[4].Name);
		GUI.Label(new Rect(40f, 240f, 200f, 30f), files[5].Name);
		GUI.Label(new Rect(40f, 270f, 200f, 30f), files[6].Name);
		GUI.Label(new Rect(40f, 300f, 200f, 30f), files[7].Name);
		GUI.Label(new Rect(40f, 330f, 200f, 30f), files[8].Name);
		GUI.Label(new Rect(40f, 360f, 200f, 30f), files[9].Name);
	}

	public void LoadSong()
	{
		LoadSongCoroutine();
	}

	private void LoadSongCoroutine()
	{
		clips = new List<string>();
		for (int i = 0; i < files.Length; i++)
		{
			if (i < 10)
			{
				clips.Add(files[i].FullName);
			}
		}
	}

	private void Update()
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GameObject.Find("PLAYER") != (Object)null))
		{
			return;
		}
		if (showGUI)
		{
			_playerInMenu.Value = true;
		}
		if (Player == null)
		{
			Player = GameObject.Find("PLAYER").gameObject;
		}
		if (Player != null)
		{
			if (electricidad.electricidadon)
			{
				if (Vector3.Distance(GameObject.Find("PLAYER").transform.position, transform.root.position) <= 60f)
		{
		RaycastHit[] array = Physics.RaycastAll(Camera.main.ScreenPointToRay(Input.mousePosition), 1.5f);
				foreach (RaycastHit hit in array)
				{
					if (root.vendido && root.radiocomprada)
					{
						RayRadio(hit);
					}
				}
		}
				if (root.vendido && root.radiocomprada)
				{
					SetupRadio();
				}
			}
			if (!electricidad.electricidadon)
			{
				channel = true;
				folk = false;
				radioplay = false;
				altavoz1.Stop();
				altavoz1.clip = null;
				musicacargada2 = false;
				root.intensidad--;
				showGUI = false;
			}
		}
		if (!folk && !channel)
		{
			channel = true;
			folk = false;
			altavoz1.Stop();
		}
		if (!sinmusica)
		{
			if (pista <= 1)
			{
				pista = 1;
			}
			if (pista >= maxpista)
			{
				pista = maxpista;
			}
		}
	}

	private IEnumerator Drink3()
	{
		drink3Running = true;
		yield return (object)new WaitForSeconds(0.5f);
		FsmFloat val = FsmVariables.GlobalVariables.FindFsmFloat("PlayerStress");
		val.Value -= 0.03f;
		drink3Running = false;
	}

	private void RayRadio(RaycastHit hit)
	{
		if ((Object)(object)hit.collider == (Object)(object)radioencendido)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				radioencendida = !radioencendida;
				if (radioencendida)
				{
					root.intensidad++;
					if (!musicacargada)
					{
						showGUI = true;
					}
				}
				if (!radioencendida)
				{
					root.intensidad--;
					radioplay = false;
					pausa = false;
					showGUI = false;
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)radioreproducir)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0) && !radioplay && radioencendida)
			{
				radioplay = true;
			}
			else if (Input.GetMouseButtonDown(0) && radioplay && radioencendida)
			{
				pausa = !pausa;
				if (pausa)
				{
					altavoz1.Pause();
				}
				if (!pausa)
				{
					altavoz1.UnPause();
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)radioparar)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				radioplay = false;
				altavoz1.Stop();
				altavoz1.clip = null;
				musicacargada2 = false;
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)radioalante)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				if (!disco)
				{
					if (folk)
					{
						channel = true;
						folk = false;
						altavoz1.Stop();
					}
					else if (channel)
					{
						folk = true;
						channel = false;
						altavoz1.Stop();
					}
				}
				if (disco && !sinmusica)
				{
					altavoz1.Stop();
					altavoz1.clip = null;
					musicacargada2 = false;
					if (pista >= maxpista)
					{
						pista = maxpista;
					}
					else
					{
						pista++;
					}
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)radioatras)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				if (!disco)
				{
					if (folk)
					{
						channel = true;
						folk = false;
						altavoz1.Stop();
					}
					else if (channel)
					{
						folk = true;
						channel = false;
						altavoz1.Stop();
					}
				}
				if (disco && !sinmusica)
				{
					altavoz1.Stop();
					altavoz1.clip = null;
					musicacargada2 = false;
					pista--;
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)volumenradio)
		{
			m_guiUseBool.Value = true;
			if (Input.GetAxis("Mouse ScrollWheel") > 0f)
			{
				volumen++;
			}
			else if (Input.GetAxis("Mouse ScrollWheel") < 0f)
			{
				volumen--;
			}
		}
		if (!((Object)(object)hit.collider == (Object)(object)radiocambiocd) || sinmusica)
		{
			return;
		}
		m_guiUseBool.Value = true;
		if (Input.GetMouseButtonDown(0))
		{
			disco = !disco;
			if (disco)
			{
				altavoz1.Stop();
				altavoz1.clip = null;
				musicacargada2 = false;
			}
			if (!disco)
			{
				altavoz1.Stop();
			}
		}
	}

	private void Siguiente(float time, float totime)
	{
		if (time >= totime - 0.5f)
		{
			altavoz1.Stop();
			musicacargada2 = false;
			MAudio.Stop();
			if (pista >= maxpista)
			{
				pista = 1;
			}
			else
			{
				pista++;
			}
		}
	}

	private void Volumen()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		if (volumen < 0)
		{
			volumen = 0;
		}
		if (volumen > 8)
		{
			volumen = 8;
		}
		if (volumen == 0)
		{
			((Component)pivotvolumenradio).transform.rotation = ((Component)pivotvolumenradio0).transform.rotation;
			altavoz1.volume = 0f;
		}
		if (volumen == 1)
		{
			((Component)pivotvolumenradio).transform.rotation = ((Component)pivotvolumenradio1).transform.rotation;
			altavoz1.volume = 0.1f;
		}
		if (volumen == 2)
		{
			((Component)pivotvolumenradio).transform.rotation = ((Component)pivotvolumenradio2).transform.rotation;
			altavoz1.volume = 0.3f;
		}
		if (volumen == 3)
		{
			((Component)pivotvolumenradio).transform.rotation = ((Component)pivotvolumenradio3).transform.rotation;
			altavoz1.volume = 0.4f;
		}
		if (volumen == 4)
		{
			((Component)pivotvolumenradio).transform.rotation = ((Component)pivotvolumenradio4).transform.rotation;
			altavoz1.volume = 0.5f;
		}
		if (volumen == 5)
		{
			((Component)pivotvolumenradio).transform.rotation = ((Component)pivotvolumenradio5).transform.rotation;
			altavoz1.volume = 0.6f;
		}
		if (volumen == 6)
		{
			((Component)pivotvolumenradio).transform.rotation = ((Component)pivotvolumenradio6).transform.rotation;
			altavoz1.volume = 0.7f;
		}
		if (volumen == 7)
		{
			((Component)pivotvolumenradio).transform.rotation = ((Component)pivotvolumenradio7).transform.rotation;
			altavoz1.volume = 0.9f;
		}
		if (volumen == 8)
		{
			((Component)pivotvolumenradio).transform.rotation = ((Component)pivotvolumenradio8).transform.rotation;
			altavoz1.volume = 2.5f;
		}
	}

	private void SetupRadio()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Volumen();
		float num = Vector3.Distance(((Component)radioencendido).transform.position, Player.transform.position);
		if (radioencendida && radioplay && num < 3f && !drink3Running)
		{
			((MonoBehaviour)this).StartCoroutine(Drink3());
		}
		if (radioencendida)
		{
			texto.text = "WELCOME";
			if (radioplay)
			{
				if (pausa)
				{
					texto.text = "PAUSE";
				}
				if (disco && !sinmusica && !pausa)
				{
					((Behaviour)MAudio).enabled = true;
					if (pista == 1)
					{
						if (!altavoz1.isPlaying)
						{
							CargaCancion(clips[0]);
						}
						maxtiempo2 = altavoz1.clip.length;
						tiempo2 = altavoz1.time;
						Siguiente((float)tiempo2, (float)maxtiempo2);
						float time = altavoz1.time;
						string text = FloatToTime(time, "00:00:00");
						texto.text = "Track 1 - " + text;
					}
					if (pista == 2)
					{
						if (!altavoz1.isPlaying)
						{
							CargaCancion(clips[1]);
						}
						maxtiempo2 = altavoz1.clip.length;
						tiempo2 = altavoz1.time;
						Siguiente((float)tiempo2, (float)maxtiempo2);
						float time2 = altavoz1.time;
						string text2 = FloatToTime(time2, "00:00:00");
						texto.text = "Track 2 - " + text2;
					}
					if (pista == 3)
					{
						if (!altavoz1.isPlaying)
						{
							CargaCancion(clips[2]);
						}
						maxtiempo2 = altavoz1.clip.length;
						tiempo2 = altavoz1.time;
						Siguiente((float)tiempo2, (float)maxtiempo2);
						float time3 = altavoz1.time;
						string text3 = FloatToTime(time3, "00:00:00");
						texto.text = "Track 3 - " + text3;
					}
					if (pista == 4)
					{
						if (!altavoz1.isPlaying)
						{
							CargaCancion(clips[3]);
						}
						maxtiempo2 = altavoz1.clip.length;
						tiempo2 = altavoz1.time;
						Siguiente((float)tiempo2, (float)maxtiempo2);
						float time4 = altavoz1.time;
						string text4 = FloatToTime(time4, "00:00:00");
						texto.text = "Track 4 - " + text4;
					}
					if (pista == 5)
					{
						if (!altavoz1.isPlaying)
						{
							CargaCancion(clips[4]);
						}
						maxtiempo2 = altavoz1.clip.length;
						tiempo2 = altavoz1.time;
						Siguiente((float)tiempo2, (float)maxtiempo2);
						float time5 = altavoz1.time;
						string text5 = FloatToTime(time5, "00:00:00");
						texto.text = "Track 5 - " + text5;
					}
					if (pista == 6)
					{
						if (!altavoz1.isPlaying)
						{
							CargaCancion(clips[5]);
						}
						maxtiempo2 = altavoz1.clip.length;
						tiempo2 = altavoz1.time;
						Siguiente((float)tiempo2, (float)maxtiempo2);
						float time6 = altavoz1.time;
						string text6 = FloatToTime(time6, "00:00:00");
						texto.text = "Track 6 - " + text6;
					}
					if (pista == 7)
					{
						if (!altavoz1.isPlaying)
						{
							CargaCancion(clips[6]);
						}
						maxtiempo2 = altavoz1.clip.length;
						tiempo2 = altavoz1.time;
						Siguiente((float)tiempo2, (float)maxtiempo2);
						float time7 = altavoz1.time;
						string text7 = FloatToTime(time7, "00:00:00");
						texto.text = "Track 7 - " + text7;
					}
					if (pista == 8)
					{
						if (!altavoz1.isPlaying)
						{
							CargaCancion(clips[7]);
						}
						maxtiempo2 = altavoz1.clip.length;
						tiempo2 = altavoz1.time;
						Siguiente((float)tiempo2, (float)maxtiempo2);
						float time8 = altavoz1.time;
						string text8 = FloatToTime(time8, "00:00:00");
						texto.text = "Track 8 - " + text8;
					}
					if (pista == 9)
					{
						if (!altavoz1.isPlaying)
						{
							CargaCancion(clips[8]);
						}
						maxtiempo2 = altavoz1.clip.length;
						tiempo2 = altavoz1.time;
						Siguiente((float)tiempo2, (float)maxtiempo2);
						float time9 = altavoz1.time;
						string text9 = FloatToTime(time9, "00:00:00");
						texto.text = "Track 9 - " + text9;
					}
					if (pista == 10)
					{
						if (!altavoz1.isPlaying)
						{
							CargaCancion(clips[9]);
						}
						maxtiempo2 = altavoz1.clip.length;
						tiempo2 = altavoz1.time;
						Siguiente((float)tiempo2, (float)maxtiempo2);
						float time10 = altavoz1.time;
						string text10 = FloatToTime(time10, "00:00:00");
						texto.text = "Track 10 - " + text10;
					}
				}
				if (!disco && !pausa)
				{
					((Behaviour)MAudio).enabled = false;
					if (folk)
					{
						texto.text = "RADIO FOLK";
						if (!altavoz1.isPlaying)
						{
							altavoz1.clip = m_radioFolkSource.clip;
							altavoz1.Play();
						}
					}
					if (channel)
					{
						texto.text = "RADIO CHANNEL";
						if (!altavoz1.isPlaying)
						{
							altavoz1.clip = m_radioChannel1Source.clip;
							altavoz1.Play();
						}
					}
				}
			}
			if (!radioplay)
			{
				altavoz1.Stop();
				pausa = false;
			}
		}
		if (!radioencendida)
		{
			texto.text = "";
			altavoz1.Stop();
			pausa = false;
		}
	}

	private void CargaCancion(string path)
	{
		if (!musicacargada2)
		{
			MAudio.audioSource = altavoz1;
			MAudio.LoadAudioFromFile(path, false, true);
			altavoz1.clip = MAudio.audioSource.clip;
			altavoz1.Play();
			musicacargada2 = true;
		}
	}

	public string FloatToTime(float toConvert, string format)
	{
		return format switch
		{
			"00.0" => $"{Mathf.Floor(toConvert) % 60f:00}:{Mathf.Floor(toConvert * 10f % 10f):0}", 
			"#0.0" => $"{Mathf.Floor(toConvert) % 60f:#0}:{Mathf.Floor(toConvert * 10f % 10f):0}", 
			"00.00" => $"{Mathf.Floor(toConvert) % 60f:00}:{Mathf.Floor(toConvert * 100f % 100f):00}", 
			"00.000" => $"{Mathf.Floor(toConvert) % 60f:00}:{Mathf.Floor(toConvert * 1000f % 1000f):000}", 
			"#00.000" => $"{Mathf.Floor(toConvert) % 60f:#00}:{Mathf.Floor(toConvert * 1000f % 1000f):000}", 
			"#0:00" => $"{Mathf.Floor(toConvert / 60f):#0}:{Mathf.Floor(toConvert) % 60f:00}", 
			"#00:00" => $"{Mathf.Floor(toConvert / 60f):#00}:{Mathf.Floor(toConvert) % 60f:00}", 
			"00:00:00" => $"{Mathf.Floor(toConvert / 60f / 60f):00}:{Mathf.Floor(toConvert / 60f):00}:{Mathf.Floor(toConvert) % 60f:00}", 
			"0:00.0" => $"{Mathf.Floor(toConvert / 60f):0}:{Mathf.Floor(toConvert) % 60f:00}.{Mathf.Floor(toConvert * 10f % 10f):0}", 
			"#0:00.0" => $"{Mathf.Floor(toConvert / 60f):#0}:{Mathf.Floor(toConvert) % 60f:00}.{Mathf.Floor(toConvert * 10f % 10f):0}", 
			"0:00.00" => $"{Mathf.Floor(toConvert / 60f):0}:{Mathf.Floor(toConvert) % 60f:00}.{Mathf.Floor(toConvert * 100f % 100f):00}", 
			"#0:00.00" => $"{Mathf.Floor(toConvert / 60f):#0}:{Mathf.Floor(toConvert) % 60f:00}.{Mathf.Floor(toConvert * 100f % 100f):00}", 
			"0:00.000" => $"{Mathf.Floor(toConvert / 60f):0}:{Mathf.Floor(toConvert) % 60f:00}.{Mathf.Floor(toConvert * 1000f % 1000f):000}", 
			"#0:00.000" => $"{Mathf.Floor(toConvert / 60f):#0}:{Mathf.Floor(toConvert) % 60f:00}.{Mathf.Floor(toConvert * 1000f % 1000f):000}", 
			_ => "error", 
		};
	}

	public RadiooBehaviour()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
	}
}
