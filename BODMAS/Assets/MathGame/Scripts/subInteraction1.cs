using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubInteraction : MonoBehaviour
{
    int b1; int b2; int b3; int b4;int b5;int b6;int b7;int b8;int b9;int b10;int b11;int b12; int b13; int b14;
    int b15; int b16; int b17; int b18; int b19; int b20; int b21; int b22; int b23; int b24; int b25; int b26;
    int b27; int b28; int b29; int b30; int b31; int b32; int b33; int b34; int b35; int b36; int b37; int b38;
    int b39; int b40; int b41; int b42; int b43; int b44; int b45; int b46; int b47; int b48; int b49; int b50;
    public Button[] level;
    private void OnEnable()
    {
        b1 = PlayerPrefs.GetInt("MS1", b1);
        b2 = PlayerPrefs.GetInt("MS2", b2);
        b3 = PlayerPrefs.GetInt("MS3", b3);
        b4 = PlayerPrefs.GetInt("MS4", b4);
        b5 = PlayerPrefs.GetInt("MS5", b5);
        b6 = PlayerPrefs.GetInt("MS6", b6);
        b7 = PlayerPrefs.GetInt("MS7", b7);
        b8 = PlayerPrefs.GetInt("MS8", b8);
        b9 = PlayerPrefs.GetInt("MS9", b9);
        b10 = PlayerPrefs.GetInt("MS10", b10);
        b11 = PlayerPrefs.GetInt("MS11", b11);
        b12 = PlayerPrefs.GetInt("MS12", b12);
        b13 = PlayerPrefs.GetInt("MS13", b13);
        b14 = PlayerPrefs.GetInt("MS14", b14);
        b15 = PlayerPrefs.GetInt("MS15", b15);
        b16 = PlayerPrefs.GetInt("MS16", b16);
        b17 = PlayerPrefs.GetInt("MS17", b17);
        b18 = PlayerPrefs.GetInt("MS18", b18);
        b19 = PlayerPrefs.GetInt("MS19", b19);
        b20 = PlayerPrefs.GetInt("MS20", b20);
        b21 = PlayerPrefs.GetInt("MS21", b21);
        b22 = PlayerPrefs.GetInt("MS22", b22);
        b23 = PlayerPrefs.GetInt("MS23", b23);
        b24 = PlayerPrefs.GetInt("MS24", b24);
        b25 = PlayerPrefs.GetInt("MS25", b25);
        b26 = PlayerPrefs.GetInt("MS26", b26);
        b27 = PlayerPrefs.GetInt("MS27", b27);
        b28 = PlayerPrefs.GetInt("MS28", b28);
        b29 = PlayerPrefs.GetInt("MS29", b29);
        b30 = PlayerPrefs.GetInt("MS30", b30);
        b31 = PlayerPrefs.GetInt("MS31", b31);
        b32 = PlayerPrefs.GetInt("MS32", b32);
        b33 = PlayerPrefs.GetInt("MS33", b33);
        b34 = PlayerPrefs.GetInt("MS34", b34);
        b35 = PlayerPrefs.GetInt("MS35", b35);
        b36 = PlayerPrefs.GetInt("MS36", b36);
        b37 = PlayerPrefs.GetInt("MS37", b37);
        b38 = PlayerPrefs.GetInt("MS38", b38);
        b39 = PlayerPrefs.GetInt("MS39", b39);
        b40 = PlayerPrefs.GetInt("MS40", b40);
        b41 = PlayerPrefs.GetInt("MS41", b41);
        b42 = PlayerPrefs.GetInt("MS42", b42);
        b43 = PlayerPrefs.GetInt("MS43", b43);
        b44 = PlayerPrefs.GetInt("MS44", b44);
        b45 = PlayerPrefs.GetInt("MS45", b45);
        b46 = PlayerPrefs.GetInt("MS46", b46);
        b47 = PlayerPrefs.GetInt("MS47", b47);
        b48 = PlayerPrefs.GetInt("MS48", b48);
        b49 = PlayerPrefs.GetInt("MS49", b49);
        b50 = PlayerPrefs.GetInt("MS50", b50);
        if (b1 > 0)
        {
            level[2].interactable = true;
        }

        if (b2 > 0)
        {
            level[3].interactable = true;
        }
        if (b3 > 0)
        {
            level[4].interactable = true;
        }
        if (b4 > 0)
        {
            level[5].interactable = true;
        }
        if (b5 > 0)
        {
            level[6].interactable = true;
        }
        if (b6 > 0)
        {
            level[7].interactable = true;
        }
        if (b7 > 0)
        {
            level[8].interactable = true;
        }
        if (b8 > 0)
        {
            level[9].interactable = true;
        }
        if (b9 > 0)
        {
            level[10].interactable = true;
        }
        if (b10 > 0)
        {
            level[11].interactable = true;
        }
        if (b11 > 0)
        {
            level[12].interactable = true;
        }
        if (b12 > 0)
        {
            level[13].interactable = true;
        }
        if (b13 > 0)
        {
            level[14].interactable = true;
        }
        if (b14 > 0)
        {
            level[15].interactable = true;
        }
        if (b15 > 0)
        {
            level[16].interactable = true;
        }
        if (b16 > 0)
        {
            level[17].interactable = true;
        }
        if (b17 > 0)
        {
            level[18].interactable = true;
        }
        if (b18 > 0)
        {
            level[19].interactable = true;
        }
        if (b19 > 0)
        {
            level[20].interactable = true;
        }
        if (b20 > 0)
        {
            level[21].interactable = true;
        }
        if (b21 > 0)
        {
            level[22].interactable = true;
        }
        if (b22 > 0)
        {
            level[23].interactable = true;
        }
        if (b23 > 0)
        {
            level[24].interactable = true;
        }
        if (b24 > 0)
        {
            level[25].interactable = true;
        }
        if (b25 > 0)
        {
            level[26].interactable = true;
        }
        if (b26 > 0)
        {
            level[27].interactable = true;
        }
        if (b27 > 0)
        {
            level[28].interactable = true;
        }
        if (b28 > 0)
        {
            level[29].interactable = true;
        }
        if (b29 > 0)
        {
            level[30].interactable = true;
        }
        if (b30 > 0)
        {
            level[31].interactable = true;
        }
        if (b31 > 0)
        {
            level[32].interactable = true;
        }
        if (b32 > 0)
        {
            level[33].interactable = true;
        }
        if (b33 > 0)
        {
            level[34].interactable = true;
        }
        if (b34 > 0)
        {
            level[35].interactable = true;
        }
        if (b35 > 0)
        {
            level[36].interactable = true;
        }
        if (b36 > 0)
        {
            level[37].interactable = true;
        }
        if (b37 > 0)
        {
            level[38].interactable = true;
        }
        if (b38 > 0)
        {
            level[39].interactable = true;
        }
        if (b39 > 0)
        {
            level[40].interactable = true;
        }
        if (b40 > 0)
        {
            level[41].interactable = true;
        }
        if (b41 > 0)
        {
            level[42].interactable = true;
        }
        if (b42 > 0)
        {
            level[43].interactable = true;
        }
        if (b43 > 0)
        {
            level[44].interactable = true;
        }
        if (b44 > 0)
        {
            level[45].interactable = true;
        }
        if (b45 > 0)
        {
            level[46].interactable = true;
        }
        if (b46 > 0)
        {
            level[47].interactable = true;
        }
        if (b47 > 0)
        {
            level[48].interactable = true;
        }
        if (b48 > 0)
        {
            level[49].interactable = true;
        }
        if (b49 > 0)
        {
            level[50].interactable = true;
        }
       
    }
}
