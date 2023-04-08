using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNC_Terminál
{
    public partial class Form1 : Form
    {
        //aktualizace velikosti
        Size vychozivelikost;
        //
        // button
        Size velikost_button_pripojit;
        Point pozice_button_pripojit;
        Size velikost_button_odpojit;
        Point pozice_button_odpojit;
        Size velikost_button_nacistgkod;
        Point pozice_button_nacistgkod;
        Size velikost_button_spustitprogram;
        Point pozice_button_spustitprogram;
        Size velikost_button_pozastavit;
        Point pozice_button_pozastavit;
        Size velikost_button_zrusit;
        Point pozice_button_zrusit;
        Size velikost_button_nastavitvirtualnipolohu;
        Point pozice_button_nastavitvirtualnipolohu;
        Size velikost_button_nastavitnulovoupolohu;
        Point pozice_button_nastavitnulovoupolohu;
        Size velikost_button_homing;
        Point pozice_button_homing;
        Size velikost_button_nahoru1;
        Point pozice_button_nahoru1;
        Size velikost_button_nahoru10;
        Point pozice_button_nahoru10;
        Size velikost_button_nahoru100;
        Point pozice_button_nahoru100;
        Size velikost_button_dolu1;
        Point pozice_button_dolu1;
        Size velikost_button_dolu10;
        Point pozice_button_dolu10;
        Size velikost_button_dolu100;
        Point pozice_button_dolu100;
        Size velikost_button_doleva1;
        Point pozice_button_doleva1;
        Size velikost_button_doleva10;
        Point pozice_button_doleva10;
        Size velikost_button_doleva100;
        Point pozice_button_doleva100;
        Size velikost_button_doprava1;
        Point pozice_button_doprava1;
        Size velikost_button_doprava10;
        Point pozice_button_doprava10;
        Size velikost_button_doprava100;
        Point pozice_button_doprava100;
        Size velikost_button_znahoru01;
        Point pozice_button_znahoru01;
        Size velikost_button_znahoru1;
        Point pozice_button_znahoru1;
        Size velikost_button_znahoru10;
        Point pozice_button_znahoru10;
        Size velikost_button_zdolu01;
        Point pozice_button_zdolu01;
        Size velikost_button_zdolu1;
        Point pozice_button_zdolu1;
        Size velikost_button_zdolu10;
        Point pozice_button_zdolu10;
        //
        // groupbox
        Size velikost_groupbox_ventilator;
        Point pozice_groupbox_ventilator;
        Size velikost_groupbox_akcelerace;
        Point pozice_groupbox_akcelerace;
        Size velikost_groupbox_realnapoloha;
        Point pozice_groupbox_realnapoloha;
        Size velikost_groupbox_virtualnipoloha;
        Point pozice_groupbox_virtualnipoloha;
        Size velikost_groupbox_rychlosti;
        Point pozice_groupbox_rychlosti;
        Size velikost_groupbox_motory;
        Point pozice_groupbox_motory;
        Size velikost_groupbox_nastvirtpoloh;
        Point pozice_groupbox_nastvirtpoloh;
        Size velikost_groupbox_gkod;
        Point pozice_groupbox_gkod;
        //
        // label
        Size velikost_label_virtualnix;
        Point pozice_label_virtualnix;
        Size velikost_label_virtualniy;
        Point pozice_label_virtualniy;
        Size velikost_label_virtualniz;
        Point pozice_label_virtualniz;
        Size velikost_label_realnax;
        Point pozice_label_realnax;
        Size velikost_label_realnay;
        Point pozice_label_realnay;
        Size velikost_label_realnaz;
        Point pozice_label_realnaz;
        Size velikost_label8;
        Point pozice_label8;
        Size velikost_label9;
        Point pozice_label9;
        Size velikost_label10;
        Point pozice_label10;
        Size velikost_label1;
        Point pozice_label1;
        Size velikost_label4;
        Point pozice_label4;
        Size velikost_label5;
        Point pozice_label5;
        Size velikost_label6;
        Point pozice_label6;
        Size velikost_label7;
        Point pozice_label7;
        Size velikost_label_nazevsouboru;
        Point pozice_label_nazevsouboru;
        Size velikost_label_pocetradku;
        Point pozice_label_pocetradku;
        Size velikost_label_stav;
        Point pozice_label_stav;
        //
        // combobox
        Size velikost_combobox_porty;
        Point pozice_combobox_porty;
        //
        // textbox
        Size velikost_textbox_ventval;
        Point pozice_textbox_ventval;
        Size velikost_textbox_rychlostxy;
        Point pozice_textbox_rychlostxy;
        Size velikost_textbox_rychlostz;
        Point pozice_textbox_rychlostz;
        Size velikost_textbox_virtx;
        Point pozice_textbox_virtx;
        Size velikost_textbox_virty;
        Point pozice_textbox_virty;
        Size velikost_textbox_virtz;
        Point pozice_textbox_virtz;
        Size velikost_textbox_feedback;
        Point pozice_textbox_feedback;
        //
        // radiobutton
        Size velikost_radiobutton_akczapnuto;
        Point pozice_radiobutton_akczapnuto;
        Size velikost_radiobutton_akcvypnuto;
        Point pozice_radiobutton_akcvypnuto;
        Size velikost_radiobutton_ventauto;
        Point pozice_radiobutton_ventauto;
        Size velikost_radiobutton_ventmanual;
        Point pozice_radiobutton_ventmanual;
        Size velikost_radiobutton_ponechatgkod;
        Point pozice_radiobutton_ponechatgkod;
        Size velikost_radiobutton_potlacitgkod;
        Point pozice_radiobutton_potlacitgkod;
        Size velikost_radiobutton_motzap;
        Point pozice_radiobutton_motzap;
        Size velikost_radiobutton_motvyp;
        Point pozice_radiobutton_motvyp;
        //
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vychozivelikost = this.Size;
            //
            // button
            velikost_button_pripojit = button_pripojit.Size;
            pozice_button_pripojit = button_pripojit.Location;
            velikost_button_odpojit = button_odpojit.Size;
            pozice_button_odpojit = button_odpojit.Location;
            velikost_button_nacistgkod = button_nacistgkod.Size;
            pozice_button_nacistgkod = button_nacistgkod.Location;
            velikost_button_spustitprogram = button_spustitprogram.Size;
            pozice_button_spustitprogram = button_spustitprogram.Location;
            velikost_button_pozastavit = button_pozastavit.Size;
            pozice_button_pozastavit = button_pozastavit.Location;
            velikost_button_zrusit = button_zrusit.Size;
            pozice_button_zrusit = button_zrusit.Location;
            velikost_button_nastavitnulovoupolohu = button_nastavitnulovoupolohu.Size;
            pozice_button_nastavitnulovoupolohu = button_nastavitnulovoupolohu.Location;
            velikost_button_nastavitvirtualnipolohu = button_nastavitvirtualnipolohu.Size;
            pozice_button_nastavitvirtualnipolohu = button_nastavitvirtualnipolohu.Location;
            velikost_button_homing = button_homing.Size;
            pozice_button_homing = button_homing.Location;
            velikost_button_nahoru1 = button_nahoru1.Size;
            pozice_button_nahoru1 = button_nahoru1.Location;
            velikost_button_nahoru10 = button_nahoru10.Size;
            pozice_button_nahoru10 = button_nahoru10.Location;
            velikost_button_nahoru100 = button_nahoru100.Size;
            pozice_button_nahoru100 = button_nahoru100.Location;
            velikost_button_dolu1 = button_dolu1.Size;
            pozice_button_dolu1 = button_dolu1.Location;
            velikost_button_dolu10 = button_dolu10.Size;
            pozice_button_dolu10 = button_dolu10.Location;
            velikost_button_dolu100 = button_dolu100.Size;
            pozice_button_dolu100 = button_dolu100.Location;
            velikost_button_doleva1 = button_doleva1.Size;
            pozice_button_doleva1 = button_doleva1.Location;
            velikost_button_doleva10 = button_doleva10.Size;
            pozice_button_doleva10 = button_doleva10.Location;
            velikost_button_doleva100 = button_doleva100.Size;
            pozice_button_doleva100 = button_doleva100.Location;
            velikost_button_doprava1 = button_doprava1.Size;
            pozice_button_doprava1 = button_doprava1.Location;
            velikost_button_doprava10 = button_doprava10.Size;
            pozice_button_doprava10 = button_doprava10.Location;
            velikost_button_doprava100 = button_doprava100.Size;
            pozice_button_doprava100 = button_doprava100.Location;
            velikost_button_znahoru01 = button_znahoru01.Size;
            pozice_button_znahoru01 = button_znahoru01.Location;
            velikost_button_znahoru1 = button_znahoru1.Size;
            pozice_button_znahoru1 = button_znahoru1.Location;
            velikost_button_znahoru10 = button_znahoru10.Size;
            pozice_button_znahoru10 = button_znahoru10.Location;
            velikost_button_zdolu01 = button_zdolu01.Size;
            pozice_button_zdolu01 = button_zdolu01.Location;
            velikost_button_zdolu1 = button_zdolu1.Size;
            pozice_button_zdolu1 = button_zdolu1.Location;
            velikost_button_zdolu10 = button_zdolu10.Size;
            pozice_button_zdolu10 = button_zdolu10.Location;
            //
            // groupbox
            velikost_groupbox_ventilator = groupBox_ventilator.Size;
            pozice_groupbox_ventilator = groupBox_ventilator.Location;
            velikost_groupbox_akcelerace = groupBox_akcelerace.Size;
            pozice_groupbox_akcelerace = groupBox_akcelerace.Location;
            velikost_groupbox_realnapoloha = groupBox_realnapoloha.Size;
            pozice_groupbox_realnapoloha = groupBox_realnapoloha.Location;
            velikost_groupbox_virtualnipoloha = groupBox_virtualnipoloha.Size;
            pozice_groupbox_virtualnipoloha = groupBox_virtualnipoloha.Location;
            velikost_groupbox_rychlosti = groupBox_rychlosti.Size;
            pozice_groupbox_rychlosti = groupBox_rychlosti.Location;
            velikost_groupbox_motory = groupBox_motory.Size;
            pozice_groupbox_motory = groupBox_motory.Location;
            velikost_groupbox_nastvirtpoloh = groupBox_nastvirtpoloh.Size;
            pozice_groupbox_nastvirtpoloh = groupBox_nastvirtpoloh.Location;
            velikost_groupbox_gkod = groupBox_gkod.Size;
            pozice_groupbox_gkod = groupBox_gkod.Location;
            //
            // label
            velikost_label_virtualnix = label_virtualnix.Size;
            pozice_label_virtualnix = label_virtualnix.Location;
            velikost_label_virtualniy = label_virtualniy.Size;
            pozice_label_virtualniy = label_virtualniy.Location;
            velikost_label_virtualniz = label_virtualniz.Size;
            pozice_label_virtualniz = label_virtualniz.Location;
            velikost_label_realnax = label_realnax.Size;
            pozice_label_realnax = label_realnax.Location;
            velikost_label_realnay = label_realnay.Size;
            pozice_label_realnay = label_realnay.Location;
            velikost_label_realnaz = label_realnaz.Size;
            pozice_label_realnaz = label_realnaz.Location;
            velikost_label8 = label8.Size;
            pozice_label8 = label8.Location;
            velikost_label9 = label9.Size;
            pozice_label9 = label9.Location;
            velikost_label10 = label10.Size;
            pozice_label10 = label10.Location;
            velikost_label1 = label1.Size;
            pozice_label1 = label1.Location;
            velikost_label4 = label4.Size;
            pozice_label4 = label4.Location;
            velikost_label5 = label5.Size;
            pozice_label5 = label5.Location;
            velikost_label6 = label6.Size;
            pozice_label6 = label6.Location;
            velikost_label7 = label7.Size;
            pozice_label7 = label7.Location;
            velikost_label_nazevsouboru = label_nazevsouboru.Size;
            pozice_label_nazevsouboru = label_nazevsouboru.Location;
            velikost_label_pocetradku = label_pocetradku.Size;
            pozice_label_pocetradku = label_pocetradku.Location;
            velikost_label_stav = label_stav.Size;
            pozice_label_stav = label_stav.Location;
            //
            // combobox
            velikost_combobox_porty = comboBox_porty.Size;
            pozice_combobox_porty = comboBox_porty.Location;
            //
            // textbox
            velikost_textbox_ventval = textBox_ventval.Size;
            pozice_textbox_ventval = textBox_ventval.Location;
            velikost_textbox_rychlostxy = textBox_rychlostxy.Size;
            pozice_textbox_rychlostxy = textBox_rychlostxy.Location;
            velikost_textbox_rychlostz = textBox_rychlostz.Size;
            pozice_textbox_rychlostz = textBox_rychlostz.Location;
            velikost_textbox_virtx = textBox_virtx.Size;
            pozice_textbox_virtx = textBox_virtx.Location;
            velikost_textbox_virty = textBox_virty.Size;
            pozice_textbox_virty = textBox_virty.Location;
            velikost_textbox_virtz = textBox_virtz.Size;
            pozice_textbox_virtz = textBox_virtz.Location;
            velikost_textbox_feedback = textBox_feedback.Size;
            pozice_textbox_feedback = textBox_feedback.Location;
            //
            // radiobutton
            velikost_radiobutton_akczapnuto = radioButton_akczapnuto.Size;
            pozice_radiobutton_akczapnuto = radioButton_akczapnuto.Location;
            velikost_radiobutton_akcvypnuto = radioButton_akcvypnuto.Size;
            pozice_radiobutton_akcvypnuto = radioButton_akcvypnuto.Location;
            velikost_radiobutton_ventauto = radioButton_ventauto.Size;
            pozice_radiobutton_ventauto = radioButton_ventauto.Location;
            velikost_radiobutton_ventmanual = radioButton_ventmanual.Size;
            pozice_radiobutton_ventmanual = radioButton_ventmanual.Location;
            velikost_radiobutton_ponechatgkod = radioButton_ponechatgkod.Size;
            pozice_radiobutton_ponechatgkod = radioButton_ponechatgkod.Location;
            velikost_radiobutton_potlacitgkod = radioButton_potlacitgkod.Size;
            pozice_radiobutton_potlacitgkod = radioButton_potlacitgkod.Location;
            velikost_radiobutton_motzap = radioButton_motzap.Size;
            pozice_radiobutton_motzap = radioButton_motzap.Location;
            velikost_radiobutton_motvyp = radioButton_motvyp.Size;
            pozice_radiobutton_motvyp = radioButton_motvyp.Location;
        }

        private void groupBox_virtualnipoloha_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Point pozice = new Point();
            Size velikost = new Size();
            float nasobicx, nasobicy;
            nasobicx = (float)this.Size.Width / (float)vychozivelikost.Width;
            nasobicy = (float)this.Size.Height / (float)vychozivelikost.Height;
            //
            // button
            pozice = pozice_button_pripojit;
            velikost = velikost_button_pripojit;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            button_pripojit.Location = pozice;
            button_pripojit.Size = velikost;
            //
            pozice = pozice_button_odpojit;
            velikost = velikost_button_odpojit;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            button_odpojit.Location = pozice;
            button_odpojit.Size = velikost;
            //
            pozice = pozice_button_nacistgkod;
            velikost = velikost_button_nacistgkod;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            button_nacistgkod.Location = pozice;
            button_nacistgkod.Size = velikost;
            //
            pozice = pozice_button_spustitprogram;
            velikost = velikost_button_spustitprogram;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            button_spustitprogram.Location = pozice;
            button_spustitprogram.Size = velikost;
            //
            pozice = pozice_button_pozastavit;
            velikost = velikost_button_pozastavit;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            button_pozastavit.Location = pozice;
            button_pozastavit.Size = velikost;
            //
            pozice = pozice_button_zrusit;
            velikost = velikost_button_zrusit;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            button_zrusit.Location = pozice;
            button_zrusit.Size = velikost;
            //
            pozice = pozice_button_nastavitnulovoupolohu;
            velikost = velikost_button_nastavitnulovoupolohu;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            button_nastavitnulovoupolohu.Location = pozice;
            button_nastavitnulovoupolohu.Size = velikost;
            //
            pozice = pozice_button_nastavitvirtualnipolohu;
            velikost = velikost_button_nastavitvirtualnipolohu;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            button_nastavitvirtualnipolohu.Location = pozice;
            button_nastavitvirtualnipolohu.Size = velikost;
            //
            pozice = pozice_button_homing;
            velikost = velikost_button_homing;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            button_homing.Location = pozice;
            button_homing.Size = velikost;
            //
            pozice = pozice_button_nahoru1;
            velikost = velikost_button_nahoru1;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            button_nahoru1.Location = pozice;
            button_nahoru1.Size = velikost;
            //
            pozice = pozice_button_nahoru10;
            velikost = velikost_button_nahoru10;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            button_nahoru10.Location = pozice;
            button_nahoru10.Size = velikost;
            //
            pozice = pozice_button_nahoru100;
            velikost = velikost_button_nahoru100;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            button_nahoru100.Location = pozice;
            button_nahoru100.Size = velikost;
            //
            pozice = pozice_button_dolu1;
            velikost = velikost_button_dolu1;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            button_dolu1.Location = pozice;
            button_dolu1.Size = velikost;
            //
            pozice = pozice_button_dolu10;
            velikost = velikost_button_dolu10;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            button_dolu10.Location = pozice;
            button_dolu10.Size = velikost;
            //
            pozice = pozice_button_dolu100;
            velikost = velikost_button_dolu100;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            button_dolu100.Location = pozice;
            button_dolu100.Size = velikost;
            //
            pozice = pozice_button_doleva1;
            velikost = velikost_button_doleva1;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            button_doleva1.Location = pozice;
            button_doleva1.Size = velikost;
            //
            pozice = pozice_button_doleva10;
            velikost = velikost_button_doleva10;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            button_doleva10.Location = pozice;
            button_doleva10.Size = velikost;
            //
            pozice = pozice_button_doleva100;
            velikost = velikost_button_doleva100;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            button_doleva100.Location = pozice;
            button_doleva100.Size = velikost;
            //
            pozice = pozice_button_doprava1;
            velikost = velikost_button_doprava1;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            button_doprava1.Location = pozice;
            button_doprava1.Size = velikost;
            //
            pozice = pozice_button_doprava10;
            velikost = velikost_button_doprava10;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            button_doprava10.Location = pozice;
            button_doprava10.Size = velikost;
            //
            pozice = pozice_button_doprava100;
            velikost = velikost_button_doprava100;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            button_doprava100.Location = pozice;
            button_doprava100.Size = velikost;
            //
            pozice = pozice_button_znahoru01;
            velikost = velikost_button_znahoru01;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            button_znahoru01.Location = pozice;
            button_znahoru01.Size = velikost;
            //
            pozice = pozice_button_znahoru1;
            velikost = velikost_button_znahoru1;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            button_znahoru1.Location = pozice;
            button_znahoru1.Size = velikost;
            //
            pozice = pozice_button_znahoru10;
            velikost = velikost_button_znahoru10;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            button_znahoru10.Location = pozice;
            button_znahoru10.Size = velikost;
            //
            pozice = pozice_button_zdolu01;
            velikost = velikost_button_zdolu01;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            button_zdolu01.Location = pozice;
            button_zdolu01.Size = velikost;
            //
            pozice = pozice_button_zdolu1;
            velikost = velikost_button_zdolu1;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            button_zdolu1.Location = pozice;
            button_zdolu1.Size = velikost;
            //
            pozice = pozice_button_zdolu10;
            velikost = velikost_button_zdolu10;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            button_zdolu10.Location = pozice;
            button_zdolu10.Size = velikost;
            //
            // groupbox
            pozice = pozice_groupbox_ventilator;
            velikost = velikost_groupbox_ventilator;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            groupBox_ventilator.Location = pozice;
            groupBox_ventilator.Size = velikost;
            //
            pozice = pozice_groupbox_akcelerace;
            velikost = velikost_groupbox_akcelerace;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            groupBox_akcelerace.Location = pozice;
            groupBox_akcelerace.Size = velikost;
            //
            pozice = pozice_groupbox_realnapoloha;
            velikost = velikost_groupbox_realnapoloha;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            groupBox_realnapoloha.Location = pozice;
            groupBox_realnapoloha.Size = velikost;
            //
            pozice = pozice_groupbox_virtualnipoloha;
            velikost = velikost_groupbox_virtualnipoloha;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            groupBox_virtualnipoloha.Location = pozice;
            groupBox_virtualnipoloha.Size = velikost;
            //
            pozice = pozice_groupbox_rychlosti;
            velikost = velikost_groupbox_rychlosti;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            groupBox_rychlosti.Location = pozice;
            groupBox_rychlosti.Size = velikost;
            //
            pozice = pozice_groupbox_motory;
            velikost = velikost_groupbox_motory;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            groupBox_motory.Location = pozice;
            groupBox_motory.Size = velikost;
            //
            pozice = pozice_groupbox_nastvirtpoloh;
            velikost = velikost_groupbox_nastvirtpoloh;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            groupBox_nastvirtpoloh.Location = pozice;
            groupBox_nastvirtpoloh.Size = velikost;
            //
            pozice = pozice_groupbox_gkod;
            velikost = velikost_groupbox_gkod;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            groupBox_gkod.Location = pozice;
            groupBox_gkod.Size = velikost;
            //
            // label
            pozice = pozice_label_virtualnix;
            velikost = velikost_label_virtualnix;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            label_virtualnix.Location = pozice;
            label_virtualnix.Size = velikost;
            //
            pozice = pozice_label_virtualniy;
            velikost = velikost_label_virtualniy;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            label_virtualniy.Location = pozice;
            label_virtualniy.Size = velikost;
            //
            pozice = pozice_label_virtualniz;
            velikost = velikost_label_virtualniz;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            label_virtualniz.Location = pozice;
            label_virtualniz.Size = velikost;
            //
            pozice = pozice_label_realnax;
            velikost = velikost_label_realnax;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            label_realnax.Location = pozice;
            label_realnax.Size = velikost;
            //
            pozice = pozice_label_realnay;
            velikost = velikost_label_realnay;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            label_realnay.Location = pozice;
            label_realnay.Size = velikost;
            //
            pozice = pozice_label_realnaz;
            velikost = velikost_label_realnaz;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            label_realnaz.Location = pozice;
            label_realnaz.Size = velikost;
            //
            pozice = pozice_label8;
            velikost = velikost_label8;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            label8.Location = pozice;
            label8.Size = velikost;
            //
            pozice = pozice_label9;
            velikost = velikost_label9;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            label9.Location = pozice;
            label9.Size = velikost;
            //
            pozice = pozice_label10;
            velikost = velikost_label10;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            label10.Location = pozice;
            label10.Size = velikost;
            //
            pozice = pozice_label1;
            velikost = velikost_label1;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            label1.Location = pozice;
            label1.Size = velikost;
            //
            pozice = pozice_label4;
            velikost = velikost_label4;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            label4.Location = pozice;
            label4.Size = velikost;
            //
            pozice = pozice_label5;
            velikost = velikost_label5;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            label5.Location = pozice;
            label5.Size = velikost;
            //
            pozice = pozice_label6;
            velikost = velikost_label6;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            label6.Location = pozice;
            label6.Size = velikost;
            //
            pozice = pozice_label7;
            velikost = velikost_label7;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            label7.Location = pozice;
            label7.Size = velikost;
            //
            pozice = pozice_label_nazevsouboru;
            velikost = velikost_label_nazevsouboru;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            label_nazevsouboru.Location = pozice;
            label_nazevsouboru.Size = velikost;
            //
            pozice = pozice_label_pocetradku;
            velikost = velikost_label_pocetradku;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            label_pocetradku.Location = pozice;
            label_pocetradku.Size = velikost;
            //
            pozice = pozice_label_stav;
            velikost = velikost_label_stav;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            label_stav.Location = pozice;
            label_stav.Size = velikost;
            //
            // combobox
            pozice = pozice_combobox_porty;
            velikost = velikost_combobox_porty;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            comboBox_porty.Location = pozice;
            comboBox_porty.Size = velikost;
            //
            // textbox
            pozice = pozice_textbox_ventval;
            velikost = velikost_textbox_ventval;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            textBox_ventval.Location = pozice;
            textBox_ventval.Size = velikost;
            //
            pozice = pozice_textbox_rychlostxy;
            velikost = velikost_textbox_rychlostxy;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            textBox_rychlostxy.Location = pozice;
            textBox_rychlostxy.Size = velikost;
            //
            pozice = pozice_textbox_rychlostz;
            velikost = velikost_textbox_rychlostz;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            textBox_rychlostz.Location = pozice;
            textBox_rychlostz.Size = velikost;
            //
            pozice = pozice_textbox_virtx;
            velikost = velikost_textbox_virtx;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            textBox_virtx.Location = pozice;
            textBox_virtx.Size = velikost;
            //
            pozice = pozice_textbox_virty;
            velikost = velikost_textbox_virty;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            textBox_virty.Location = pozice;
            textBox_virty.Size = velikost;
            //
            pozice = pozice_textbox_virtz;
            velikost = velikost_textbox_virtz;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            textBox_virtz.Location = pozice;
            textBox_virtz.Size = velikost;
            //
            pozice = pozice_textbox_feedback;
            velikost = velikost_textbox_feedback;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            textBox_feedback.Location = pozice;
            textBox_feedback.Size = velikost;
            //
            // radiobutton
            pozice = pozice_radiobutton_akczapnuto;
            velikost = velikost_radiobutton_akczapnuto;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            radioButton_akczapnuto.Location = pozice;
            radioButton_akczapnuto.Size = velikost;
            //
            pozice = pozice_radiobutton_akcvypnuto;
            velikost = velikost_radiobutton_akcvypnuto;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            radioButton_akcvypnuto.Location = pozice;
            radioButton_akcvypnuto.Size = velikost;
            //
            pozice = pozice_radiobutton_ventauto;
            velikost = velikost_radiobutton_ventauto;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            radioButton_ventauto.Location = pozice;
            radioButton_ventauto.Size = velikost;
            //
            pozice = pozice_radiobutton_ventmanual;
            velikost = velikost_radiobutton_ventmanual;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            radioButton_ventmanual.Location = pozice;
            radioButton_ventmanual.Size = velikost;
            //
            pozice = pozice_radiobutton_ponechatgkod;
            velikost = velikost_radiobutton_ponechatgkod;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            radioButton_ponechatgkod.Location = pozice;
            radioButton_ponechatgkod.Size = velikost;
            //
            pozice = pozice_radiobutton_potlacitgkod;
            velikost = velikost_radiobutton_potlacitgkod;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            radioButton_potlacitgkod.Location = pozice;
            radioButton_potlacitgkod.Size = velikost;
            //
            pozice = pozice_radiobutton_motzap;
            velikost = velikost_radiobutton_motzap;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            radioButton_motzap.Location = pozice;
            radioButton_motzap.Size = velikost;
            //
            pozice = pozice_radiobutton_motvyp;
            velikost = velikost_radiobutton_motvyp;
            pozice.X = (int)((float)pozice.X * nasobicx);
            pozice.Y = (int)((float)pozice.Y * nasobicy);
            velikost.Width = (int)((float)velikost.Width * nasobicx);
            velikost.Height = (int)((float)velikost.Height * nasobicy);
            radioButton_motvyp.Location = pozice;
            radioButton_motvyp.Size = velikost;
        }
    }
}
