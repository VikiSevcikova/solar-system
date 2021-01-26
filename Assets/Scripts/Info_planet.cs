using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info_planet : MonoBehaviour {
    public static string nazov="Názov";
    public GameObject target;
    Rect windowRect = new Rect(20, 20, 300, 250);
    
    void OnGUI()
    {
		if (nazov.Equals ("Merkur"))
			windowRect = GUI.Window (0, windowRect, DoMyWindow, nazov);
		else if (nazov.Equals ("Venuša"))
			windowRect = GUI.Window (1, windowRect, DoMyWindow, nazov);
		else if (nazov.Equals ("Zem"))
			windowRect = GUI.Window (2, windowRect, DoMyWindow, nazov);
		else if (nazov.Equals ("Mars"))
			windowRect = GUI.Window (3, windowRect, DoMyWindow, nazov);
		else if (nazov.Equals ("Jupiter"))
			windowRect = GUI.Window (4, windowRect, DoMyWindow, nazov);
		else if (nazov.Equals ("Saturn"))
			windowRect = GUI.Window (5, windowRect, DoMyWindow, nazov);
		else if (nazov.Equals ("Urán"))
			windowRect = GUI.Window (6, windowRect, DoMyWindow, nazov);
		else if (nazov.Equals ("Neptún"))
			windowRect = GUI.Window (7, windowRect, DoMyWindow, nazov);
		else if (nazov.Equals ("Pluto"))
			windowRect = GUI.Window (8, windowRect, DoMyWindow, nazov);
			
    }

    void DoMyWindow(int windowID)
    {
		
        if(windowID == 0)
        GUI.TextField(new Rect (2,20,296,250),
            "Stredná vzdialenosť od Slnka: 57,9 mil. km \n"+
            "Nejmenšia vzdialenosť od Slnka: 45, 9 mil.km \n" +
            "Najvetšia vzdialenosť od Slnka: 69, 7 mil.km \n" +
            "Doba obehu okolo slnka: 87, 97 dne \n" +
            "Rýchlosť obehu okolo slnka: 47, 88 km / s \n" +
            "Doba otočenia okolo svojej osy: 58, 65 dne \n" +
            "Priemer planéty: 4878 km \n" +
            "Hmotnosť: 3, 303 E + 23 kg \n" +
            "Hustota: 5423 kg / m3 \n" +
            "Teplota na povrchu: 700K až 100K \n" +
            "Chemické zloženie atmosféry: H, He, Ar, Ne \n" +
            "Magnetické pole: 5 E - 7 T \n" +
            "Mesiace -  \n");
        if (windowID == 1)
            GUI.TextField(new Rect(2, 20, 296, 250),
                "Stredná vzdialenosť od Slnka: 108,3 mil. km \n" +
                "Nejmenšia vzdialenosť od Slnka: 107,4 mil.km \n" +
                "Najvetšia vzdialenosť od Slnka: 108,9 mil.km \n" +
                "Doba obehu okolo slnka: 224,7 dne \n" +
                "Rýchlosť obehu okolo slnka: 35,02 km / s \n" +
                "Doba otočenia okolo svojej osy: 243,01 dne \n" +
                "Priemer planéty: 12103 km \n" +
                "Hmotnosť: 4,78 E + 24 kg \n" +
                "Hustota: 5256 kg / m3 \n" +
                "Teplota na povrchu: 750K \n" +
                "Chemické zloženie atmosféry: CO2 \n" +
                "Magnetické pole: 5 E - 9 T \n" +
                "Mesiace -  \n");
        if (windowID == 2)
            GUI.TextField(new Rect(2, 20, 296, 250),
                "Stredná vzdialenosť od Slnka: 149,6 mil. km \n" +
                "Nejmenšia vzdialenosť od Slnka: 147,0 mil.km \n" +
                "Najvetšia vzdialenosť od Slnka: 152,0 mil.km \n" +
                "Doba obehu okolo slnka: 365,256 dne \n" +
                "Rýchlosť obehu okolo slnka: 29,79 km / s \n" +
                "Doba otočenia okolo svojej osy: 23h 56m 4s \n" +
                "Priemer planéty: 12756 km \n" +
                "Hmotnosť: 5,976 E + 24 kg \n" +
                "Hustota: 5520 kg / m3 \n" +
                "Teplota na povrchu: 295K \n" +
                "Chemické zloženie atmosféry: N2, O2 \n" +
                "Magnetické pole: 5 E - 5 T \n" +
                "Mesiace -  1\n");
        if (windowID == 3)
            GUI.TextField(new Rect(2, 20, 296, 250),
                "Stredná vzdialenosť od Slnka: 227,9 mil. km \n" +
                "Nejmenšia vzdialenosť od Slnka: 206,6 mil.km \n" +
                "Najvetšia vzdialenosť od Slnka: 249,1 mil.km \n" +
                "Doba obehu okolo slnka: 686,98 dne \n" +
                "Rýchlosť obehu okolo slnka: 24,14 km / s \n" +
                "Doba otočenia okolo svojej osy: 24 h 37 m 23 s \n" +
                "Priemer planéty: 6787 km \n" +
                "Hmotnosť: 6,42 E+23 kg \n" +
                "Hustota: 3940 kg / m3 \n" +
                "Teplota na povrchu: 180 K až 250 K\n" +
                "Chemické zloženie atmosféry: CO2, Ar\n" +
                "Magnetické pole: 1 E-7 T \n" +
                "Mesiace -  2\n");
        if (windowID == 4)
            GUI.TextField(new Rect(2, 20, 296, 250),
                "Stredná vzdialenosť od Slnka: 778,2 mil. km \n" +
                "Nejmenšia vzdialenosť od Slnka: 740,8 mil.km \n" +
                "Najvetšia vzdialenosť od Slnka: 815,6 mil.km \n" +
                "Doba obehu okolo slnka: 11,86 roku \n" +
                "Rýchlosť obehu okolo slnka: 13,06 km/s \n" +
                "Doba otočenia okolo svojej osy: 9 h 50 m 30 s \n" +
                "Priemer planéty: 142200 km\n" +
                "Hmotnosť: 1,9 E+27 kg \n" +
                "Hustota: 1310 kg / m3 \n" +
                "Teplota na povrchu: 120 K\n" +
                "Chemické zloženie atmosféry: H2, He\n" +
                "Magnetické pole: 5 E-4 T \n" +
                "Mesiace -  16\n");
        if (windowID == 5)
            GUI.TextField(new Rect(2, 20, 296, 250),
                "Stredná vzdialenosť od Slnka: 1427 mil. km \n" +
                "Nejmenšia vzdialenosť od Slnka: 1347 mil.km \n" +
                "Najvetšia vzdialenosť od Slnka: 1507 mil.km \n" +
                "Doba obehu okolo slnka: 29,46 roku \n" +
                "Rýchlosť obehu okolo slnka: 9,64 km/s \n" +
                "Doba otočenia okolo svojej osy: 10 h 39 m 26 s \n" +
                "Priemer planéty: 106900 km \n" +
                "Hmotnosť: 5,7 E+26 kg \n" +
                "Hustota: 690 kg/m3\n" +
                "Teplota na povrchu: 90 K\n" +
                "Chemické zloženie atmosféry: H2, He\n" +
                "Magnetické pole: 5 E-5 T \n" +
                "Mesiace -  27\n");
        if (windowID == 6)
            GUI.TextField(new Rect(2, 20, 296, 250),
                "Stredná vzdialenosť od Slnka: 2869 mil. km \n" +
                "Nejmenšia vzdialenosť od Slnka: 2734 mil.km \n" +
                "Najvetšia vzdialenosť od Slnka: 3003 mil.km \n" +
                "Doba obehu okolo slnka: 84,01 roku \n" +
                "Rýchlosť obehu okolo slnka: 6,80 km/s \n" +
                "Doba otočenia okolo svojej osy: 17,3 h \n" +
                "Priemer planéty: 50 800 km \n" +
                "Hmotnosť: 8,76 E+25 kg\n" +
                "Hustota: 1260 kg/m3\n" +
                "Teplota na povrchu: 55 K\n" +
                "Chemické zloženie atmosféry: H2, He, CH4\n" +
                "Magnetické pole: 5 E-5 T \n" +
                "Mesiace -  15\n");
        if (windowID == 7)
            GUI.TextField(new Rect(2, 20, 296, 250),
                "Stredná vzdialenosť od Slnka: 4496  mil. km \n" +
                "Nejmenšia vzdialenosť od Slnka: 4456 mil.km \n" +
                "Najvetšia vzdialenosť od Slnka: 4537 mil.km \n" +
                "Doba obehu okolo slnka: 164,79 roku \n" +
                "Rýchlosť obehu okolo slnka: 5,43 km/s \n" +
                "Doba otočenia okolo svojej osy: 17 h 50 m \n" +
                "Priemer planéty: 48 600 km \n" +
                "Hmotnosť: 1,03 E+26 kg\n" +
                "Hustota: 1670 kg/m3\n" +
                "Teplota na povrchu: 50 K\n" +
                "Chemické zloženie atmosféry: H2, He, CH4\n" +
                "Magnetické pole: ?" +
                "Mesiace -  2\n");
        if (windowID == 8)
            GUI.TextField(new Rect(2, 20, 296, 250),
                "Stredná vzdialenosť od Slnka: 5900  mil. km \n" +
                "Nejmenšia vzdialenosť od Slnka: 4425 mil.km \n" +
                "Najvetšia vzdialenosť od Slnka: 7375 mil.km \n" +
                "Doba obehu okolo slnka: 248, 43 roku \n" +
                "Rýchlosť obehu okolo slnka: 4,74 km/s \n" +
                "Doba otočenia okolo svojej osy: 6,387 dne \n" +
                "Priemer planéty: 2200 km \n" +
                "Hmotnosť: 1,4 E+22 kg\n" +
                "Hustota: 2000 kg/m3\n" +
                "Teplota na povrchu: 40 K\n" +
                "Chemické zloženie atmosféry: CH4\n" +
                "Magnetické pole: ?" +
                "Mesiace -  1\n");

    }

    void OnMouseDown()
    {
        target = this.gameObject;
        nazov = target.name;
}

    }