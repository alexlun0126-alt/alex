using HutongGames.PlayMaker;
using UnityEngine;

namespace NewHouse;

public class Papelillo2Behaviour : MonoBehaviour
{
	private Collider imaexit3;

	private Collider imacortina;

	private GameObject delverde2;

	private GameObject delblanco2;

	private GameObject delazul2;

	private GameObject delraro2;

	private GameObject cortinablanca;

	private GameObject cortinaverde;

	private GameObject cortinaazul;

	private GameObject cortinarara;

	private GameObject cortinablanca2;

	private GameObject cortinaverde2;

	private GameObject cortinaazul2;

	private GameObject cortinarara2;

	public bool verde2;

	public bool blanco2 = true;

	public bool azul2;

	public bool raro2;

	private Collider imablanco2;

	private Collider imaverde2;

	private Collider imaazul2;

	private Collider imararo2;

	private Collider imaexit4;

	private Collider imacortina2;

	private GameObject cortinablanca3;

	private GameObject cortinaverde3;

	private GameObject cortinaazul3;

	private GameObject cortinarara3;

	private GameObject cortinablanca4;

	private GameObject cortinaverde4;

	private GameObject cortinaazul4;

	private GameObject cortinarara4;

	private GameObject delverde4;

	private GameObject delblanco4;

	private GameObject delazul4;

	private GameObject delraro4;

	public bool verde4;

	public bool blanco4 = true;

	public bool azul4;

	public bool raro4;

	private Collider imablanco4;

	private Collider imaverde4;

	private Collider imaazul4;

	private Collider imararo4;

	private Collider imaexitlav;

	private Collider imacortinalav;

	private GameObject cortinablancalav;

	private GameObject cortinaverdelav;

	private GameObject cortinaazullav;

	private GameObject cortinararalav;

	private GameObject cortinablancalav2;

	private GameObject cortinaverdelav2;

	private GameObject cortinaazullav2;

	private GameObject cortinararalav2;

	private GameObject delverdelav;

	private GameObject delblancolav;

	private GameObject delazullav;

	private GameObject delrarolav;

	public bool verdelav;

	public bool blancolav = true;

	public bool azullav;

	public bool rarolav;

	private Collider imablancolav;

	private Collider imaverdelav;

	private Collider imaazullav;

	private Collider imararolav;

	private Collider imaexitcoc;

	private Collider imacortinacoc;

	private GameObject cortinablancacoc;

	private GameObject cortinaverdecoc;

	private GameObject cortinaazulcoc;

	private GameObject cortinararacoc;

	private GameObject cortinablancacoc2;

	private GameObject cortinaverdecoc2;

	private GameObject cortinaazulcoc2;

	private GameObject cortinararacoc2;

	private GameObject cortinablancacoc3;

	private GameObject cortinaverdecoc3;

	private GameObject cortinaazulcoc3;

	private GameObject cortinararacoc3;

	private GameObject cortinablancacoc4;

	private GameObject cortinaverdecoc4;

	private GameObject cortinaazulcoc4;

	private GameObject cortinararacoc4;

	private GameObject delverdecoc;

	private GameObject delblancococ;

	private GameObject delazulcoc;

	private GameObject delrarococ;

	public bool verdecoc;

	public bool blancococ = true;

	public bool azulcoc;

	public bool rarococ;

	private Collider imablancococ;

	private Collider imaverdecoc;

	private Collider imaazulcoc;

	private Collider imararococ;

	private Collider imaexittel;

	private Collider imacortinatel;

	private GameObject cortinablancatel;

	private GameObject cortinaverdetel;

	private GameObject cortinaazultel;

	private GameObject cortinararatel;

	private GameObject delverdetel;

	private GameObject delblancotel;

	private GameObject delazultel;

	private GameObject delrarotel;

	public bool verdetel;

	public bool blancotel = true;

	public bool azultel;

	public bool rarotel;

	private Collider imablancotel;

	private Collider imaverdetel;

	private Collider imaazultel;

	private Collider imararotel;

	private Collider imaexithab1;

	private Collider imacortinahab1;

	private GameObject cortinablancahab1;

	private GameObject cortinaverdehab1;

	private GameObject cortinaazulhab1;

	private GameObject cortinararahab1;

	private GameObject delverdehab1;

	private GameObject delblancohab1;

	private GameObject delazulhab1;

	private GameObject delrarohab1;

	public bool verdehab1;

	public bool blancohab1 = true;

	public bool azulhab1;

	public bool rarohab1;

	private Collider imablancohab1;

	private Collider imaverdehab1;

	private Collider imaazulhab1;

	private Collider imararohab1;

	private Collider imaexithab2;

	private Collider imacortinahab2;

	private GameObject cortinablancahab2;

	private GameObject cortinaverdehab2;

	private GameObject cortinaazulhab2;

	private GameObject cortinararahab2;

	private GameObject delverdehab2;

	private GameObject delblancohab2;

	private GameObject delazulhab2;

	private GameObject delrarohab2;

	public bool verdehab2;

	public bool blancohab2 = true;

	public bool azulhab2;

	public bool rarohab2;

	private Collider imablancohab2;

	private Collider imaverdehab2;

	private Collider imaazulhab2;

	private Collider imararohab2;

	private GameObject casa;

	public float precio = 50f;

	public bool customcortina;

	public bool customcortina2;

	public bool living;

	public bool living2;

	public bool bath;

	public bool kitc;

	public bool telf;

	public bool habita1;

	public bool habita2;

	public bool customcortinalav;

	public bool customcortinacoc;

	public bool customcortinatel;

	public bool customcortinahab1;

	public bool customcortinahab2;

	public bool compras;

	public bool opcion;

	private GameObject customizarcortina;

	private GameObject opciones;

	private GameObject livingroom;

	private GameObject customizar1;

	private GameObject livingroom2;

	private GameObject bathroom;

	private GameObject kitchen;

	private GameObject telefono;

	private GameObject hab1;

	private GameObject hab2;

	private Collider imaexit2;

	private Collider imalivingroom;

	private Collider imalivingroom2;

	private Collider imabathroom;

	private Collider imakitchen;

	private Collider imatelf;

	private Collider imahab1;

	private Collider imahab2;

	private Collider imaaccesorios;

	private Collider imaatras;

	private Collider imaatras2;

	private Collider imaatraslav;

	private Collider imaatrascoc;

	private Collider imaatrastel;

	private Collider imaatrashab1;

	private Collider imaatrashab2;

	private GameObject customizarcortina2;

	private GameObject customizarcortinalav;

	private GameObject customizarcortinacoc;

	private GameObject customizarcortinatel;

	private GameObject customizarcortinahab2;

	private GameObject customizarcortinahab1;

	private void Start()
	{
		casa = ((Component)Object.FindObjectOfType<CasaBehaviour>()).gameObject;
		cortinablanca = ((Component)casa.transform.FindChild("salon/setcortina1/cortinablanca")).gameObject;
		cortinaverde = ((Component)casa.transform.FindChild("salon/setcortina1/cortinaverde")).gameObject;
		cortinaazul = ((Component)casa.transform.FindChild("salon/setcortina1/cortinaazul")).gameObject;
		cortinarara = ((Component)casa.transform.FindChild("salon/setcortina1/cortinarara")).gameObject;
		cortinablanca2 = ((Component)casa.transform.FindChild("salon/setcortina2/cortinablanca")).gameObject;
		cortinaverde2 = ((Component)casa.transform.FindChild("salon/setcortina2/cortinaverde")).gameObject;
		cortinaazul2 = ((Component)casa.transform.FindChild("salon/setcortina2/cortinaazul")).gameObject;
		cortinarara2 = ((Component)casa.transform.FindChild("salon/setcortina2/cortinarara")).gameObject;
		customizarcortina = ((Component)((Component)this).transform.FindChild("customliving1/customizarcortina")).gameObject;
		delverde2 = ((Component)customizarcortina.transform.FindChild("delverde")).gameObject;
		delblanco2 = ((Component)customizarcortina.transform.FindChild("delblanco")).gameObject;
		delazul2 = ((Component)customizarcortina.transform.FindChild("delazul")).gameObject;
		delraro2 = ((Component)customizarcortina.transform.FindChild("delraro")).gameObject;
		imablanco2 = ((Component)customizarcortina.transform.FindChild("imablanco")).GetComponent<Collider>();
		imaverde2 = ((Component)customizarcortina.transform.FindChild("imaverde")).GetComponent<Collider>();
		imaazul2 = ((Component)customizarcortina.transform.FindChild("imaazul")).GetComponent<Collider>();
		imararo2 = ((Component)customizarcortina.transform.FindChild("imararo")).GetComponent<Collider>();
		opciones = ((Component)((Component)this).transform.FindChild("opciones")).gameObject;
		imaexit2 = ((Component)opciones.transform.FindChild("imaexit2")).GetComponent<Collider>();
		imalivingroom = ((Component)opciones.transform.FindChild("imalivingroom")).GetComponent<Collider>();
		imalivingroom2 = ((Component)opciones.transform.FindChild("imalivingroom2")).GetComponent<Collider>();
		imabathroom = ((Component)opciones.transform.FindChild("imabathroom")).GetComponent<Collider>();
		imakitchen = ((Component)opciones.transform.FindChild("imakitchen")).GetComponent<Collider>();
		imatelf = ((Component)opciones.transform.FindChild("imaphone")).GetComponent<Collider>();
		imahab1 = ((Component)opciones.transform.FindChild("imabedroom")).GetComponent<Collider>();
		imahab2 = ((Component)opciones.transform.FindChild("imabedroom2")).GetComponent<Collider>();
		imaaccesorios = ((Component)opciones.transform.FindChild("imaaccesorios")).GetComponent<Collider>();
		customizar1 = ((Component)((Component)this).transform.FindChild("customizar 1")).gameObject;
		livingroom = ((Component)((Component)this).transform.FindChild("livingroom")).gameObject;
		livingroom2 = ((Component)((Component)this).transform.FindChild("livingroom2")).gameObject;
		imaexit3 = ((Component)livingroom.transform.FindChild("imaexit3")).GetComponent<Collider>();
		imaexit4 = ((Component)livingroom2.transform.FindChild("imaexit3")).GetComponent<Collider>();
		imacortina = ((Component)livingroom.transform.FindChild("imacortina")).GetComponent<Collider>();
		imaatras = ((Component)livingroom.transform.FindChild("imaatras")).GetComponent<Collider>();
		imacortina2 = ((Component)livingroom2.transform.FindChild("imacortina")).GetComponent<Collider>();
		imaatras2 = ((Component)livingroom2.transform.FindChild("imaatras")).GetComponent<Collider>();
		bathroom = ((Component)((Component)this).transform.FindChild("bathroom")).gameObject;
		imaexitlav = ((Component)bathroom.transform.FindChild("imaexit3")).GetComponent<Collider>();
		imacortinalav = ((Component)bathroom.transform.FindChild("imacortina")).GetComponent<Collider>();
		imaatraslav = ((Component)bathroom.transform.FindChild("imaatras")).GetComponent<Collider>();
		kitchen = ((Component)((Component)this).transform.FindChild("kitchen")).gameObject;
		imaexitcoc = ((Component)kitchen.transform.FindChild("imaexit3")).GetComponent<Collider>();
		imacortinacoc = ((Component)kitchen.transform.FindChild("imacortina")).GetComponent<Collider>();
		imaatrascoc = ((Component)kitchen.transform.FindChild("imaatras")).GetComponent<Collider>();
		telefono = ((Component)((Component)this).transform.FindChild("phone")).gameObject;
		imaexittel = ((Component)telefono.transform.FindChild("imaexit3")).GetComponent<Collider>();
		imacortinatel = ((Component)telefono.transform.FindChild("imacortina")).GetComponent<Collider>();
		imaatrastel = ((Component)telefono.transform.FindChild("imaatras")).GetComponent<Collider>();
		hab1 = ((Component)((Component)this).transform.FindChild("habitacion1")).gameObject;
		imaexithab1 = ((Component)hab1.transform.FindChild("imaexit3")).GetComponent<Collider>();
		imacortinahab1 = ((Component)hab1.transform.FindChild("imacortina")).GetComponent<Collider>();
		imaatrashab1 = ((Component)hab1.transform.FindChild("imaatras")).GetComponent<Collider>();
		hab2 = ((Component)((Component)this).transform.FindChild("habitacion2")).gameObject;
		imaexithab2 = ((Component)hab2.transform.FindChild("imaexit3")).GetComponent<Collider>();
		imacortinahab2 = ((Component)hab2.transform.FindChild("imacortina")).GetComponent<Collider>();
		imaatrashab2 = ((Component)hab2.transform.FindChild("imaatras")).GetComponent<Collider>();
		cortinablanca3 = ((Component)casa.transform.FindChild("salonradio/setcortinas1/cortinablanca")).gameObject;
		cortinaverde3 = ((Component)casa.transform.FindChild("salonradio/setcortinas1/cortinaverde")).gameObject;
		cortinaazul3 = ((Component)casa.transform.FindChild("salonradio/setcortinas1/cortinaazul")).gameObject;
		cortinarara3 = ((Component)casa.transform.FindChild("salonradio/setcortinas1/cortinarara")).gameObject;
		cortinablanca4 = ((Component)casa.transform.FindChild("salonradio/setcortinas2/cortinablanca")).gameObject;
		cortinaverde4 = ((Component)casa.transform.FindChild("salonradio/setcortinas2/cortinaverde")).gameObject;
		cortinaazul4 = ((Component)casa.transform.FindChild("salonradio/setcortinas2/cortinaazul")).gameObject;
		cortinarara4 = ((Component)casa.transform.FindChild("salonradio/setcortinas2/cortinarara")).gameObject;
		customizarcortina2 = ((Component)((Component)this).transform.FindChild("customliving2/customizarcortina")).gameObject;
		delverde4 = ((Component)customizarcortina2.transform.FindChild("delverde")).gameObject;
		delblanco4 = ((Component)customizarcortina2.transform.FindChild("delblanco")).gameObject;
		delazul4 = ((Component)customizarcortina2.transform.FindChild("delazul")).gameObject;
		delraro4 = ((Component)customizarcortina2.transform.FindChild("delraro")).gameObject;
		imablanco4 = ((Component)customizarcortina2.transform.FindChild("imablanco")).GetComponent<Collider>();
		imaverde4 = ((Component)customizarcortina2.transform.FindChild("imaverde")).GetComponent<Collider>();
		imaazul4 = ((Component)customizarcortina2.transform.FindChild("imaazul")).GetComponent<Collider>();
		imararo4 = ((Component)customizarcortina2.transform.FindChild("imararo")).GetComponent<Collider>();
		cortinablancalav = ((Component)casa.transform.FindChild("lavabo/setcortina1/cortinablanca")).gameObject;
		cortinaverdelav = ((Component)casa.transform.FindChild("lavabo/setcortina1/cortinaverde")).gameObject;
		cortinaazullav = ((Component)casa.transform.FindChild("lavabo/setcortina1/cortinaazul")).gameObject;
		cortinararalav = ((Component)casa.transform.FindChild("lavabo/setcortina1/cortinarara")).gameObject;
		cortinablancalav2 = ((Component)casa.transform.FindChild("lavabo/setcortina2/cortinablanca")).gameObject;
		cortinaverdelav2 = ((Component)casa.transform.FindChild("lavabo/setcortina2/cortinaverde")).gameObject;
		cortinaazullav2 = ((Component)casa.transform.FindChild("lavabo/setcortina2/cortinaazul")).gameObject;
		cortinararalav2 = ((Component)casa.transform.FindChild("lavabo/setcortina2/cortinarara")).gameObject;
		customizarcortinalav = ((Component)((Component)this).transform.FindChild("custombathroom/customizarcortina")).gameObject;
		delverdelav = ((Component)customizarcortinalav.transform.FindChild("delverde")).gameObject;
		delblancolav = ((Component)customizarcortinalav.transform.FindChild("delblanco")).gameObject;
		delazullav = ((Component)customizarcortinalav.transform.FindChild("delazul")).gameObject;
		delrarolav = ((Component)customizarcortinalav.transform.FindChild("delraro")).gameObject;
		imablancolav = ((Component)customizarcortinalav.transform.FindChild("imablanco")).GetComponent<Collider>();
		imaverdelav = ((Component)customizarcortinalav.transform.FindChild("imaverde")).GetComponent<Collider>();
		imaazullav = ((Component)customizarcortinalav.transform.FindChild("imaazul")).GetComponent<Collider>();
		imararolav = ((Component)customizarcortinalav.transform.FindChild("imararo")).GetComponent<Collider>();
		cortinablancacoc = ((Component)casa.transform.FindChild("cocina/setcortina1/cortinablanca")).gameObject;
		cortinaverdecoc = ((Component)casa.transform.FindChild("cocina/setcortina1/cortinaverde")).gameObject;
		cortinaazulcoc = ((Component)casa.transform.FindChild("cocina/setcortina1/cortinaazul")).gameObject;
		cortinararacoc = ((Component)casa.transform.FindChild("cocina/setcortina1/cortinarara")).gameObject;
		cortinablancacoc2 = ((Component)casa.transform.FindChild("cocina/setcortina2/cortinablanca")).gameObject;
		cortinaverdecoc2 = ((Component)casa.transform.FindChild("cocina/setcortina2/cortinaverde")).gameObject;
		cortinaazulcoc2 = ((Component)casa.transform.FindChild("cocina/setcortina2/cortinaazul")).gameObject;
		cortinararacoc2 = ((Component)casa.transform.FindChild("cocina/setcortina2/cortinarara")).gameObject;
		cortinablancacoc3 = ((Component)casa.transform.FindChild("cocina/setcortina3/cortinablanca")).gameObject;
		cortinaverdecoc3 = ((Component)casa.transform.FindChild("cocina/setcortina3/cortinaverde")).gameObject;
		cortinaazulcoc3 = ((Component)casa.transform.FindChild("cocina/setcortina3/cortinaazul")).gameObject;
		cortinararacoc3 = ((Component)casa.transform.FindChild("cocina/setcortina3/cortinarara")).gameObject;
		cortinablancacoc4 = ((Component)casa.transform.FindChild("cocina/setcortina4/cortinablanca")).gameObject;
		cortinaverdecoc4 = ((Component)casa.transform.FindChild("cocina/setcortina4/cortinaverde")).gameObject;
		cortinaazulcoc4 = ((Component)casa.transform.FindChild("cocina/setcortina4/cortinaazul")).gameObject;
		cortinararacoc4 = ((Component)casa.transform.FindChild("cocina/setcortina4/cortinarara")).gameObject;
		customizarcortinacoc = ((Component)((Component)this).transform.FindChild("customkitchen/customizarcortina")).gameObject;
		delverdecoc = ((Component)customizarcortinacoc.transform.FindChild("delverde")).gameObject;
		delblancococ = ((Component)customizarcortinacoc.transform.FindChild("delblanco")).gameObject;
		delazulcoc = ((Component)customizarcortinacoc.transform.FindChild("delazul")).gameObject;
		delrarococ = ((Component)customizarcortinacoc.transform.FindChild("delraro")).gameObject;
		imablancococ = ((Component)customizarcortinacoc.transform.FindChild("imablanco")).GetComponent<Collider>();
		imaverdecoc = ((Component)customizarcortinacoc.transform.FindChild("imaverde")).GetComponent<Collider>();
		imaazulcoc = ((Component)customizarcortinacoc.transform.FindChild("imaazul")).GetComponent<Collider>();
		imararococ = ((Component)customizarcortinacoc.transform.FindChild("imararo")).GetComponent<Collider>();
		cortinablancatel = ((Component)casa.transform.FindChild("salatelefono/setcortina1/cortinablanca")).gameObject;
		cortinaverdetel = ((Component)casa.transform.FindChild("salatelefono/setcortina1/cortinaverde")).gameObject;
		cortinaazultel = ((Component)casa.transform.FindChild("salatelefono/setcortina1/cortinaazul")).gameObject;
		cortinararatel = ((Component)casa.transform.FindChild("salatelefono/setcortina1/cortinarara")).gameObject;
		customizarcortinatel = ((Component)((Component)this).transform.FindChild("customphone/customizarcortina")).gameObject;
		delverdetel = ((Component)customizarcortinatel.transform.FindChild("delverde")).gameObject;
		delblancotel = ((Component)customizarcortinatel.transform.FindChild("delblanco")).gameObject;
		delazultel = ((Component)customizarcortinatel.transform.FindChild("delazul")).gameObject;
		delrarotel = ((Component)customizarcortinatel.transform.FindChild("delraro")).gameObject;
		imablancotel = ((Component)customizarcortinatel.transform.FindChild("imablanco")).GetComponent<Collider>();
		imaverdetel = ((Component)customizarcortinatel.transform.FindChild("imaverde")).GetComponent<Collider>();
		imaazultel = ((Component)customizarcortinatel.transform.FindChild("imaazul")).GetComponent<Collider>();
		imararotel = ((Component)customizarcortinatel.transform.FindChild("imararo")).GetComponent<Collider>();
		cortinablancahab1 = ((Component)casa.transform.FindChild("habitacion1/setcortina1/cortinablanca")).gameObject;
		cortinaverdehab1 = ((Component)casa.transform.FindChild("habitacion1/setcortina1/cortinaverde")).gameObject;
		cortinaazulhab1 = ((Component)casa.transform.FindChild("habitacion1/setcortina1/cortinaazul")).gameObject;
		cortinararahab1 = ((Component)casa.transform.FindChild("habitacion1/setcortina1/cortinarara")).gameObject;
		customizarcortinahab1 = ((Component)((Component)this).transform.FindChild("customhabitacion1/customizarcortina")).gameObject;
		delverdehab1 = ((Component)customizarcortinahab1.transform.FindChild("delverde")).gameObject;
		delblancohab1 = ((Component)customizarcortinahab1.transform.FindChild("delblanco")).gameObject;
		delazulhab1 = ((Component)customizarcortinahab1.transform.FindChild("delazul")).gameObject;
		delrarohab1 = ((Component)customizarcortinahab1.transform.FindChild("delraro")).gameObject;
		imablancohab1 = ((Component)customizarcortinahab1.transform.FindChild("imablanco")).GetComponent<Collider>();
		imaverdehab1 = ((Component)customizarcortinahab1.transform.FindChild("imaverde")).GetComponent<Collider>();
		imaazulhab1 = ((Component)customizarcortinahab1.transform.FindChild("imaazul")).GetComponent<Collider>();
		imararohab1 = ((Component)customizarcortinahab1.transform.FindChild("imararo")).GetComponent<Collider>();
		cortinablancahab2 = ((Component)casa.transform.FindChild("habitacion2/setcortina1/cortinablanca")).gameObject;
		cortinaverdehab2 = ((Component)casa.transform.FindChild("habitacion2/setcortina1/cortinaverde")).gameObject;
		cortinaazulhab2 = ((Component)casa.transform.FindChild("habitacion2/setcortina1/cortinaazul")).gameObject;
		cortinararahab2 = ((Component)casa.transform.FindChild("habitacion2/setcortina1/cortinararo")).gameObject;
		customizarcortinahab2 = ((Component)((Component)this).transform.FindChild("customhabitacion2/customizarcortina")).gameObject;
		delverdehab2 = ((Component)customizarcortinahab2.transform.FindChild("delverde")).gameObject;
		delblancohab2 = ((Component)customizarcortinahab2.transform.FindChild("delblanco")).gameObject;
		delazulhab2 = ((Component)customizarcortinahab2.transform.FindChild("delazul")).gameObject;
		delrarohab2 = ((Component)customizarcortinahab2.transform.FindChild("delraro")).gameObject;
		imablancohab2 = ((Component)customizarcortinahab2.transform.FindChild("imablanco")).GetComponent<Collider>();
		imaverdehab2 = ((Component)customizarcortinahab2.transform.FindChild("imaverde")).GetComponent<Collider>();
		imaazulhab2 = ((Component)customizarcortinahab2.transform.FindChild("imaazul")).GetComponent<Collider>();
		imararohab2 = ((Component)customizarcortinahab2.transform.FindChild("imararo")).GetComponent<Collider>();
	}

	private void RayCustom2(RaycastHit hit)
	{
		if ((Object)(object)hit.collider == (Object)(object)imablanco2 && !blanco2 && Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= precio)
		{
			blanco2 = true;
			FsmFloat val = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
			val.Value -= precio;
			cortinablanca2.SetActive(true);
			cortinablanca.SetActive(true);
			cortinaverde.SetActive(false);
			cortinaverde2.SetActive(false);
			cortinaazul.SetActive(false);
			cortinaazul2.SetActive(false);
			cortinarara.SetActive(false);
			cortinarara2.SetActive(false);
			delblanco2.SetActive(true);
			verde2 = false;
			azul2 = false;
			raro2 = false;
		}
		if ((Object)(object)hit.collider == (Object)(object)imaverde2 && !verde2 && Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= precio)
		{
			verde2 = true;
			FsmFloat val2 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
			val2.Value -= precio;
			cortinablanca.SetActive(false);
			cortinablanca2.SetActive(false);
			cortinaverde.SetActive(true);
			cortinaverde2.SetActive(true);
			cortinaazul.SetActive(false);
			cortinaazul2.SetActive(false);
			cortinarara.SetActive(false);
			cortinarara2.SetActive(false);
			delverde2.SetActive(true);
			blanco2 = false;
			azul2 = false;
			raro2 = false;
		}
		if ((Object)(object)hit.collider == (Object)(object)imaazul2 && !azul2 && Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= precio)
		{
			azul2 = true;
			FsmFloat val3 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
			val3.Value -= precio;
			cortinablanca.SetActive(false);
			cortinablanca2.SetActive(false);
			cortinaverde.SetActive(false);
			cortinaverde2.SetActive(false);
			cortinaazul.SetActive(true);
			cortinaazul2.SetActive(true);
			cortinarara.SetActive(false);
			cortinarara2.SetActive(false);
			delazul2.SetActive(true);
			blanco2 = false;
			verde2 = false;
			raro2 = false;
		}
		if ((Object)(object)hit.collider == (Object)(object)imararo2 && !raro2 && Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= precio)
		{
			raro2 = true;
			FsmFloat val4 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
			val4.Value -= precio;
			cortinablanca.SetActive(false);
			cortinablanca2.SetActive(false);
			cortinaverde.SetActive(false);
			cortinaverde2.SetActive(false);
			cortinaazul.SetActive(false);
			cortinaazul2.SetActive(false);
			cortinarara.SetActive(true);
			cortinarara2.SetActive(true);
			delraro2.SetActive(true);
			blanco2 = false;
			verde2 = false;
			azul2 = false;
		}
	}

	private void RayCustom22(RaycastHit hit)
	{
		if ((Object)(object)hit.collider == (Object)(object)imablanco4 && !blanco4 && Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= precio)
		{
			blanco4 = true;
			FsmFloat val = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
			val.Value -= precio;
			cortinablanca4.SetActive(true);
			cortinablanca3.SetActive(true);
			cortinaverde3.SetActive(false);
			cortinaverde4.SetActive(false);
			cortinaazul3.SetActive(false);
			cortinaazul4.SetActive(false);
			cortinarara3.SetActive(false);
			cortinarara4.SetActive(false);
			delblanco4.SetActive(true);
			verde4 = false;
			azul4 = false;
			raro4 = false;
		}
		if ((Object)(object)hit.collider == (Object)(object)imaverde4 && !verde4 && Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= precio)
		{
			verde4 = true;
			FsmFloat val2 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
			val2.Value -= precio;
			cortinablanca3.SetActive(false);
			cortinablanca4.SetActive(false);
			cortinaverde3.SetActive(true);
			cortinaverde4.SetActive(true);
			cortinaazul3.SetActive(false);
			cortinaazul4.SetActive(false);
			cortinarara3.SetActive(false);
			cortinarara4.SetActive(false);
			delverde4.SetActive(true);
			blanco4 = false;
			azul4 = false;
			raro4 = false;
		}
		if ((Object)(object)hit.collider == (Object)(object)imaazul4 && !azul4 && Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= precio)
		{
			azul4 = true;
			FsmFloat val3 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
			val3.Value -= precio;
			cortinablanca3.SetActive(false);
			cortinablanca4.SetActive(false);
			cortinaverde3.SetActive(false);
			cortinaverde4.SetActive(false);
			cortinaazul3.SetActive(true);
			cortinaazul4.SetActive(true);
			cortinarara3.SetActive(false);
			cortinarara4.SetActive(false);
			delazul4.SetActive(true);
			blanco4 = false;
			verde4 = false;
			raro4 = false;
		}
		if ((Object)(object)hit.collider == (Object)(object)imararo4 && !raro4 && Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= precio)
		{
			raro4 = true;
			FsmFloat val4 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
			val4.Value -= precio;
			cortinablanca3.SetActive(false);
			cortinablanca4.SetActive(false);
			cortinaverde3.SetActive(false);
			cortinaverde4.SetActive(false);
			cortinaazul3.SetActive(false);
			cortinaazul4.SetActive(false);
			cortinarara3.SetActive(true);
			cortinarara4.SetActive(true);
			delraro4.SetActive(true);
			blanco4 = false;
			verde4 = false;
			azul4 = false;
		}
	}

	private void RayCustomcortinalav(RaycastHit hit)
	{
		if ((Object)(object)hit.collider == (Object)(object)imablancolav && !blancolav && Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= precio)
		{
			blancolav = true;
			FsmFloat val = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
			val.Value -= precio;
			cortinablancalav2.SetActive(true);
			cortinablancalav.SetActive(true);
			cortinaverdelav.SetActive(false);
			cortinaverdelav2.SetActive(false);
			cortinaazullav.SetActive(false);
			cortinaazullav2.SetActive(false);
			cortinararalav.SetActive(false);
			cortinararalav2.SetActive(false);
			delblancolav.SetActive(true);
			verdelav = false;
			azullav = false;
			rarolav = false;
		}
		if ((Object)(object)hit.collider == (Object)(object)imaverdelav && !verdelav && Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= precio)
		{
			verdelav = true;
			FsmFloat val2 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
			val2.Value -= precio;
			cortinablancalav.SetActive(false);
			cortinablancalav2.SetActive(false);
			cortinaverdelav.SetActive(true);
			cortinaverdelav2.SetActive(true);
			cortinaazullav.SetActive(false);
			cortinaazullav2.SetActive(false);
			cortinararalav.SetActive(false);
			cortinararalav2.SetActive(false);
			delverdelav.SetActive(true);
			blancolav = false;
			azullav = false;
			rarolav = false;
		}
		if ((Object)(object)hit.collider == (Object)(object)imaazullav && !azullav && Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= precio)
		{
			azullav = true;
			FsmFloat val3 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
			val3.Value -= precio;
			cortinablancalav.SetActive(false);
			cortinablancalav2.SetActive(false);
			cortinaverdelav.SetActive(false);
			cortinaverdelav2.SetActive(false);
			cortinaazullav.SetActive(true);
			cortinaazullav2.SetActive(true);
			cortinararalav.SetActive(false);
			cortinararalav2.SetActive(false);
			delazullav.SetActive(true);
			blancolav = false;
			verdelav = false;
			rarolav = false;
		}
		if ((Object)(object)hit.collider == (Object)(object)imararolav && !rarolav && Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= precio)
		{
			rarolav = true;
			FsmFloat val4 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
			val4.Value -= precio;
			cortinablancalav.SetActive(false);
			cortinablancalav2.SetActive(false);
			cortinaverdelav.SetActive(false);
			cortinaverdelav2.SetActive(false);
			cortinaazullav.SetActive(false);
			cortinaazullav2.SetActive(false);
			cortinararalav.SetActive(true);
			cortinararalav2.SetActive(true);
			delrarolav.SetActive(true);
			blancolav = false;
			verdelav = false;
			azullav = false;
		}
	}

	private void RayCustomcortinacoc(RaycastHit hit)
	{
		if ((Object)(object)hit.collider == (Object)(object)imablancococ && !blancococ && Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= precio)
		{
			blancococ = true;
			FsmFloat val = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
			val.Value -= precio;
			cortinablancacoc2.SetActive(true);
			cortinablancacoc.SetActive(true);
			cortinablancacoc3.SetActive(true);
			cortinablancacoc4.SetActive(true);
			cortinaverdecoc.SetActive(false);
			cortinaverdecoc2.SetActive(false);
			cortinaverdecoc3.SetActive(false);
			cortinaverdecoc4.SetActive(false);
			cortinaazulcoc.SetActive(false);
			cortinaazulcoc2.SetActive(false);
			cortinaazulcoc3.SetActive(false);
			cortinaazulcoc4.SetActive(false);
			cortinararacoc.SetActive(false);
			cortinararacoc2.SetActive(false);
			cortinararacoc3.SetActive(false);
			cortinararacoc4.SetActive(false);
			delblancococ.SetActive(true);
			verdecoc = false;
			azulcoc = false;
			rarococ = false;
		}
		if ((Object)(object)hit.collider == (Object)(object)imaverdecoc && !verdecoc && Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= precio)
		{
			verdecoc = true;
			FsmFloat val2 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
			val2.Value -= precio;
			cortinablancacoc2.SetActive(false);
			cortinablancacoc.SetActive(false);
			cortinablancacoc3.SetActive(false);
			cortinablancacoc4.SetActive(false);
			cortinaverdecoc.SetActive(true);
			cortinaverdecoc2.SetActive(true);
			cortinaverdecoc3.SetActive(true);
			cortinaverdecoc4.SetActive(true);
			cortinaazulcoc.SetActive(false);
			cortinaazulcoc2.SetActive(false);
			cortinaazulcoc3.SetActive(false);
			cortinaazulcoc4.SetActive(false);
			cortinararacoc.SetActive(false);
			cortinararacoc2.SetActive(false);
			cortinararacoc3.SetActive(false);
			cortinararacoc4.SetActive(false);
			delverdecoc.SetActive(true);
			blancococ = false;
			azulcoc = false;
			rarococ = false;
		}
		if ((Object)(object)hit.collider == (Object)(object)imaazulcoc && !azulcoc && Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= precio)
		{
			azulcoc = true;
			FsmFloat val3 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
			val3.Value -= precio;
			cortinablancacoc2.SetActive(false);
			cortinablancacoc.SetActive(false);
			cortinablancacoc3.SetActive(false);
			cortinablancacoc4.SetActive(false);
			cortinaverdecoc.SetActive(false);
			cortinaverdecoc2.SetActive(false);
			cortinaverdecoc3.SetActive(false);
			cortinaverdecoc4.SetActive(false);
			cortinaazulcoc.SetActive(true);
			cortinaazulcoc2.SetActive(true);
			cortinaazulcoc3.SetActive(true);
			cortinaazulcoc4.SetActive(true);
			cortinararacoc.SetActive(false);
			cortinararacoc2.SetActive(false);
			cortinararacoc3.SetActive(false);
			cortinararacoc4.SetActive(false);
			delazulcoc.SetActive(true);
			blancococ = false;
			verdecoc = false;
			rarococ = false;
		}
		if ((Object)(object)hit.collider == (Object)(object)imararococ && !rarococ && Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= precio)
		{
			rarococ = true;
			FsmFloat val4 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
			val4.Value -= precio;
			cortinablancacoc2.SetActive(false);
			cortinablancacoc.SetActive(false);
			cortinablancacoc3.SetActive(false);
			cortinablancacoc4.SetActive(false);
			cortinaverdecoc.SetActive(false);
			cortinaverdecoc2.SetActive(false);
			cortinaverdecoc3.SetActive(false);
			cortinaverdecoc4.SetActive(false);
			cortinaazulcoc.SetActive(false);
			cortinaazulcoc2.SetActive(false);
			cortinaazulcoc3.SetActive(false);
			cortinaazulcoc4.SetActive(false);
			cortinararacoc.SetActive(true);
			cortinararacoc2.SetActive(true);
			cortinararacoc3.SetActive(true);
			cortinararacoc4.SetActive(true);
			delrarococ.SetActive(true);
			blancococ = false;
			verdecoc = false;
			azulcoc = false;
		}
	}

	private void RayCustomcortinatel(RaycastHit hit)
	{
		if ((Object)(object)hit.collider == (Object)(object)imablancotel && !blancotel && Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= precio)
		{
			blancotel = true;
			FsmFloat val = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
			val.Value -= precio;
			cortinablancatel.SetActive(true);
			cortinaverdetel.SetActive(false);
			cortinaazultel.SetActive(false);
			cortinararatel.SetActive(false);
			delblancotel.SetActive(true);
			verdetel = false;
			azultel = false;
			rarotel = false;
		}
		if ((Object)(object)hit.collider == (Object)(object)imaverdetel && !verdetel && Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= precio)
		{
			verdetel = true;
			FsmFloat val2 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
			val2.Value -= precio;
			cortinablancatel.SetActive(false);
			cortinaverdetel.SetActive(true);
			cortinaazultel.SetActive(false);
			cortinararatel.SetActive(false);
			delverdetel.SetActive(true);
			blancotel = false;
			azultel = false;
			rarotel = false;
		}
		if ((Object)(object)hit.collider == (Object)(object)imaazultel && !azultel && Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= precio)
		{
			azultel = true;
			FsmFloat val3 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
			val3.Value -= precio;
			cortinablancatel.SetActive(false);
			cortinaverdetel.SetActive(false);
			cortinaazultel.SetActive(true);
			cortinararatel.SetActive(false);
			delazultel.SetActive(true);
			blancotel = false;
			verdetel = false;
			rarotel = false;
		}
		if ((Object)(object)hit.collider == (Object)(object)imararotel && !rarotel && Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= precio)
		{
			rarotel = true;
			FsmFloat val4 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
			val4.Value -= precio;
			cortinablancatel.SetActive(false);
			cortinaverdetel.SetActive(false);
			cortinaazultel.SetActive(false);
			cortinararatel.SetActive(true);
			delrarotel.SetActive(true);
			blancotel = false;
			verdetel = false;
			azultel = false;
		}
	}

	private void RayCustomcortinahab1(RaycastHit hit)
	{
		if ((Object)(object)hit.collider == (Object)(object)imablancohab1 && !blancohab1 && Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= precio)
		{
			blancohab1 = true;
			FsmFloat val = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
			val.Value -= precio;
			cortinablancahab1.SetActive(true);
			cortinaverdehab1.SetActive(false);
			cortinaazulhab1.SetActive(false);
			cortinararahab1.SetActive(false);
			delblancohab1.SetActive(true);
			verdehab1 = false;
			azulhab1 = false;
			rarohab1 = false;
		}
		if ((Object)(object)hit.collider == (Object)(object)imaverdehab1 && !verdehab1 && Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= precio)
		{
			verdehab1 = true;
			FsmFloat val2 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
			val2.Value -= precio;
			cortinablancahab1.SetActive(false);
			cortinaverdehab1.SetActive(true);
			cortinaazulhab1.SetActive(false);
			cortinararahab1.SetActive(false);
			delverdehab1.SetActive(true);
			blancohab1 = false;
			azulhab1 = false;
			rarohab1 = false;
		}
		if ((Object)(object)hit.collider == (Object)(object)imaazulhab1 && !azulhab1 && Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= precio)
		{
			azulhab1 = true;
			FsmFloat val3 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
			val3.Value -= precio;
			cortinablancahab1.SetActive(false);
			cortinaverdehab1.SetActive(false);
			cortinaazulhab1.SetActive(true);
			cortinararahab1.SetActive(false);
			delazulhab1.SetActive(true);
			blancohab1 = false;
			verdehab1 = false;
			rarohab1 = false;
		}
		if ((Object)(object)hit.collider == (Object)(object)imararohab1 && !rarohab1 && Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= precio)
		{
			rarohab1 = true;
			FsmFloat val4 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
			val4.Value -= precio;
			cortinablancahab1.SetActive(false);
			cortinaverdehab1.SetActive(false);
			cortinaazulhab1.SetActive(false);
			cortinararahab1.SetActive(true);
			delrarohab1.SetActive(true);
			blancohab1 = false;
			verdehab1 = false;
			azulhab1 = false;
		}
	}

	private void RayCustomcortinahab2(RaycastHit hit)
	{
		if ((Object)(object)hit.collider == (Object)(object)imablancohab2 && !blancohab2 && Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= precio)
		{
			blancohab2 = true;
			FsmFloat val = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
			val.Value -= precio;
			cortinablancahab2.SetActive(true);
			cortinaverdehab2.SetActive(false);
			cortinaazulhab2.SetActive(false);
			cortinararahab2.SetActive(false);
			delblancohab2.SetActive(true);
			verdehab2 = false;
			azulhab2 = false;
			rarohab2 = false;
		}
		if ((Object)(object)hit.collider == (Object)(object)imaverdehab2 && !verdehab2 && Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= precio)
		{
			verdehab2 = true;
			FsmFloat val2 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
			val2.Value -= precio;
			cortinablancahab2.SetActive(false);
			cortinaverdehab2.SetActive(true);
			cortinaazulhab2.SetActive(false);
			cortinararahab2.SetActive(false);
			delverdehab2.SetActive(true);
			blancohab2 = false;
			azulhab2 = false;
			rarohab2 = false;
		}
		if ((Object)(object)hit.collider == (Object)(object)imaazulhab2 && !azulhab2 && Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= precio)
		{
			azulhab2 = true;
			FsmFloat val3 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
			val3.Value -= precio;
			cortinablancahab2.SetActive(false);
			cortinaverdehab2.SetActive(false);
			cortinaazulhab2.SetActive(true);
			cortinararahab2.SetActive(false);
			delazulhab2.SetActive(true);
			blancohab2 = false;
			verdehab2 = false;
			rarohab2 = false;
		}
		if ((Object)(object)hit.collider == (Object)(object)imararohab2 && !rarohab2 && Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= precio)
		{
			rarohab2 = true;
			FsmFloat val4 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
			val4.Value -= precio;
			cortinablancahab2.SetActive(false);
			cortinaverdehab2.SetActive(false);
			cortinaazulhab2.SetActive(false);
			cortinararahab2.SetActive(true);
			delrarohab2.SetActive(true);
			blancohab2 = false;
			verdehab2 = false;
			azulhab2 = false;
		}
	}

	private void SetupCustom2()
	{
		if (!blanco2)
		{
			delblanco2.SetActive(false);
		}
		if (!verde2)
		{
			delverde2.SetActive(false);
		}
		if (!azul2)
		{
			delazul2.SetActive(false);
		}
		if (!raro2)
		{
			delraro2.SetActive(false);
		}
	}

	private void SetupCustom22()
	{
		if (!blanco4)
		{
			delblanco4.SetActive(false);
		}
		if (!verde4)
		{
			delverde4.SetActive(false);
		}
		if (!azul4)
		{
			delazul4.SetActive(false);
		}
		if (!raro4)
		{
			delraro4.SetActive(false);
		}
	}

	private void SetupCustomcortinalav()
	{
		if (!blancolav)
		{
			delblancolav.SetActive(false);
		}
		if (!verdelav)
		{
			delverdelav.SetActive(false);
		}
		if (!azullav)
		{
			delazullav.SetActive(false);
		}
		if (!rarolav)
		{
			delrarolav.SetActive(false);
		}
	}

	private void SetupCustomcortinacoc()
	{
		if (!blancococ)
		{
			delblancococ.SetActive(false);
		}
		if (!verdecoc)
		{
			delverdecoc.SetActive(false);
		}
		if (!azulcoc)
		{
			delazulcoc.SetActive(false);
		}
		if (!rarococ)
		{
			delrarococ.SetActive(false);
		}
	}

	private void SetupCustomcortinatel()
	{
		if (!blancotel)
		{
			delblancotel.SetActive(false);
		}
		if (!verdetel)
		{
			delverdetel.SetActive(false);
		}
		if (!azultel)
		{
			delazultel.SetActive(false);
		}
		if (!rarotel)
		{
			delrarotel.SetActive(false);
		}
	}

	private void SetupCustomcortinahab1()
	{
		if (!blancohab1)
		{
			delblancohab1.SetActive(false);
		}
		if (!verdehab1)
		{
			delverdehab1.SetActive(false);
		}
		if (!azulhab1)
		{
			delazulhab1.SetActive(false);
		}
		if (!rarohab1)
		{
			delrarohab1.SetActive(false);
		}
	}

	private void SetupCustomcortinahab2()
	{
		if (!blancohab2)
		{
			delblancohab2.SetActive(false);
		}
		if (!verdehab2)
		{
			delverdehab2.SetActive(false);
		}
		if (!azulhab2)
		{
			delazulhab2.SetActive(false);
		}
		if (!rarohab2)
		{
			delrarohab2.SetActive(false);
		}
	}

	private void Paginas()
	{
		if (opcion)
		{
			opciones.SetActive(true);
			livingroom.SetActive(false);
			customizarcortina.SetActive(false);
			livingroom2.SetActive(false);
			customizarcortina2.SetActive(false);
			bathroom.SetActive(false);
			customizarcortinalav.SetActive(false);
			kitchen.SetActive(false);
			customizarcortinacoc.SetActive(false);
			telefono.SetActive(false);
			customizarcortinatel.SetActive(false);
			hab1.SetActive(false);
			customizarcortinahab1.SetActive(false);
			hab2.SetActive(false);
			customizarcortinahab2.SetActive(false);
			customizar1.SetActive(true);
		}
		if (living)
		{
			opciones.SetActive(false);
			livingroom.SetActive(true);
			livingroom2.SetActive(false);
			bathroom.SetActive(false);
			kitchen.SetActive(false);
			telefono.SetActive(false);
			hab1.SetActive(false);
			hab2.SetActive(false);
		}
		if (living2)
		{
			opciones.SetActive(false);
			livingroom2.SetActive(true);
			livingroom.SetActive(false);
			bathroom.SetActive(false);
			kitchen.SetActive(false);
			telefono.SetActive(false);
			hab1.SetActive(false);
			hab2.SetActive(false);
		}
		if (bath)
		{
			opciones.SetActive(false);
			livingroom2.SetActive(false);
			livingroom.SetActive(false);
			bathroom.SetActive(true);
			kitchen.SetActive(false);
			telefono.SetActive(false);
			hab1.SetActive(false);
			hab2.SetActive(false);
		}
		if (kitc)
		{
			opciones.SetActive(false);
			livingroom2.SetActive(false);
			livingroom.SetActive(false);
			bathroom.SetActive(false);
			kitchen.SetActive(true);
			telefono.SetActive(false);
			hab1.SetActive(false);
			hab2.SetActive(false);
		}
		if (telf)
		{
			opciones.SetActive(false);
			livingroom2.SetActive(false);
			livingroom.SetActive(false);
			bathroom.SetActive(false);
			kitchen.SetActive(false);
			telefono.SetActive(true);
			hab1.SetActive(false);
			hab2.SetActive(false);
		}
		if (habita1)
		{
			opciones.SetActive(false);
			livingroom2.SetActive(false);
			livingroom.SetActive(false);
			bathroom.SetActive(false);
			kitchen.SetActive(false);
			telefono.SetActive(false);
			hab1.SetActive(true);
			hab2.SetActive(false);
		}
		if (habita2)
		{
			opciones.SetActive(false);
			livingroom2.SetActive(false);
			livingroom.SetActive(false);
			bathroom.SetActive(false);
			kitchen.SetActive(false);
			telefono.SetActive(false);
			hab1.SetActive(false);
			hab2.SetActive(true);
		}
		if (customcortina)
		{
			customizarcortina.SetActive(true);
			customizarcortina2.SetActive(false);
			customizarcortinalav.SetActive(false);
			customizarcortinacoc.SetActive(false);
			customizarcortinatel.SetActive(false);
			customizarcortinahab1.SetActive(false);
			customizarcortinahab2.SetActive(false);
			customizar1.SetActive(false);
		}
		if (customcortina2)
		{
			customizarcortina2.SetActive(true);
			customizarcortina.SetActive(false);
			customizarcortinalav.SetActive(false);
			customizarcortinacoc.SetActive(false);
			customizarcortinatel.SetActive(false);
			customizarcortinahab1.SetActive(false);
			customizarcortinahab2.SetActive(false);
			customizar1.SetActive(false);
		}
		if (customcortinalav)
		{
			customizarcortina2.SetActive(false);
			customizarcortina.SetActive(false);
			customizarcortinalav.SetActive(true);
			customizarcortinacoc.SetActive(false);
			customizarcortinatel.SetActive(false);
			customizarcortinahab1.SetActive(false);
			customizarcortinahab2.SetActive(false);
			customizar1.SetActive(false);
		}
		if (customcortinacoc)
		{
			customizarcortina2.SetActive(false);
			customizarcortina.SetActive(false);
			customizarcortinalav.SetActive(false);
			customizarcortinacoc.SetActive(true);
			customizarcortinatel.SetActive(false);
			customizarcortinahab1.SetActive(false);
			customizarcortinahab2.SetActive(false);
			customizar1.SetActive(false);
		}
		if (customcortinatel)
		{
			customizarcortina2.SetActive(false);
			customizarcortina.SetActive(false);
			customizarcortinalav.SetActive(false);
			customizarcortinacoc.SetActive(false);
			customizarcortinatel.SetActive(true);
			customizarcortinahab1.SetActive(false);
			customizarcortinahab2.SetActive(false);
			customizar1.SetActive(false);
		}
		if (customcortinahab1)
		{
			customizarcortina2.SetActive(false);
			customizarcortina.SetActive(false);
			customizarcortinalav.SetActive(false);
			customizarcortinacoc.SetActive(false);
			customizarcortinatel.SetActive(false);
			customizarcortinahab1.SetActive(true);
			customizarcortinahab2.SetActive(false);
			customizar1.SetActive(false);
		}
		if (customcortinahab2)
		{
			customizarcortina2.SetActive(false);
			customizarcortina.SetActive(false);
			customizarcortinalav.SetActive(false);
			customizarcortinacoc.SetActive(false);
			customizarcortinatel.SetActive(false);
			customizarcortinahab1.SetActive(false);
			customizarcortinahab2.SetActive(true);
			customizar1.SetActive(false);
		}
		if (!customcortina && !customcortina2 && !customcortinalav && !customcortinacoc && !customcortinatel && !customcortinahab1 && !customcortinahab2)
		{
			customizarcortina.SetActive(false);
			customizarcortina2.SetActive(false);
			customizarcortinalav.SetActive(false);
			customizarcortinacoc.SetActive(false);
			customizarcortinatel.SetActive(false);
			customizarcortinahab1.SetActive(false);
			customizarcortinahab2.SetActive(false);
			customizar1.SetActive(true);
		}
		if (compras)
		{
			Object.FindObjectOfType<CasaBehaviour>().mirandopapel = true;
			Object.FindObjectOfType<CasaBehaviour>().mirandopapel2 = false;
		}
	}

	private void RayLiving(RaycastHit hit)
	{
		if ((Object)(object)hit.collider == (Object)(object)imacortina && Input.GetMouseButtonDown(0))
		{
			customcortina = true;
		}
		if ((Object)(object)hit.collider == (Object)(object)imaatras && Input.GetMouseButtonDown(0))
		{
			if (customcortina)
			{
				opcion = false;
				living = true;
				customcortina = false;
			}
			else
			{
				opcion = true;
				living = false;
				customcortina = false;
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)imaexit3 && Input.GetMouseButtonDown(0))
		{
			Object.FindObjectOfType<CasaBehaviour>()._playerInMenu.Value = false;
			FsmVariables.GlobalVariables.FindFsmBool("PlayerStop").Value = false;
			Object.FindObjectOfType<CasaBehaviour>().mirandopapel = false;
			Object.FindObjectOfType<CasaBehaviour>().mirandopapel2 = false;
		}
	}

	private void RayLiving2(RaycastHit hit)
	{
		if ((Object)(object)hit.collider == (Object)(object)imacortina2 && Input.GetMouseButtonDown(0))
		{
			customcortina2 = true;
		}
		if ((Object)(object)hit.collider == (Object)(object)imaatras2 && Input.GetMouseButtonDown(0))
		{
			if (customcortina2)
			{
				opcion = false;
				living2 = true;
				customcortina2 = false;
			}
			else
			{
				opcion = true;
				living2 = false;
				customcortina2 = false;
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)imaexit4 && Input.GetMouseButtonDown(0))
		{
			Object.FindObjectOfType<CasaBehaviour>()._playerInMenu.Value = false;
			FsmVariables.GlobalVariables.FindFsmBool("PlayerStop").Value = false;
			Object.FindObjectOfType<CasaBehaviour>().mirandopapel = false;
			Object.FindObjectOfType<CasaBehaviour>().mirandopapel2 = false;
		}
	}

	private void RayBath(RaycastHit hit)
	{
		if ((Object)(object)hit.collider == (Object)(object)imacortinalav && Input.GetMouseButtonDown(0))
		{
			customcortinalav = true;
		}
		if ((Object)(object)hit.collider == (Object)(object)imaatraslav && Input.GetMouseButtonDown(0))
		{
			if (customcortinalav)
			{
				opcion = false;
				bath = true;
				customcortinalav = false;
			}
			else
			{
				opcion = true;
				bath = false;
				customcortinalav = false;
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)imaexitlav && Input.GetMouseButtonDown(0))
		{
			Object.FindObjectOfType<CasaBehaviour>()._playerInMenu.Value = false;
			FsmVariables.GlobalVariables.FindFsmBool("PlayerStop").Value = false;
			Object.FindObjectOfType<CasaBehaviour>().mirandopapel = false;
			Object.FindObjectOfType<CasaBehaviour>().mirandopapel2 = false;
		}
	}

	private void RayKitch(RaycastHit hit)
	{
		if ((Object)(object)hit.collider == (Object)(object)imacortinacoc && Input.GetMouseButtonDown(0))
		{
			customcortinacoc = true;
		}
		if ((Object)(object)hit.collider == (Object)(object)imaatrascoc && Input.GetMouseButtonDown(0))
		{
			if (customcortinacoc)
			{
				opcion = false;
				kitc = true;
				customcortinacoc = false;
			}
			else
			{
				opcion = true;
				kitc = false;
				customcortinacoc = false;
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)imaexitcoc && Input.GetMouseButtonDown(0))
		{
			Object.FindObjectOfType<CasaBehaviour>()._playerInMenu.Value = false;
			FsmVariables.GlobalVariables.FindFsmBool("PlayerStop").Value = false;
			Object.FindObjectOfType<CasaBehaviour>().mirandopapel = false;
			Object.FindObjectOfType<CasaBehaviour>().mirandopapel2 = false;
		}
	}

	private void RayPhone(RaycastHit hit)
	{
		if ((Object)(object)hit.collider == (Object)(object)imacortinatel && Input.GetMouseButtonDown(0))
		{
			customcortinatel = true;
		}
		if ((Object)(object)hit.collider == (Object)(object)imaatrastel && Input.GetMouseButtonDown(0))
		{
			if (customcortinatel)
			{
				opcion = false;
				telf = true;
				customcortinatel = false;
			}
			else
			{
				opcion = true;
				telf = false;
				customcortinatel = false;
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)imaexittel && Input.GetMouseButtonDown(0))
		{
			Object.FindObjectOfType<CasaBehaviour>()._playerInMenu.Value = false;
			FsmVariables.GlobalVariables.FindFsmBool("PlayerStop").Value = false;
			Object.FindObjectOfType<CasaBehaviour>().mirandopapel = false;
			Object.FindObjectOfType<CasaBehaviour>().mirandopapel2 = false;
		}
	}

	private void RayHab1(RaycastHit hit)
	{
		if ((Object)(object)hit.collider == (Object)(object)imacortinahab1 && Input.GetMouseButtonDown(0))
		{
			customcortinahab1 = true;
		}
		if ((Object)(object)hit.collider == (Object)(object)imaatrashab1 && Input.GetMouseButtonDown(0))
		{
			if (customcortinahab1)
			{
				opcion = false;
				habita1 = true;
				customcortinahab1 = false;
			}
			else
			{
				opcion = true;
				habita1 = false;
				customcortinahab1 = false;
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)imaexithab1 && Input.GetMouseButtonDown(0))
		{
			Object.FindObjectOfType<CasaBehaviour>()._playerInMenu.Value = false;
			FsmVariables.GlobalVariables.FindFsmBool("PlayerStop").Value = false;
			Object.FindObjectOfType<CasaBehaviour>().mirandopapel = false;
			Object.FindObjectOfType<CasaBehaviour>().mirandopapel2 = false;
		}
	}

	private void RayHab2(RaycastHit hit)
	{
		if ((Object)(object)hit.collider == (Object)(object)imacortinahab2 && Input.GetMouseButtonDown(0))
		{
			customcortinahab2 = true;
		}
		if ((Object)(object)hit.collider == (Object)(object)imaatrashab2 && Input.GetMouseButtonDown(0))
		{
			if (customcortinahab2)
			{
				opcion = false;
				habita2 = true;
				customcortinahab2 = false;
			}
			else
			{
				opcion = true;
				habita2 = false;
				customcortinahab2 = false;
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)imaexithab2 && Input.GetMouseButtonDown(0))
		{
			Object.FindObjectOfType<CasaBehaviour>()._playerInMenu.Value = false;
			FsmVariables.GlobalVariables.FindFsmBool("PlayerStop").Value = false;
			Object.FindObjectOfType<CasaBehaviour>().mirandopapel = false;
			Object.FindObjectOfType<CasaBehaviour>().mirandopapel2 = false;
		}
	}

	private void RayOpciones(RaycastHit hit)
	{
		if ((Object)(object)hit.collider == (Object)(object)imalivingroom && Input.GetMouseButtonDown(0))
		{
			living = true;
		}
		if ((Object)(object)hit.collider == (Object)(object)imalivingroom2 && Input.GetMouseButtonDown(0))
		{
			living2 = true;
		}
		if ((Object)(object)hit.collider == (Object)(object)imabathroom && Input.GetMouseButtonDown(0))
		{
			bath = true;
		}
		if ((Object)(object)hit.collider == (Object)(object)imakitchen && Input.GetMouseButtonDown(0))
		{
			kitc = true;
		}
		if ((Object)(object)hit.collider == (Object)(object)imatelf && Input.GetMouseButtonDown(0))
		{
			telf = true;
		}
		if ((Object)(object)hit.collider == (Object)(object)imahab1 && Input.GetMouseButtonDown(0))
		{
			habita1 = true;
		}
		if ((Object)(object)hit.collider == (Object)(object)imahab2 && Input.GetMouseButtonDown(0))
		{
			habita2 = true;
		}
		if ((Object)(object)hit.collider == (Object)(object)imaaccesorios && Input.GetMouseButtonDown(0))
		{
			compras = true;
		}
		if ((Object)(object)hit.collider == (Object)(object)imaexit2 && Input.GetMouseButtonDown(0))
		{
			Object.FindObjectOfType<CasaBehaviour>()._playerInMenu.Value = false;
			FsmVariables.GlobalVariables.FindFsmBool("PlayerStop").Value = false;
			Object.FindObjectOfType<CasaBehaviour>().mirandopapel = false;
			Object.FindObjectOfType<CasaBehaviour>().mirandopapel2 = false;
		}
	}

	private void Update()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GameObject.Find("PLAYER") != (Object)null))
		{
			return;
		}
		RaycastHit[] array = Physics.RaycastAll(Camera.main.ScreenPointToRay(Input.mousePosition), 1.5f);
		foreach (RaycastHit hit in array)
		{
			if (!compras)
			{
				if (customcortina)
				{
					RayCustom2(hit);
				}
				if (customcortina2)
				{
					RayCustom22(hit);
				}
				if (customcortinalav)
				{
					RayCustomcortinalav(hit);
				}
				if (customcortinacoc)
				{
					RayCustomcortinacoc(hit);
				}
				if (customcortinatel)
				{
					RayCustomcortinatel(hit);
				}
				if (customcortinahab1)
				{
					RayCustomcortinahab1(hit);
				}
				if (customcortinahab2)
				{
					RayCustomcortinahab2(hit);
				}
				if (opcion)
				{
					RayOpciones(hit);
				}
				if (living)
				{
					RayLiving(hit);
				}
				if (living2)
				{
					RayLiving2(hit);
				}
				if (bath)
				{
					RayBath(hit);
				}
				if (kitc)
				{
					RayKitch(hit);
				}
				if (telf)
				{
					RayPhone(hit);
				}
				if (habita1)
				{
					RayHab1(hit);
				}
				if (habita2)
				{
					RayHab2(hit);
				}
			}
		}
		if (customcortina && !compras)
		{
			SetupCustom2();
		}
		if (customcortina2 && !compras)
		{
			SetupCustom22();
		}
		if (customcortinalav && !compras)
		{
			SetupCustomcortinalav();
		}
		if (customcortinacoc && !compras)
		{
			SetupCustomcortinacoc();
		}
		if (customcortinatel && !compras)
		{
			SetupCustomcortinatel();
		}
		if (customcortinahab1 && !compras)
		{
			SetupCustomcortinahab1();
		}
		if (customcortinahab2 && !compras)
		{
			SetupCustomcortinahab2();
		}
		Paginas();
	}
}
