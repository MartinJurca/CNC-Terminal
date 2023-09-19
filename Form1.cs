using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Windows;
using System.IO;

namespace CNC_Terminál
{
    public partial class Form1 : Form
    {
        #region resize proměnné
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
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Test procesu na pozadí
            CNC cnc_ = new CNC();
            Console.WriteLine("Start testu cyklu na pozadí.");
            while (true)
            {
                Console.WriteLine();
                Console.Write("1, 0, s, r: ");
                string vyber = Console.ReadLine();
                switch (vyber)
                {
                    default: break;
                    case "1":
                        cnc_.StartUpdateThread();
                        break;
                    case "0":
                        cnc_.StopUpdateThread();
                        break;
                    case "s":
                        cnc_.SuspendUpdateThread();
                        break;
                    case "r":
                        cnc_.ResumeUpdateThread();
                        break;
                }
            }
            #endregion
            #region test separace
            Console.WriteLine("Test separace...");
            DataDivider.Divide("lkajd[pagman:1520]slkjfs[xDdd:420]vgbf[neco]");
            int max = DataDivider.available;
            for (int i = 0; i < max; i++)
            {
                string j = "", d = "";
                DataDivider.Read(ref j,ref d);
                Console.WriteLine("[{0}:{1}]", j, d);
            }
            Console.WriteLine("Test odběru z vrchu...");
            Console.ReadKey();
            #endregion
            #region test připojení
            SerialStream stream = new SerialStream();
            String port = "COM19";
            stream.Port.PortName = port;
            Console.WriteLine("připojování...");
            if (stream.Connect()) Console.WriteLine("připojeno");
            else
            {
                Console.WriteLine("nepodařilo se připojit: {0}", stream.connectexception.Message);
                Console.ReadKey();
            }
            CNC cnc = new CNC(stream);
            while (true)
            {
                Console.Write("\nzadej zprávu: ");
                string zpráva = Console.ReadLine();
                stream.WriteLine(zpráva);
                cnc.CncCommunication.WriteLine(zpráva);
                while (stream.available > 0)
                {
                    //Console.Write(stream.Read());
                    Console.Write(cnc.CncCommunication.Read());
                }
                Console.WriteLine("\ndostupná data ze streamu: {0}", stream.available);
                if (!stream.Port.IsOpen) { Console.WriteLine("\nport odpojen"); break; }
            }
            Console.ReadKey();
            #endregion
            #region test čtení souboru
            GCodeFile gcf = new GCodeFile("e:test.txt");
            Console.WriteLine("začátek testu...");
            Console.WriteLine("počet řádků: {0}", gcf.lines.Count);
            Console.WriteLine("obsah:");
            foreach (string line in gcf.lines)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("konec obsahu...");
            Console.ReadKey();
            #endregion
            #region nastavení výchozího stavu
            radioButton_akczapnuto.Checked = true;
            radioButton_ventauto.Checked = true;
            radioButton_ponechatgkod.Checked = true;
            radioButton_motvyp.Checked = true;
            textBox_ventval.Text = "0";
            textBox_rychlostxy.Text = "1.0";
            textBox_rychlostz.Text = "1.0";
            label_virtualnix.Text = "X: 0";
            label_virtualniy.Text = "Y: 0";
            label_virtualniz.Text = "Z: 0";
            label_realnax.Text = "X: 0";
            label_realnay.Text = "Y: 0";
            label_realnaz.Text = "Z: 0";
            Nastav_UI_Nepripojeno();
            Nastav_UI_BezPrace();
            #endregion
            #region výchozí nastavení resize proměnných
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
            #endregion
            #region testování kruhu
            List<byte> neco = new List<byte>
            {
                0b11110000, 0b11110000, 0b11111111, 0b10011101, 0b10011101
            };
            List<byte> vysledek = MotionGenerator.CompressMotion(neco);
            int stuj = 1520;
            gridpoint cnt = new gridpoint() { x = 0, y = 0, z = 0 };
            gridpoint rad = new gridpoint() { x = 0, y = 500, z = 0 };
            gridpoint end = new gridpoint() { x = 0, y = 500, z = 0 };
            List<gridpoint> pagman = MotionGenerator.GetCircleCCW(cnt, rad, end);
            #endregion
            #region generátor pohybu
            List<byte> rawdata = MotionGenerator.EncodeMotion(pagman);
            rawdata = MotionGenerator.CompressMotion(rawdata);
            for (int i = 0; i < rawdata.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write("uint8_t circledata[{0}] = {{0x{1:x},", rawdata.Count, rawdata[0]);
                    continue;
                }
                if (i == (rawdata.Count - 1))
                {
                    Console.Write("0x{0:x}", rawdata[i]);
                    Console.WriteLine("};");
                    break;
                }
                Console.Write("0x{0:x},", rawdata[i]);
            }
            Console.ReadKey();
            #endregion
            #region test hloubky
            foreach (gridpoint p in pagman)
            {
                Console.WriteLine(p.z);
            }
            Console.ReadKey();
            #endregion
            #region rastr
            int[,] rastr = new int[32, 32];
            for (int x = 0; x < 32; x++)
            {
                for (int y = 0; y < 32; y++)
                {
                    rastr[x, y] = 0;
                }
            }
            foreach (gridpoint gp in pagman)
            {
                rastr[gp.x+16, gp.y+16] = 1;
                for (int y_ = 31; y_ > 0; y_--)
                {
                    Console.WriteLine();
                    for (int x_ = 0; x_ < 32; x_++)
                    {
                        Console.Write("{0}", rastr[x_, y_]);
                    }
                }
            }
            Console.ReadKey();
            #endregion
        }
        #region UI
        private void groupBox_virtualnipoloha_Enter(object sender, EventArgs e)
        {
            //
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

        public void Nastav_UI_Nepripojeno()
        {
            groupBox_akcelerace.Enabled = false;
            groupBox_ventilator.Enabled = false;
            groupBox_rychlosti.Enabled = false;
            groupBox_motory.Enabled = false;
            groupBox_nastvirtpoloh.Enabled = false;
            groupBox_gkod.Enabled = false;
            groupBox_virtualnipoloha.Enabled = false;
            groupBox_realnapoloha.Enabled = false;
            button_pripojit.Enabled = true;
            button_odpojit.Enabled = false;
            button_homing.Enabled = false;
            button_nahoru1.Enabled = false;
            button_nahoru10.Enabled = false;
            button_nahoru100.Enabled = false;
            button_dolu1.Enabled = false;
            button_dolu10.Enabled = false;
            button_dolu100.Enabled = false;
            button_doprava1.Enabled = false;
            button_doprava10.Enabled = false;
            button_doprava100.Enabled = false;
            button_doleva1.Enabled = false;
            button_doleva10.Enabled = false;
            button_doleva100.Enabled = false;
            button_znahoru01.Enabled = false;
            button_znahoru1.Enabled = false;
            button_znahoru10.Enabled = false;
            button_zdolu01.Enabled = false;
            button_zdolu1.Enabled = false;
            button_zdolu10.Enabled = false;
        }

        public void Nastav_UI_Pripopjeno()
        {
            groupBox_akcelerace.Enabled = true;
            groupBox_ventilator.Enabled = true;
            groupBox_rychlosti.Enabled = true;
            groupBox_motory.Enabled = true;
            groupBox_nastvirtpoloh.Enabled = true;
            groupBox_gkod.Enabled = true;
            groupBox_virtualnipoloha.Enabled = true;
            groupBox_realnapoloha.Enabled = true;
            button_pripojit.Enabled = false;////////////////
            button_odpojit.Enabled = true;
            button_homing.Enabled = true;
            button_nahoru1.Enabled = true;
            button_nahoru10.Enabled = true;
            button_nahoru100.Enabled = true;
            button_dolu1.Enabled = true;
            button_dolu10.Enabled = true;
            button_dolu100.Enabled = true;
            button_doprava1.Enabled = true;
            button_doprava10.Enabled = true;
            button_doprava100.Enabled = true;
            button_doleva1.Enabled = true;
            button_doleva10.Enabled = true;
            button_doleva100.Enabled = true;
            button_znahoru01.Enabled = true;
            button_znahoru1.Enabled = true;
            button_znahoru10.Enabled = true;
            button_zdolu01.Enabled = true;
            button_zdolu1.Enabled = true;
            button_zdolu10.Enabled = true;
        }

        public void Nastav_UI_PraceSpustena()
        {
            groupBox_akcelerace.Enabled = false;
            groupBox_ventilator.Enabled = false;
            groupBox_rychlosti.Enabled = false;
            groupBox_motory.Enabled = false;
            groupBox_nastvirtpoloh.Enabled = false;
            button_homing.Enabled = false;
            button_nahoru1.Enabled = false;
            button_nahoru10.Enabled = false;
            button_nahoru100.Enabled = false;
            button_dolu1.Enabled = false;
            button_dolu10.Enabled = false;
            button_dolu100.Enabled = false;
            button_doprava1.Enabled = false;
            button_doprava10.Enabled = false;
            button_doprava100.Enabled = false;
            button_doleva1.Enabled = false;
            button_doleva10.Enabled = false;
            button_doleva100.Enabled = false;
            button_znahoru01.Enabled = false;
            button_znahoru1.Enabled = false;
            button_znahoru10.Enabled = false;
            button_zdolu01.Enabled = false;
            button_zdolu1.Enabled = false;
            button_zdolu10.Enabled = false;
            button_nacistgkod.Enabled = false;
            button_spustitprogram.Enabled = false;
            button_pozastavit.Enabled = true;
            button_zrusit.Enabled = true;
        }

        public void Nastav_UI_BezPrace()
        {
            groupBox_akcelerace.Enabled = true;
            groupBox_ventilator.Enabled = true;
            groupBox_rychlosti.Enabled = true;
            groupBox_motory.Enabled = true;
            groupBox_nastvirtpoloh.Enabled = true;
            button_homing.Enabled = true;
            button_nahoru1.Enabled = true;
            button_nahoru10.Enabled = true;
            button_nahoru100.Enabled = true;
            button_dolu1.Enabled = true;
            button_dolu10.Enabled = true;
            button_dolu100.Enabled = true;
            button_doprava1.Enabled = true;
            button_doprava10.Enabled = true;
            button_doprava100.Enabled = true;
            button_doleva1.Enabled = true;
            button_doleva10.Enabled = true;
            button_doleva100.Enabled = true;
            button_znahoru01.Enabled = true;
            button_znahoru1.Enabled = true;
            button_znahoru10.Enabled = true;
            button_zdolu01.Enabled = true;
            button_zdolu1.Enabled = true;
            button_zdolu10.Enabled = true;
            button_nacistgkod.Enabled = true;
            button_spustitprogram.Enabled = false;
            button_pozastavit.Enabled = false;
            button_zrusit.Enabled = false;
        }

        private void button_pripojit_Click(object sender, EventArgs e)
        {
            Nastav_UI_Pripopjeno();
        }

        private void button_odpojit_Click(object sender, EventArgs e)
        {
            Nastav_UI_Nepripojeno();
        }

        private void button_nacistgkod_Click(object sender, EventArgs e)
        {
            Nastav_UI_PraceSpustena();
        }

        private void button_zrusit_Click(object sender, EventArgs e)
        {
            Nastav_UI_BezPrace();
        }
    }
    #endregion
    #region generátor pohybu
    public struct gridpoint
    {
        public enum direction
        {
            nahoru = 0,
            doprava_nahoru,
            doprava,
            doprava_dolů,
            dolů,
            doleva_dolů,
            doleva,
            doleva_nahoru,
            Z_nahoru,
            Z_dolů,
            Z_nahoru_bez_čekání,
            Z_dolů_bez_čekání
        }
        public int x;
        public int y;
        public int z;
        public gridpoint(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void Set(int x, int y, int z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void Clear()
        {
            x = 0;
            y = 0;
            z = 0;
        }
        public bool IsEqual(in gridpoint point)
        {
            bool flag = true;
            if (this.x != point.x) flag = false;
            if (this.y != point.y) flag = false;
            if (this.z != point.z) flag = false;
            return flag;
        }
        public double DistanceTo(in gridpoint point)
        {
            if (this.IsEqual(point)) return 0.0;
            double p1 = (double)point.x - (double)this.x;
            double p2 = (double)point.y - (double)this.y;
            double p3 = (double)point.z - (double)this.z;
            p1 = Math.Pow(Math.Abs(p1), 2);
            p2 = Math.Pow(Math.Abs(p2), 2);
            p3 = Math.Pow(Math.Abs(p3), 2);
            return Math.Sqrt(p1 + p2 + p3);
        }
        public double HorizontalDistanceTo(in gridpoint point)
        {
            if (this.IsEqual(point)) return 0.0;
            double p1 = (double)point.x - (double)this.x;
            double p2 = (double)point.y - (double)this.y;
            p1 = Math.Pow(Math.Abs(p1), 2);
            p2 = Math.Pow(Math.Abs(p2), 2);
            return Math.Sqrt(p1 + p2);
        }
        public double VerticalDistanceTo(in gridpoint point)
        {
            if (this.IsEqual(point)) return 0.0;
            return (double)(point.z - z);
        }
        public int DirectingTo(in gridpoint point)
        {
            int result = 0;
            if (this.z > point.z) result += 100; // Z-dolů
            else if (this.z < point.z) result += 200; // Z-nahoru
            if (this.x > point.x) // doleva
            {
                if (this.y > point.y) //doleva dolů
                {
                    result += (int)direction.doleva_dolů;
                    goto next;
                }
                if (this.y < point.y) //doleva nahoru
                {
                    result += (int)direction.doleva_nahoru;
                    goto next;
                }
            }
            if (this.x < point.x) // doprava
            {
                if (this.y > point.y) //doprava dolů
                {
                    result += (int)direction.doprava_dolů;
                    goto next;
                }
                if (this.y < point.y) //doprava nahoru
                {
                    result += (int)direction.doprava_nahoru;
                    goto next;
                }
            }
            if (this.x == point.x)
            {
                if (this.y > point.y) // dolů
                {
                    result += (int)direction.dolů;
                    goto next;
                }
                if (this.y < point.y) // nahoru
                {
                    result += (int)direction.nahoru;
                    goto next;
                }
            }
            if (this.y == point.y)
            {
                if (this.x > point.x) // doleva
                {
                    result += (int)direction.doleva;
                    goto next;
                }
                if (this.x < point.x) // doprava
                {
                    result += (int)direction.doprava;
                    goto next;
                }
            }
        next:
            return result;
        }
    }
    public static class MotionGenerator
    {
        public enum direction
        {
            nahoru = 0,
            doprava_nahoru,
            doprava,
            doprava_dolů,
            dolů,
            doleva_dolů,
            doleva,
            doleva_nahoru,
            Z_nahoru,
            Z_dolů,
            Z_nahoru_bez_čekání,
            Z_dolů_bez_čekání
        }
        public static readonly byte[] directionmask =
        {
            0b01000000, // nahoru
            0b01010000, // nahoru_doprava
            0b01100000, // doprava
            0b01110000, // doprava_dolů
            0b10000000, // dolů
            0b10010000, // doleva_dolů
            0b10100000, // doleva
            0b10110000, // doleva_nahoru
            0b11000000, // Z_nahoru
            0b11010000, // Z_dolů
            0b11100000, // Z_nahoru_bez_čekání
            0b11110000 // Z_dolů_bez_čekání
        };

        static private int Max(int n1, int n2, int n3)
        {
            int m1 = n1 > n2 ? n1 : n2;
            int m2 = n2 > n3 ? n2 : n3;
            return m1 > m2 ? m1 : m2;
        }
        public static List<byte> DecompressMotion(in List<byte> motion)
        {
            // kontrola dat
            if (motion == null) throw new ArgumentNullException("Invalid argument");
            if (motion.Count == 0) return null;
            foreach (byte step in motion)
            {
                if (step < '@') throw new ArgumentException("Argument is invalid");
            }
            // dekomprese dat
            List<byte> newmotion = new List<byte>();
            foreach (byte step in motion)
            {
                byte direction = (byte)(step & 0b11110000);
                byte count = (byte)(step & 0b00001111);
                count++;
                for (int i = 0; i < count; i++)
                {
                    newmotion.Add(direction);
                }
            }
            return newmotion;
        }
        public static List<byte> CompressMotion(List<byte> motion)
        {
            // kontrola dat
            if (motion == null) throw new ArgumentNullException("Invalid argument");
            if (motion.Count == 0) return null;
            foreach (byte step in motion)
            {
                if (step < '@') throw new ArgumentException("Argument is invalid");
            }
            // dekomprese dat
            motion = DecompressMotion(motion);
            // přepočt kroků
            byte laststep = 0;
            List<byte> direction = new List<byte>();
            List<byte> count = new List<byte>();
            foreach (byte step in motion)
            {
                if (step != laststep)
                {
                    laststep = step;
                    direction.Add(step);
                    count.Add(0);
                    continue;
                }
                if (count[count.Count - 1] >= 15)
                {
                    if (count[count.Count - 1] >= 16) throw new Exception("Counter failed");
                    direction.Add(step);
                    count.Add(0);
                    continue;
                }
                count[count.Count - 1]++;
            }
            // sloučení dat
            if (direction.Count != count.Count) throw new Exception("Fusion failed");
            motion.Clear();
            for (int i = 0; i < direction.Count; i++)
            {
                byte newbyte = (byte)(direction[i] | count[i]);
                motion.Add(newbyte);
            }
            return motion;
            #region původní algoritmus
            /*
            if ((motion == null) || (motion.Count == 0))
            {
                throw new Exception("Argument is null or empty");
            }
            // přepočet opakujících se kroků:
            const uint looptimeout = 1000000;
            uint timeoutcounter = 0;
            List<byte> partstep = new List<byte>();
            List<byte> partcount = new List<byte>();
            byte laststep = 0;
            foreach (byte step in motion)
            {
                if (timeoutcounter > looptimeout)
                {
                    throw new Exception("Loop timeout");
                }
                if (((byte)(step & 0b11110000)) != laststep)
                {
                    laststep = (byte)(step & 0b11110000);
                    partstep.Add(laststep);
                    partcount.Add((byte)(step & 0b00001111));
                    timeoutcounter++;
                    continue;
                }
                if (partcount[partcount.Count - 1] >= 15)
                {
                    if (partcount[partcount.Count -1] >= 16)
                    {
                        throw new Exception("Counter failed");
                    }
                    byte newstep = (byte)(step & 0b11110000);
                    partstep.Add(newstep);
                    byte newcount = (byte)(step & 0b00001111);
                    partcount.Add(newcount);
                    timeoutcounter++;
                    continue;
                }
                byte sum = (byte)((byte)(step & 0b00001111) + partcount[partcount.Count - 1]);
                if (sum >= 16)
                {
                    byte oldbyte = partcount[partcount.Count - 1];
                    byte newbyte = (byte)(step & 0b00001111);
                    if (oldbyte == 15)
                    {
                        byte newstep = (byte)(step & 0b11110000);
                        partstep.Add(newstep);
                        byte newcount = (byte)(step & 0b00001111);
                        partcount.Add(newcount);
                        timeoutcounter++;
                        continue;
                    }
                    partcount[partcount.Count - 1] = 0b00001111;
                    byte diference = (byte)(15 - oldbyte);
                    newbyte -= diference;
                    partstep.Add((byte)(step & 0b11110000));
                    partcount.Add(newbyte);
                    timeoutcounter++;
                    continue;
                }
                partcount[partcount.Count - 1] += (byte)(step & 0b00001111);
                timeoutcounter++;
            }
            // sloučení součtů:
            if (partstep.Count != partcount.Count)
            {
                throw new Exception("Merge failed");
            }
            List<byte> newmotion = new List<byte>();
            for (int i = 0; i < partstep.Count; i++)
            {
                byte newbyte = (byte)(partstep[i] | partcount[i]);
                newmotion.Add(newbyte);
            }
            return newmotion;
            */
            #endregion
        }
        public static List<gridpoint> GetLine(int x0, int y0, int z0, int x1, int y1, int z1)
        {
            List<gridpoint> line = new List<gridpoint>();
            int dx = Math.Abs(x1-x0), sx = x0<x1 ? 1 : -1;
            int dy = Math.Abs(y1-y0), sy = y0<y1 ? 1 : -1;
            int dz = Math.Abs(z1-z0), sz = z0<z1 ? 1 : -1;
            int dm = Max(dx, dy, dz), i = dm; /* maximum difference */
            x1 = y1 = z1 = dm/2; /* error offset */

            for (; ; )
            {  /* loop */
                gridpoint gp = new gridpoint(x0, y0, z0);
                line.Add(gp);
                if (i-- == 0) break;
                x1 -= dx; if (x1 < 0) { x1 += dm; x0 += sx; }
                y1 -= dy; if (y1 < 0) { y1 += dm; y0 += sy; }
                z1 -= dz; if (z1 < 0) { z1 += dm; z0 += sz; }
            }
            return line;
        }
        public static List<gridpoint> GetLine(in gridpoint gp1, in gridpoint gp2)
        {
            if (gp1.IsEqual(gp2)) return null;
            int x0, y0, z0, x1, y1, z1;
            x0 = gp1.x;
            y0 = gp1.y;
            z0 = gp1.z;
            x1 = gp2.x;
            y1 = gp2.y;
            z1 = gp2.z;
            List<gridpoint> line = new List<gridpoint>();
            int dx = Math.Abs(x1-x0), sx = x0<x1 ? 1 : -1;
            int dy = Math.Abs(y1-y0), sy = y0<y1 ? 1 : -1;
            int dz = Math.Abs(z1-z0), sz = z0<z1 ? 1 : -1;
            int dm = Max(dx, dy, dz), i = dm; /* maximum difference */
            x1 = y1 = z1 = dm/2; /* error offset */

            for (; ; )
            {  /* loop */
                gridpoint gp = new gridpoint(x0, y0, z0);
                line.Add(gp);
                if (i-- == 0) break;
                x1 -= dx; if (x1 < 0) { x1 += dm; x0 += sx; }
                y1 -= dy; if (y1 < 0) { y1 += dm; y0 += sy; }
                z1 -= dz; if (z1 < 0) { z1 += dm; z0 += sz; }
            }
            return line;
        }
        public static List<gridpoint> GetCorrectLine(in gridpoint gp1, in gridpoint gp2)
        {
            if (gp1.IsEqual(gp2)) return null;
            int x0, y0, x1, y1;
            x0 = gp1.x;
            y0 = gp1.y;
            x1 = gp2.x;
            y1 = gp2.y;
            int height = gp2.z - gp1.z;
            List<gridpoint> line = new List<gridpoint>();
            int dx = Math.Abs(x1-x0), sx = x0<x1 ? 1 : -1;
            int dy = -Math.Abs(y1-y0), sy = y0<y1 ? 1 : -1;
            int err = dx+dy, e2; /* error value e_xy */
            for (; ; )
            {  /* loop */
                gridpoint gp = new gridpoint(x0, y0, 0);
                line.Add(gp);
                if (x0==x1 && y0==y1) break;
                e2 = 2*err;
                if (e2 >= dy) { err += dy; x0 += sx; } /* e_xy+e_x > 0 */
                if (e2 <= dx) { err += dx; y0 += sy; } /* e_xy+e_y < 0 */
            }
            return VerticalMotion(line, height);
        }
        public static List<gridpoint> GetCircleCCW(gridpoint center, gridpoint start, gridpoint end)
        {
            int r1 = (int)(center.HorizontalDistanceTo(start) + 0.5);
            int r2 = (int)(center.HorizontalDistanceTo(end) + 0.5);
            if (r1 != r2) throw new ArgumentException("Argument is invalid");
            int height = end.z - start.z;
            start.x -= center.x;
            start.y -= center.y;
            end.x -= center.x;
            end.y -= center.y;
            int radius = (int)(center.HorizontalDistanceTo(start) + 0.5);
            List<gridpoint> q1 = new List<gridpoint>();
            List<gridpoint> q2 = new List<gridpoint>();
            List<gridpoint> q3 = new List<gridpoint>();
            List<gridpoint> q4 = new List<gridpoint>();
            gridpoint gp1 = new gridpoint(), gp2 = new gridpoint(), gp3 = new gridpoint(), gp4 = new gridpoint();
            int x = -radius, y = 0, err = 2-2*radius; /* II. Quadrant */
            do
            {
                gp1.Set(center.x-x, center.y+y); /*   I. Quadrant */
                gp2.Set(center.x-y, center.y-x); /*  II. Quadrant */
                gp3.Set(center.x+x, center.y-y); /* III. Quadrant */
                gp4.Set(center.x+y, center.y+x); /*  IV. Quadrant */
                q1.Add(gp1);
                q2.Add(gp2);
                q3.Add(gp3);
                q4.Add(gp4);
                radius = err;
                if (radius <= y) err += ++y*2+1;           /* e_xy+e_y < 0 */
                if (radius > x || err > y) err += ++x*2+1; /* e_xy+e_x > 0 or no 2nd y-step */
            } while (x < 0);
            List<gridpoint> rawcircle = new List<gridpoint>();
            foreach (gridpoint gp in q1) rawcircle.Add(gp);
            foreach (gridpoint gp in q2) rawcircle.Add(gp);
            foreach (gridpoint gp in q3) rawcircle.Add(gp);
            foreach (gridpoint gp in q4) rawcircle.Add(gp);
            int circlesize = rawcircle.Count;
            int startindex = 0, endindex = 0;
            int startextreme = 2147483647, endextreme = 2147483647;
            for (int i = 0; i < circlesize; i++)
            {
                int startdistance = (int)(rawcircle[i].HorizontalDistanceTo(start) + 0.5);
                if (startdistance < startextreme)
                {
                    startextreme = startdistance;
                    startindex = i;
                }
                int enddistance = (int)(rawcircle[i].HorizontalDistanceTo(end) + 0.5);
                if (enddistance < endextreme)
                {
                    endextreme = enddistance;
                    endindex = i;
                }
            }
            List<gridpoint> finalcircle = new List<gridpoint>();
            if (startindex >= endindex)
            {
                for (int i = startindex; i < circlesize; i++)
                {
                    finalcircle.Add(rawcircle[i]);
                }
                for (int i = 0; i <= endindex; i++)
                {
                    finalcircle.Add(rawcircle[i]);
                }
                return VerticalMotion(finalcircle, height);
            }
            if (startindex < endindex)
            {
                for (int i = startindex; i <= endindex; i++)
                {
                    finalcircle.Add(rawcircle[i]);
                }
                return VerticalMotion(finalcircle, height);
            }
            return null;
        }
        public static List<gridpoint> GetCircleCW(gridpoint center, gridpoint start, gridpoint end)
        {
            int r1 = (int)(center.HorizontalDistanceTo(start) + 0.5);
            int r2 = (int)(center.HorizontalDistanceTo(end) + 0.5);
            if (r1 != r2) throw new ArgumentException("Argument is invalid");
            int height = end.z - start.z;
            start.x -= center.x;
            start.y -= center.y;
            end.x -= center.x;
            end.y -= center.y;
            int radius = (int)(center.HorizontalDistanceTo(start) + 0.5);
            List<gridpoint> q1 = new List<gridpoint>();
            List<gridpoint> q2 = new List<gridpoint>();
            List<gridpoint> q3 = new List<gridpoint>();
            List<gridpoint> q4 = new List<gridpoint>();
            gridpoint gp1 = new gridpoint(), gp2 = new gridpoint(), gp3 = new gridpoint(), gp4 = new gridpoint();
            int x = -radius, y = 0, err = 2-2*radius; /* II. Quadrant */
            do
            {
                gp1.Set(center.x-x, center.y+y); /*   I. Quadrant */
                gp2.Set(center.x-y, center.y-x); /*  II. Quadrant */
                gp3.Set(center.x+x, center.y-y); /* III. Quadrant */
                gp4.Set(center.x+y, center.y+x); /*  IV. Quadrant */
                q1.Add(gp1);
                q2.Add(gp2);
                q3.Add(gp3);
                q4.Add(gp4);
                radius = err;
                if (radius <= y) err += ++y*2+1;           /* e_xy+e_y < 0 */
                if (radius > x || err > y) err += ++x*2+1; /* e_xy+e_x > 0 or no 2nd y-step */
            } while (x < 0);
            List<gridpoint> rawcircle = new List<gridpoint>();
            foreach (gridpoint gp in q1) rawcircle.Add(gp);
            foreach (gridpoint gp in q2) rawcircle.Add(gp);
            foreach (gridpoint gp in q3) rawcircle.Add(gp);
            foreach (gridpoint gp in q4) rawcircle.Add(gp);
            rawcircle.Reverse();
            int circlesize = rawcircle.Count;
            int startindex = 0, endindex = 0;
            int startextreme = 2147483647, endextreme = 2147483647;
            for (int i = 0; i < circlesize; i++)
            {
                int startdistance = (int)(rawcircle[i].HorizontalDistanceTo(start) + 0.5);
                if (startdistance < startextreme)
                {
                    startextreme = startdistance;
                    startindex = i;
                }
                int enddistance = (int)(rawcircle[i].HorizontalDistanceTo(end) + 0.5);
                if (enddistance < endextreme)
                {
                    endextreme = enddistance;
                    endindex = i;
                }
            }
            List<gridpoint> finalcircle = new List<gridpoint>();
            if (startindex >= endindex)
            {
                for (int i = startindex; i < circlesize; i++)
                {
                    finalcircle.Add(rawcircle[i]);
                }
                for (int i = 0; i <= endindex; i++)
                {
                    finalcircle.Add(rawcircle[i]);
                }
                return VerticalMotion(finalcircle, height);
            }
            if (startindex < endindex)
            {
                for (int i = startindex; i <= endindex; i++)
                {
                    finalcircle.Add(rawcircle[i]);
                }
                return VerticalMotion(finalcircle, height);
            }
            return null;
        }
        private static List<gridpoint> VerticalMotion(List<gridpoint> motion, int height)
        {
            if (motion == null) throw new ArgumentException("Invalid argument");
            if (motion.Count == 0) return null;
            if (height == 0) return motion;
            bool direction = height > 0 ? true : false;
            gridpoint sp = new gridpoint();
            gridpoint ep = new gridpoint();
            ep.x = motion.Count;
            ep.z = height;
            List<gridpoint> complist = GetLine(sp, ep);
            int lastx = 0;
            int lastz = 0;
            int index = 0;
            int depth = 0;
            sp = new gridpoint();
            ep = new gridpoint();
            for (int i = 0; i < complist.Count; i++)
            {
                if (lastz != complist[i].z)
                {
                    if (direction) depth++;
                    else depth--;
                    lastz = complist[i].z;
                }
                sp = motion[index];
                //ep = complist[i];
                //sp.z += ep.z;
                //
                sp.z = depth;
                motion[index] = sp;
                if (lastx != complist[i].x)
                {
                    index++;
                    if (index >= motion.Count) index = motion.Count - 1;
                    lastx = complist[i].x;
                }
            }
            #region starý algoritmus
            /*
            int depth = 0;
            bool layering = false; // true -> nahoru, false -> dolů
            int field = motion.Count;
            double ratio;
            if (field == Math.Abs(height))
            {
                if (height > 0)
                {
                    for (int i = 0; i < field; i++)
                    {
                        gridpoint n = motion[i];
                        n.z += ++depth;
                        motion[i] = n;
                    }
                }
                if (height < 0)
                {
                    for (int i = 0; i < field; i++)
                    {
                        gridpoint n = motion[i];
                        n.z += --depth;
                        motion[i] = n;
                    }
                }
                return motion;
            }
            if (height > 0)
            {
                layering = true;
                depth++;
            }
            else
            {
                layering = false;
                depth--;
            }
            if (field > Math.Abs(height))
            {
                ratio = (double)field / (double)height;
                int counter = 0;
                int treshold = Math.Abs((int)Math.Round(ratio));
                for (int i = 0; i < field; i++)
                {
                    counter++;
                    if (counter >= treshold)
                    {
                        counter = 0;
                        gridpoint n = motion[i];
                        if (layering) n.z += ++depth;
                        else n.z += --depth;
                        motion[i] = n;
                    }
                    else
                    {
                        gridpoint n = motion[i];
                        n.z += depth;
                        motion[i] = n;
                    }
                }
            }
            if (field < Math.Abs(height))
            {
                gridpoint q = motion[0];
                if (layering) q.z += ++depth;
                else q.z += --depth;
                motion[0] = q;
                ratio = (double)height / (double)field;
                int treshold = (int)Math.Round(ratio);
                for (int i = 0; i < field; i++)
                {
                    gridpoint n = motion[i];
                    if (layering)
                    {
                        depth += treshold;
                        n.z += depth;
                    }
                    else
                    {
                        depth -= treshold;
                        n.z += depth;
                    }
                    motion[i] = n;
                }
            }
            if (!recursion)
            {
                gridpoint start = motion[0];
                gridpoint test = motion[field - 1];
                start.z += height;
                if (start.z != test.z)
                {
                    int difference = start.z - test.z;
                    motion = VerticalMotion(motion, difference, true);
                    gridpoint finaltest = motion[field - 1];
                    difference = start.z - finaltest.z;
                    if (difference != 0) finaltest.z += difference;
                    motion[field - 1] = finaltest;
                }
            }
            */
            #endregion
            return motion;
        }
        public static List<byte> EncodeMotion(in List<gridpoint> motion)
        {
            // kontrola dat
            if (motion.Count == 0) return null;
            if (motion == null) throw new ArgumentException("Invalid argument");
            // zpracování dat
            gridpoint p1 = motion[0], p2 = motion[motion.Count - 1];
            float hdistance = (float)(p1.HorizontalDistanceTo(p2));
            float vdistance = (float)(p2.z - p1.z);
            float ratio = hdistance / vdistance;
            bool ratiocomp = ratio < 2.5f;
            List<byte> data = new List<byte>();
            for (int i = 0; i < motion.Count; i++)
            {
                if (i == motion.Count - 1) break;
                // příprava proměnných
                gridpoint gp1 = motion[i];
                gridpoint gp2 = motion[i + 1];
                int dir = gp1.DirectingTo(gp2);
                #region vertikální složka
                if (dir > 99)
                {
                    int height = gp2.z - gp1.z;
                    if (dir > 199) dir -= 200;
                    else dir -= 100;
                    if (1 < Math.Abs(height))
                    {
                        if (height > 0)
                        {
                            for (int n = 0; n < Math.Abs(height); n++)
                            {
                                data.Add(directionmask[(int)direction.Z_nahoru]);
                            }
                        }
                        else
                        {
                            for (int n = 0; n < Math.Abs(height); n++)
                            {
                                data.Add(directionmask[(int)direction.Z_dolů]);
                            }
                        }
                    }
                    else
                    {
                        if (height > 0)
                        {
                            for (int n = 0; n < Math.Abs(height); n++)
                            {
                                if (ratiocomp) data.Add(directionmask[(int)direction.Z_nahoru]);
                                else data.Add(directionmask[(int)direction.Z_nahoru_bez_čekání]);
                            }
                        }
                        else
                        {
                            for (int n = 0; n < Math.Abs(height); n++)
                            {
                                if (ratiocomp) data.Add(directionmask[(int)direction.Z_dolů]);
                                else data.Add(directionmask[(int)direction.Z_dolů_bez_čekání]);
                            }
                        }
                    }
                }
                #endregion
                #region horizontální složka
                data.Add(directionmask[dir]);
                #endregion
            }
            return data;
        }
    }
    #endregion
    #region čtení souboru
    public class GCodeFile
    {
        public string adress { get; protected set; }
        public List<string> lines { get; private set; }
        public GCodeFile()
        {
            adress = "";
            lines = new List<string>();
        }
        public GCodeFile(string file_adress)
        {
            adress = file_adress;
            lines = new List<string>();
            ReadFile(file_adress);
        }
        public List<string> ReadFile(string file_adress)
        {
            StreamReader SR;
            try { SR = new StreamReader(file_adress); }
            catch (Exception) { return null; }
            if (SR == null) return null;
            if (SR.Peek() < 0) return null;
            else lines.Clear();
            try
            {
                while (SR.Peek() >= 0) lines.Add(SR.ReadLine());
            }
            catch (Exception) { return null; }
            try { SR.Close(); }
            catch (Exception) { }
            return lines;
        }
    }
    #endregion
    #region nastavení a manipulace s CNC
    public class CNC
    {
        #region Konstruktory
        public CNC()
        {
            calltohold = false;
            readytohold = false;
            machinename = "";
            softwareversion = "";
            axesenabled = new bool[3];
            endstopflags = new bool[4];
            realpoz = new int[3];
            artpoz = new int[3];
            axisiscalibrated = new bool[3];
            accelerationenabled = false;
            accelerationtreshold = 0;
            acceleration = 0;
            CncCommunication = null;
            UpdateThread = new Thread(new ThreadStart(UpdateThreadFunction));
            UpdateThread.Name = "UpdateThread";
        }
        public CNC(Communication communication_object)
        {
            if (communication_object == null) throw new ArgumentException("Argument is null");
            calltohold = false;
            readytohold = false;
            machinename = "";
            softwareversion = "";
            axesenabled = new bool[3];
            endstopflags = new bool[4];
            realpoz = new int[3];
            artpoz = new int[3];
            axisiscalibrated = new bool[3];
            accelerationenabled = false;
            accelerationtreshold = 0;
            acceleration = 0;
            CncCommunication = communication_object;
            UpdateThread = new Thread(new ThreadStart(UpdateThreadFunction));
            UpdateThread.Name = "UpdateThread";
        }
        #endregion
        #region Vlastnosti CNC
        public string machinename { get; private set; }
        public string softwareversion { get; private set; }
        public bool[] axesenabled { get; private set; }
        public bool[] endstopflags { get; private set; }
        public int[] realpoz { get; private set; }
        public int[] artpoz { get; private set; }
        public bool[] axisiscalibrated { get; private set; }
        public bool accelerationenabled { get; private set; }
        public int accelerationtreshold { get; private set; }
        public int acceleration { get; private set; }
        #endregion
        #region Komunikace
        public Communication CncCommunication { get; private set; }
        public void SetCommunication(Communication communication_object)
        {
            if (communication_object == null) throw new ArgumentException("Argument is null");
            CncCommunication = communication_object;
        }
        #endregion
        #region Události odpovědí CNC
        public delegate void CncFailureEventHandler(object source, EventArgs e);
        public event CncFailureEventHandler CncFailed;
        protected virtual void OnCncFailed()
        {
            if (CncFailed != null) CncFailed(this, EventArgs.Empty);
        }
        public delegate void InfoUpdatedEventHandler(object source, EventArgs e);
        public event InfoUpdatedEventHandler InfoUpdated;
        protected virtual void OnInfoUpdated()
        {
            if (CncFailed != null) InfoUpdated(this, EventArgs.Empty);
        }
        #endregion
        #region Procesy na pozadí
        private bool calltohold;
        private bool readytohold;
        public Thread UpdateThread { get; private set; }
        public void StartUpdateThread()
        {
            calltohold = false;
            readytohold = false;
            if (UpdateThread.IsAlive) return;
            else
            {
                try
                {
                    UpdateThread.Start();
                }
                catch (Exception ex) { }
            }
        }
        public void StopUpdateThread()
        {
            if (!UpdateThread.IsAlive) return;
            else
            {
                if (UpdateThread.ThreadState == ThreadState.Suspended) ResumeUpdateThread();
                try
                {
                    UpdateThread.Abort();
                }
                catch (Exception) { }
            }
            calltohold = false;
            readytohold = false;
        }
        public void SuspendUpdateThread()
        {
            if (!UpdateThread.IsAlive) return;
            if ((UpdateThread.ThreadState == ThreadState.Suspended) || (UpdateThread.ThreadState == ThreadState.Unstarted)) return;
            calltohold = true;
            int timeoutcounter = 0;
            while ((readytohold = false) && (timeoutcounter < 100))
                {
                timeoutcounter++;
                Thread.Sleep(10);
            }
            try
            {
                UpdateThread.Suspend();
            }
            catch (Exception) { }
            calltohold = false;
            readytohold = false;
        }
        public void ResumeUpdateThread()
        {
            if (!UpdateThread.IsAlive) return;
            if ((UpdateThread.ThreadState != ThreadState.Suspended) || (UpdateThread.ThreadState == ThreadState.Unstarted)) return;
            try
            {
                UpdateThread.Resume();
            }
            catch (Exception) { }
        }
        private void UpdateThreadFunction()
        {
            while (true)
            {
                try
                {
                    if ((CncCommunication != null) && (CncCommunication.isconnected && (CncCommunication.available > 0)))
                    {
                        bool infochanged = false;
                        bool failureoccoured = false;
                        string command = "";
                        string argument = "";
                        DataDivider.ClearCache();
                        Thread.Sleep(20);
                        string data = "";
                        while (CncCommunication.available > 0)
                        {
                            try { data += CncCommunication.ReadLine(); }
                            catch (Exception) { break; }
                        }
                        if (data.Length < 2) continue;
                        DataDivider.Divide(data);
                        while (DataDivider.available > 0)
                        {
                            DataDivider.Read(ref command, ref argument);
                            switch (command)
                            {
                                default: break;
                                case "Xenabled":
                                    if (argument == "1") axesenabled[0] = true;
                                    else axesenabled[0] = false;
                                    infochanged = true;
                                    break;
                                case "Yenabled":
                                    if (argument == "1") axesenabled[1] = true;
                                    else axesenabled[1] = false;
                                    infochanged = true;
                                    break;
                                case "Zenabled":
                                    if (argument == "1") axesenabled[2] = true;
                                    else axesenabled[2] = false;
                                    infochanged = true;
                                    break;
                                case "Xreal":
                                    try { realpoz[0] = Int32.Parse(argument); }
                                    catch (Exception) { break; }
                                    infochanged = true;
                                    break;
                                case "Yreal":
                                    try { realpoz[1] = Int32.Parse(argument); }
                                    catch (Exception) { break; }
                                    infochanged = true;
                                    break;
                                case "Zreal":
                                    try { realpoz[2] = Int32.Parse(argument); }
                                    catch (Exception) { break; }
                                    infochanged = true;
                                    break;
                                case "Xart":
                                    try { artpoz[0] = Int32.Parse(argument); }
                                    catch (Exception) { break; }
                                    infochanged = true;
                                    break;
                                case "Yart":
                                    try { artpoz[1] = Int32.Parse(argument); }
                                    catch (Exception) { break; }
                                    infochanged = true;
                                    break;
                                case "Zart":
                                    try { artpoz[2] = Int32.Parse(argument); }
                                    catch (Exception) { break; }
                                    infochanged = true;
                                    break;
                                case "Xflag":
                                    if (argument == "1") endstopflags[0] = true;
                                    else endstopflags[0] = false;
                                    infochanged = true;
                                    break;
                                case "Yflag":
                                    if (argument == "1") endstopflags[1] = true;
                                    else endstopflags[1] = false;
                                    infochanged = true;
                                    break;
                                case "Zflag":
                                    if (argument == "1") endstopflags[2] = true;
                                    else endstopflags[2] = false;
                                    infochanged = true;
                                    break;
                                case "EXZflag":
                                    if (argument == "1") endstopflags[3] = true;
                                    else endstopflags[3] = false;
                                    infochanged = true;
                                    break;
                                case "acceleration":
                                    try { acceleration = Int32.Parse(argument); }
                                    catch (Exception) { break; }
                                    infochanged = true;
                                    break;
                                case "treshold":
                                    try { accelerationtreshold = Int32.Parse(argument); }
                                    catch (Exception) { break; }
                                    infochanged = true;
                                    break;
                            }
                        }
                        if (infochanged)
                        {
                            infochanged = false;
                            OnInfoUpdated();
                        }
                    }
                    else Thread.Sleep(100);
                }
                catch (ThreadAbortException ex) { break; }
                if (calltohold)
                {
                    readytohold = true;
                    while (calltohold && readytohold) Thread.Sleep(500);
                }
            }
        }
        #endregion
        #region Funkce a práce s fyzickou CNC
        public bool UpdateInfo()
        {
            if ((CncCommunication.isconnected && !(UpdateThread.ThreadState == ThreadState.Running)) && CncCommunication != null)
            {
                CncCommunication.WriteLine("a#");
                return true;
            }
            else return false;
        }
        public bool Restart()
        {
            if ((CncCommunication.isconnected && !(UpdateThread.ThreadState == ThreadState.Running)) && CncCommunication != null)
            {
                CncCommunication.WriteLine("restart#");
                return true;
            }
            else return false;
        }
        public bool ClearCncCache()
        {
            if ((CncCommunication.isconnected && !(UpdateThread.ThreadState == ThreadState.Running)) && CncCommunication != null)
            {
                CncCommunication.WriteLine("~#");
                return true;
            }
            else return false;
        }
        public bool PowerOnAxes(int axis)
        {
            if ((CncCommunication.isconnected && !(UpdateThread.ThreadState == ThreadState.Running)) && CncCommunication != null)
            {
                switch (axis)
                {
                    case 0: CncCommunication.WriteLine("b<0>#"); return true;
                    case 1: CncCommunication.WriteLine("b<1>#"); return true;
                    case 2: CncCommunication.WriteLine("b<2>#"); return true;
                    case 3: CncCommunication.WriteLine("b<3>#"); return true;
                    default: return false;
                }
            }
            else return false;
        }
        public bool PowerOffAxes(int axis)
        {
            if ((CncCommunication.isconnected && !(UpdateThread.ThreadState == ThreadState.Running)) && CncCommunication != null)
            {
                switch (axis)
                {
                    case 0: CncCommunication.WriteLine("c<0>#"); return true;
                    case 1: CncCommunication.WriteLine("c<1>#"); return true;
                    case 2: CncCommunication.WriteLine("c<2>#"); return true;
                    case 3: CncCommunication.WriteLine("c<3>#"); return true;
                    default: return false;
                }
            }
            else return false;
        }
        public bool EnableEndStop(int endstop)
        {
            if ((CncCommunication.isconnected && !(UpdateThread.ThreadState == ThreadState.Running)) && CncCommunication != null)
            {
                switch (endstop)
                {
                    case 0: CncCommunication.WriteLine("d<0>#"); return true;
                    case 1: CncCommunication.WriteLine("d<1>#"); return true;
                    case 2: CncCommunication.WriteLine("d<2>#"); return true;
                    case 3: CncCommunication.WriteLine("d<3>#"); return true;
                    default: return false;
                }
            }
            else return false;
        }
        public bool DisableEndStop(int endstop)
        {
            if ((CncCommunication.isconnected && !(UpdateThread.ThreadState == ThreadState.Running)) && CncCommunication != null)
            {
                switch (endstop)
                {
                    case 0: CncCommunication.WriteLine("e<0>#"); return true;
                    case 1: CncCommunication.WriteLine("e<1>#"); return true;
                    case 2: CncCommunication.WriteLine("e<2>#"); return true;
                    case 3: CncCommunication.WriteLine("e<3>#"); return true;
                    default: return false;
                }
            }
            else return false;
        }
        public bool SpindleOn()
        {
            if ((CncCommunication.isconnected && !(UpdateThread.ThreadState == ThreadState.Running)) && CncCommunication != null)
            {
                CncCommunication.WriteLine("f#");
                return true;
            }
            else return false;
        }
        public bool SpindleOff()
        {
            if ((CncCommunication.isconnected && !(UpdateThread.ThreadState == ThreadState.Running)) && CncCommunication != null)
            {
                CncCommunication.WriteLine("g#");
                return true;
            }
            else return false;
        }
        public bool SetFan(int value)
        {
            if ((CncCommunication.isconnected && !(UpdateThread.ThreadState == ThreadState.Running)) && CncCommunication != null)
            {
                string fanset = "j<" + value.ToString() + ">#";
                CncCommunication.WriteLine(fanset);
                return true;
            }
            return false;
        }
        public bool ExeMotion()
        {
            if ((CncCommunication.isconnected && !(UpdateThread.ThreadState == ThreadState.Running)) && CncCommunication != null)
            {
                CncCommunication.WriteLine("k#");
                return true;
            }
            else return false;
        }
        public bool TransferMotion()
        {
            return true;
            if ((CncCommunication.isconnected && !(UpdateThread.ThreadState == ThreadState.Running)) && CncCommunication != null)
            {
                //
            }
        }
        public bool AxesHoming(int axis)
        {
            if ((CncCommunication.isconnected && !(UpdateThread.ThreadState == ThreadState.Running)) && CncCommunication != null)
            {
                switch (axis)
                {
                    case 0: CncCommunication.WriteLine("m<0>#"); return true;
                    case 1: CncCommunication.WriteLine("m<1>#"); return true;
                    case 2: CncCommunication.WriteLine("m<2>#"); return true;
                    case 3: CncCommunication.WriteLine("m<3>#"); return true;
                    default: return false;
                }
            }
            else return false;
        }
        public bool SetVirtualX(int value)
        {
            if ((CncCommunication.isconnected && !(UpdateThread.ThreadState == ThreadState.Running)) && CncCommunication != null)
            {
                string virt = "n<" + value.ToString() + ">#";
                CncCommunication.WriteLine(virt);
                return true;
            }
            else return false;
        }
        public bool SetVirtualY(int value)
        {
            if ((CncCommunication.isconnected && !(UpdateThread.ThreadState == ThreadState.Running)) && CncCommunication != null)
            {
                string virt = "o<" + value.ToString() + ">#";
                CncCommunication.WriteLine(virt);
                return true;
            }
            else return false;
        }
        public bool SetVirtualZ(int value)
        {
            if ((CncCommunication.isconnected && !(UpdateThread.ThreadState == ThreadState.Running)) && CncCommunication != null)
            {
                string virt = "p<" + value.ToString() + ">#";
                CncCommunication.WriteLine(virt);
                return true;
            }
            else return false;
        }
        public bool EnableAcceleration()
        {
            if ((CncCommunication.isconnected && !(UpdateThread.ThreadState == ThreadState.Running)) && CncCommunication != null)
            {
                CncCommunication.WriteLine("q#");
                return true;
            }
            else return false;
        }
        public bool DisableAcceleration()
        {
            if ((CncCommunication.isconnected && !(UpdateThread.ThreadState == ThreadState.Running)) && CncCommunication != null)
            {
                CncCommunication.WriteLine("r#");
                return true;
            }
            else return false;
        }
        public bool SetAcceleration(int value)
        {
            if ((CncCommunication.isconnected && !(UpdateThread.ThreadState == ThreadState.Running)) && CncCommunication != null)
            {
                string val = "s<" + value.ToString() + ">#";
                CncCommunication.WriteLine(val);
                return true;
            }
            else return false;
        }
        public bool SetTreshold(int value)
        {
            if ((CncCommunication.isconnected && !(UpdateThread.ThreadState == ThreadState.Running)) && CncCommunication != null)
            {
                string val = "t<" + value.ToString() + ">#";
                CncCommunication.WriteLine(val);
                return true;
            }
            else return false;
        }
        public bool SetSpeedXY(int value)
        {
            if ((CncCommunication.isconnected && !(UpdateThread.ThreadState == ThreadState.Running)) && CncCommunication != null)
            {
                string val = "u<" + value.ToString() + ">#";
                CncCommunication.WriteLine(val);
                return true;
            }
            else return false;
        }
        public bool SetSpeedZ(int value)
        {
            if ((CncCommunication.isconnected && !(UpdateThread.ThreadState == ThreadState.Running)) && CncCommunication != null)
            {
                string val = "v<" + value.ToString() + ">#";
                CncCommunication.WriteLine(val);
                return true;
            }
            else return false;
        }
        #endregion
    }
    #endregion
    public static class DataDivider
    {
        private static readonly char openingcharacter = '[';
        private static readonly char closingcharacter = ']';
        private static readonly char separator = ':';
        private static List<string> commands = new List<string>();
        private static List<string> arguments = new List<string>();
        public static int available { get { return commands.Count; } private set { available = value; } }
        public static void ClearCache()
        {
            commands.Clear();
            arguments.Clear();
        }
        public static bool Read(ref string command, ref string argument, int index = -1)
        {
            if (index < -1) throw new ArgumentException("Index is out of range");
            if (index == -1)
            {
                if (available == 0) return false;
                command = commands[0];
                argument = arguments[0];
                commands.RemoveAt(0);
                arguments.RemoveAt(0);
                return true;
            }
            if (index > (available - 1)) return false;
            else
            {
                command = commands[index];
                argument = arguments[index];
                commands.RemoveAt(index);
                arguments.RemoveAt(index);
                return true;
            }
        }
        public static void Divide(string data)
        {
            if (data.Length == 0) return;
            int index = 0;
            while (index < data.Length)
            {
                bool finish = false;
                bool abort = false;
                while (true)
                {
                    if (data[index] == openingcharacter) break;
                    else index++;
                    if (index >= data.Length) { abort = true; break; }
                }
                if (abort) continue;
                string commandbody = "";
                while (true)
                {
                    index++;
                    if (index >= data.Length) { abort= true; break; }
                    if (data[index] == separator) break;
                    if (data[index] == closingcharacter) { finish = true; break; }
                    commandbody += data[index];
                }
                if (abort) continue;
                if (finish)
                {
                    commands.Add(commandbody);
                    arguments.Add("");
                    continue;
                }
                commands.Add(commandbody);
                string argumentbody = "";
                while (true)
                {
                    index++;
                    if (index >= data.Length) { abort = true; break; }
                    if (data[index] == closingcharacter) break;
                    argumentbody += data[index];
                }
                if (abort) continue;
                arguments.Add(argumentbody);
            }
        }
    }
    #region komunikace s CNC
    public class Communication
    {
        public bool isconnected { get; protected set; }
        public int available { get { return datain.Length; } private set { available = value; } }
        protected string datain;
        protected string dataout;
        public Communication()
        {
            isconnected = false;
            datain = "";
            dataout = "";
        }
        public char Read()
        {
            if (datain.Length == 0) throw new Exception("Any data to read");
            char data = datain[0];
            datain = datain.Remove(0, 1);
            return data;
        }
        public string ReadLine()
        {
            if (datain.Length == 0) throw new Exception("Any data to read");
            string data = "";
            do
            {
                data += datain[0];
                datain = datain.Remove(0, 1);
            } while ((datain.Length > 0) && (data[data.Length - 1]  != '\n'));
            return data;
        }
        public void Write(char data_to_send)
        {
            dataout += data_to_send.ToString();
            OnDataToSend();
        }
        public void Write(string data_to_send)
        {
            dataout = data_to_send;
            OnDataToSend();
        }
        public void WriteLine(char data_to_send)
        {
            dataout += data_to_send.ToString();
            dataout += '\n'.ToString();
            OnDataToSend();
        }
        public void WriteLine(String data_to_send)
        {
            dataout += data_to_send;
            dataout += '\n'.ToString();
            OnDataToSend();
        }
        public void ClearReceiveCache() { datain = ""; }
        public void ClearSendCache() { dataout = ""; }
        public delegate void DataToSendEventHandler(object source, EventArgs e);
        public event DataToSendEventHandler DataToSend;
        protected virtual void OnDataToSend()
        {
            if (DataToSend != null) DataToSend(this, EventArgs.Empty);
        }
    }
    public struct serialportsettings
    {
        public string settingsid;
        public int baudrate;
        public int databits;
        public int readtimeout;
        public int writetimeout;
        public int writebuffersize;
        public int readbuffersize;
        public int receivedbytestreshold;
        public bool rtsenabled;
        public bool dtrenabled;
        public Handshake handshake;
        public StopBits stopbits;
        public Parity parity;
        public System.Text.Encoding encoding;
        public serialportsettings(serialportsettings settings)
        {
            settingsid = settings.settingsid;
            baudrate = settings.baudrate;
            databits = settings.databits;
            readtimeout = settings.readtimeout;
            writetimeout = settings.writetimeout;
            writebuffersize = settings.writebuffersize;
            readbuffersize = settings.readbuffersize;
            receivedbytestreshold = settings.receivedbytestreshold;
            rtsenabled = settings.rtsenabled;
            dtrenabled = settings.dtrenabled;
            stopbits = settings.stopbits;
            parity = settings.parity;
            handshake = settings.handshake;
            encoding = settings.encoding;
        }
        public void Default()
        {
            settingsid = "default";
            baudrate = 115200; //921600
            databits = 8;
            readtimeout = 200;
            writetimeout = 200;
            writebuffersize = 65536;
            readbuffersize = 65536;
            receivedbytestreshold = 2;
            rtsenabled = false;
            dtrenabled = true;
            stopbits = StopBits.One;
            parity = Parity.None;
            handshake = Handshake.None;
            encoding = System.Text.Encoding.ASCII;
        }
    }
    public class SerialStream : Communication
    {
        public Exception connectexception { get; private set; }
        public Exception disconnectexception { get; private set; }
        public Exception runtimeexception { get; private set; }
        public serialportsettings settings { get; protected set; }
        public SerialPort Port { get; protected set; }
        public SerialStream()
        {
            Port = new SerialPort();
            settings = new serialportsettings();
            settings.Default();
            ApplySettings(settings);
            connectexception = null;
            disconnectexception = null;
            runtimeexception = null;
        }
        public SerialStream(in serialportsettings port_settings)
        {
            Port = new SerialPort();
            settings = port_settings;
            ApplySettings(settings);
            connectexception = null;
            disconnectexception = null;
            runtimeexception = null;
        }
        public void ApplySettings(in serialportsettings port_settings)
        {
            try
            {
                Port.BaudRate = settings.baudrate;
                Port.DataBits = settings.databits;
                Port.DtrEnable = settings.dtrenabled;
                Port.RtsEnable = settings.rtsenabled;
                Port.Encoding = settings.encoding;
                Port.Handshake = settings.handshake;
                Port.Parity = settings.parity;
                Port.StopBits = settings.stopbits;
                Port.ReadTimeout = settings.readtimeout;
                Port.WriteTimeout = settings.writetimeout;
                Port.ReceivedBytesThreshold = settings.receivedbytestreshold;
                Port.WriteBufferSize = settings.writebuffersize;
                Port.ReadBufferSize = settings.readbuffersize;
            }
            catch (Exception) { }
        }
        public bool Connect()
        {
            if (Port == null) throw new Exception("Port object is null");
            if (Port.IsOpen) { isconnected = true; return true; }
            try
            {
                Port.Open();
            }
            catch (Exception ex) { connectexception = ex; return false; }
            isconnected = true;
            DataToSend += OnDataToSend;
            Port.DataReceived += OnDataRecieved;
            return true;
        }
        public bool Disconnect()
        {
            if (Port == null) throw new Exception("Port object is null");
            if (!Port.IsOpen) { isconnected = false; return true; }
            var CloseDown = new System.Threading.Thread(new System.Threading.ThreadStart(DisconnectThread));
            CloseDown.Start();
            Thread.Sleep(100);
            if (Port.IsOpen) return false;
            isconnected = false;
            return true;
        }
        private void DisconnectThread()
        {
            if (Port.IsOpen)
            {
                try
                {
                    DataToSend -= OnDataToSend;
                    Port.DataReceived -= OnDataRecieved;
                    Thread.Sleep(50);
                    Port.Close();
                }
                catch (Exception ex) { disconnectexception = ex; return; }
            }
        }
        public void OnDataToSend(object source, EventArgs e)
        {
            if (source == null) throw new Exception("Invalid source");
            if (!Port.IsOpen) { isconnected = false; return; }
            try
            {
                Port.Write(dataout);
            }
            catch (Exception ex) { runtimeexception = ex; return; }
            dataout = "";
        }
        public void OnDataRecieved(object source, EventArgs e)
        {
            if (source == null) throw new Exception("Source is null");
            if (!Port.IsOpen) { isconnected = false; return; }
            try
            {
                datain += Port.ReadExisting();
            }
            catch (Exception ex) { runtimeexception = ex; return; }
            if (Port.IsOpen) isconnected = true;
        }
    }
    #endregion
}