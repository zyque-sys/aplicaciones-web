using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002b_ProyectoSystemDrawing
{
    public partial class Oso : Form
    {
        Graphics dibujo;
        Pen lineart = new Pen(Brushes.Black, 2);
        Pen lineart1 = new Pen(Brushes.Black, 3);

        public Oso()
        {
            InitializeComponent();
            dibujo = this.panel1.CreateGraphics();
        }




        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

            
        }
        #region Coloreado
        //private void CB_Pancita_CheckedChanged(object sender, EventArgs e)
        //{
        //    Pen sombra = new Pen(Color.SaddleBrown, 7);
        //    #region RellenoBase
        //    Point location = new Point(100, 162); //110,172
        //    Size tamanoPancita = new Size(200, 170);//220,177
        //    Rectangle rectPancita = new Rectangle(location, tamanoPancita);
        //    dibujo.FillEllipse(Brushes.Peru, rectPancita);
        //    #endregion

        //    #region Sombra1
        //    Point p1 = new Point(324, 205);
        //    Point p2 = new Point(279, 230);
        //    Point p3 = new Point(184, 347);
        //    Point p4 = new Point(289, 295);
        //    Point[] puntos = { p1, p2, p3, p4 };

        //    dibujo.FillClosedCurve(Brushes.Sienna, puntos);
        //    #endregion
        //    #region Sombra2
        //    Point p6 = new Point(334, 250);
        //    Point p7 = new Point(299, 319);
        //    Point p8 = new Point(246, 348);
        //    Point p9 = new Point(196, 347);
        //    Point[] sombra1 = { p6, p7, p8, p9 };

        //    dibujo.DrawCurve(sombra, sombra1);
        //    #endregion
        //}

        //private void CB_Torso_CheckedChanged(object sender, EventArgs e)
        //{


        //        #region RellenoBase
        //        Point location = new Point(96, 69);
        //        Size tamanoTorso = new Size(211, 199);
        //        Rectangle rectTorso = new Rectangle(location, tamanoTorso);
        //        dibujo.FillEllipse(Brushes.Peru, rectTorso);

        //        Point p1 = new Point(130, 157);
        //        Point p2 = new Point(144, 46);
        //        Point p3 = new Point(160, 41);
        //        Point p4 = new Point(153, 49);
        //        Point[] mechon1 = { p1, p2, p3, p4 };
        //        dibujo.FillClosedCurve(Brushes.Peru, mechon1);
        //        Point p5 = new Point(148, 52);
        //        Point p6 = new Point(168, 42);
        //        Point p7 = new Point(200, 44);
        //        Point p8 = new Point(244, 56);
        //        Point p9 = new Point(265,65);
        //        Point p10 = new Point(281, 80);
        //    Point[] mechon2 = {p5,p6,p7,p8,p9,p10};
        //    dibujo.FillClosedCurve(Brushes.Peru, mechon2);



        //    #endregion

        //}
        #endregion

        private void Oso_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CB_Cara_CheckedChanged(object sender, EventArgs e)
        {
            
            #region Curva inferior del ojo izquierdo
            Point location = new Point(54,69);
            Size tamanoOjo = new Size(39,35);
            Rectangle rango = new Rectangle(location, tamanoOjo);
            Single inicio = 0;
            Single final = 230;
            dibujo.DrawArc(lineart, rango, inicio, final);
            #endregion
            #region Ojera
            Point location1 = new Point(54, 69);
            Size tamanoOjo1 = new Size(44, 36);
            Rectangle rango1 = new Rectangle(location1, tamanoOjo1);
            Single inicio1 = 20;
            Single final1 = 190;
            dibujo.DrawArc(lineart, rango1, inicio1, final1);
            #endregion
            #region Ojo derecho
            Point o1 = new Point(29,100);
            Point o2 = new Point(29,98);
            Point o3 = new Point(39,89);
            Point o4 = new Point(53,82);
            Point o5 = new Point(52,97);

            Point[] ojoDer = { o1,o2,o3,o4,o5};

            Point o6 = new Point(50,83);
            Point o7 = new Point(50,89);
            Point o8 = new Point(62,80);
            Point o9 = new Point(61,86);
            Point[] pupilaDer = { o6, o7 };
            Point[] pupilaIzq = { o8, o9 };

            dibujo.DrawCurve(lineart1,pupilaDer);
            dibujo.DrawCurve(lineart1, pupilaIzq);
            dibujo.DrawCurve(lineart, ojoDer);

            #endregion
            #region Linea del parpado
            Point p1 = new Point(55, 75);
            Point p2 = new Point(75,78);
            Point p3 = new Point(97,94);
            Point[] parpado={p1,p2,p3 };
            dibujo.DrawCurve(lineart,parpado);
            #endregion
            #region Hocico
            #region Piel
            Point h1 = new Point(53, 97);
            Point h2 = new Point(15, 106);
            Point h3 = new Point(22, 150);
            Point h4 = new Point(41, 148);

            Point[] nuzzle = { h1, h2, h3, h4 };
            dibujo.DrawCurve(lineart, nuzzle);
            Point l1 = new Point(36, 138);
            Point l2 = new Point(42, 146);
            Point l3 = new Point(62, 144);
            Point l4 = new Point(82, 134);
            Point l5 = new Point(92, 137);
            Point[] upperLip = { l1, l2, l3, l4, l5 };
            dibujo.DrawCurve(lineart, upperLip);
            Point lw1 = new Point(94, 137);
            Point lw2 = new Point(101, 149);
            Point lw3 = new Point(99, 162);
            Point lw4 = new Point(77, 157);
            Point lw5 = new Point(58, 156);
            Point lw6 = new Point(50, 159);
            Point[] lowerLip = { lw1, lw2, lw3, lw4, lw5, lw6 };
            dibujo.DrawCurve(lineart, lowerLip);

            Point c1 = new Point(48, 154);
            Point c2 = new Point(40, 161);
            Point c3 = new Point(38, 166);
            Point c4 = new Point(48, 174);
            Point c5 = new Point(66, 178);
            Point c6 = new Point(83, 175);
            Point c7 = new Point(95, 167);
            Point[] chin = { c1, c2, c3, c4, c5, c6, c7 };
            dibujo.DrawCurve(lineart, chin);

            Point j1 = new Point(87, 164);
            Point j2 = new Point(104, 168);
            Point j3 = new Point(109, 162);
            Point j4 = new Point(106, 139);
            Point j5 = new Point(90, 126);
            Point j6 = new Point(76, 126);
            Point[] jaw = { j1, j2, j3, j4, j5, j6 };
            dibujo.DrawCurve(lineart, jaw);

            Point n1 = new Point(76, 126);
            Point n2 = new Point(67, 110);
            Point n3 = new Point(53, 97);
            Point[] nuzzle2 = { n1, n2, n3 };
            dibujo.DrawCurve(lineart, nuzzle2);
            #endregion

            #region Nariz
            Point nn1 = new Point(14,107);
            Point nn2 = new Point(22,102);
            Point nn3 = new Point(38,101);
            Point nn4 = new Point(48,104);
            Point nn5 = new Point(46,114);
            Point nn6 = new Point(31,129);
            Point nn7 = new Point(14,107);
            Point[] nariz = { nn1,nn2,nn3,nn4,nn5,nn6,nn7};
            dibujo.DrawCurve(lineart, nariz);

            Point f1 = new Point(47,105);
            Point f2 = new Point(36,106);
            Point f3 = new Point(28,115);
            Point f4 = new Point(15,103);
            Point[] detalleNariz = { f1,f2,f3,f4};
            dibujo.DrawCurve(lineart, detalleNariz);
            #endregion
            #region Boca
            Point t1 = new Point(39, 148);
            Point t2 = new Point(60,152);
            Point t3 = new Point(76,146);
            Point t4 = new Point(91,136);
            Point[] dientes = {t1,t2,t3,t4 };

            Point x1 = new Point(51,146);
            Point x2 = new Point(53, 152);

            Point xx1 = new Point(64,143);
            Point xx2 = new Point(68,150);
            Point xxx1 = new Point(78,135);
            Point xxx2 = new Point(82, 144);

            Point lengua1 = new Point(78,156);
            Point lengua2 = new Point(89,148);
            Point lengua3 = new Point(99, 146);
            Point[] lengua = {lengua1,lengua2,lengua3 };
            dibujo.DrawCurve(lineart, lengua);
            dibujo.DrawCurve(lineart,dientes);
            dibujo.DrawLine(lineart,x1,x2);
            dibujo.DrawLine(lineart, xx1, xx2);
            dibujo.DrawLine(lineart, xxx1, xxx2);

            #endregion



            #endregion
            #region Cara
            Point u1 = new Point(21,103);
            Point u2 = new Point(11,115);
            Point u3 = new Point(8,141);
            Point u4 = new Point(16,163);
            Point u5 = new Point(31,176);
            Point u6 = new Point(54,185);
            Point u7 = new Point(69,184);
            Point u8 = new Point(95,178);
            Point u9 = new Point(141,146);
            Point u10 = new Point(154,112);
            Point u11 = new Point(152,92);
            Point u12 = new Point(142,77);

            Point[] cachetes = {u1,u2,u3,u4,u5,u6,u7,u8,u9,u10,u11,u12 };
            dibujo.DrawCurve(lineart1,cachetes);

            Point g1 = new Point(143,84);
            Point g2 = new Point(130,46);
            Point g3 = new Point(112,29);
            Point[] craneo = {g1,g2,g3 };
            dibujo.DrawCurve(lineart1,craneo);

            Point k1 = new Point(111,35);
            Point k2 = new Point(103,9);
            Point k3 = new Point(80,1);
            Point k4 = new Point(64,10);
            Point k5 = new Point(63, 25);
            Point k6 = new Point(76,37);
            Point k7 = new Point(92,36);

            Point k8 = new Point(35,31);
            Point k9 = new Point(23,27);
            Point k10 = new Point(6, 31);
            Point k11 = new Point(1, 44);
            Point k12 = new Point(8,60);
            Point k13= new Point(23,61);
            Point k14 = new Point(30, 56);
            Point[] orejaDer = { k8, k9, k10, k11, k12, k13, k14 };

            Point[] orejaIzq = { k1,k2,k3,k4,k5,k6,k7};
            dibujo.DrawCurve(lineart1,orejaIzq);
            dibujo.DrawCurve(lineart1,orejaDer);

            Point z1 = new Point(100,33);
            Point z2 = new Point(94,26);
            Point z3 = new Point(94,14);
            Point z4 = new Point(86,12);

            Point z5 = new Point(93,19);
            Point z6 = new Point(88,15);
            Point z7 = new Point(79,15);
            Point z8 = new Point(75,23);
            Point z9 = new Point(85,31);
            Point z10 = new Point(94,26);
            Point[] cartilago = { z1,z2,z3,z4};
            Point[] cartilago1 = { z5,z6,z7,z8,z9,z10};
            dibujo.DrawCurve(lineart,cartilago);
            dibujo.DrawCurve(lineart, cartilago1);

            Point s1 = new Point(27,42);
            Point s2 = new Point(20,40);
            Point s3 = new Point(13, 41);
            Point s4 = new Point(10, 46);
            Point s5 = new Point(12, 50);

            Point s6 = new Point(16, 41);
            Point s7 = new Point(26,50);
            Point []cartilagoX = { s1,s2,s3,s4,s5};
            Point[] cartilagoXX ={ s6,s7};
            Point s8 = new Point(24,84);
            Point s9 = new Point(21, 103);
            Point[] temple = { s8, s9 };
            dibujo.DrawCurve(lineart, cartilagoX);
            dibujo.DrawCurve(lineart, cartilagoXX);
            dibujo.DrawCurve(lineart1, temple);

            #endregion
            #region Copete
            Point y1 = new Point(63,25);
            Point y2 = new Point(48,23);
            Point y3 = new Point(36,31);
            Point y4 = new Point(34,35);

            Point[] mechon1 = { y1,y2,y3,y4};

            Point y5 = new Point(55,32);
            Point y6 = new Point(39,35);
            Point y7 = new Point(29,42);
            Point y8 = new Point(27,49);
            Point y9 = new Point(32,52);

            Point[] mechon2 = { y5,y6,y7,y8,y9 };

            Point y10 = new Point(46,42);
            Point y11 = new Point(35,48);
            Point y12 = new Point(31,56);
            Point y13= new Point(32,61);
            Point y14= new Point(37,60);
            Point y15= new Point(49,49);

            Point[] mechon3 = { y10, y11, y12, y13,y14,y15 };

            dibujo.DrawCurve(lineart1, mechon1);
            dibujo.DrawCurve(lineart1, mechon2);
            dibujo.DrawCurve(lineart1, mechon3);


            #endregion
            #region Cejas
            Point q1 = new Point(42,59);
            Point q2 = new Point(33,66);
            Point q3 = new Point(24,68);
            Point q4 = new Point(18,71);
            Point q5 = new Point(22,83);
            Point q6 = new Point(40,82);
            Point q7 = new Point(54,70);

            Point[] cejaDer = { q1, q2, q3, q4, q5, q6, q7 };

            Point q8 = new Point(55,56);
            Point q9 = new Point(52,63);
            Point q10 = new Point(58,70);
            Point[] entrecejo = { q8,q9,q10};

            Point q11 = new Point(71,57);
            Point q12 = new Point(64,55);
            Point q13 = new Point(59,71);
            Point q14 = new Point(78,73);
            Point q15 = new Point(95,67);

            Point[] cejaIzq = { q11,q12,q13,q14,q15};

            dibujo.DrawCurve(lineart,cejaDer);
            dibujo.DrawCurve(lineart, entrecejo);
            dibujo.DrawCurve(lineart, cejaIzq);
            #endregion
            #region Parpados
            Point b1 = new Point(84,72);
            Point b2 = new Point(89,75);
            Point b3 = new Point(95,77);
            Point b4 = new Point(95,82);
            Point b5 = new Point(93,84);
            Point[] parpadoizq = { b1, b2, b3, b4, b5 };
            dibujo.DrawCurve(lineart, parpadoizq);
            Point b6 = new Point(105,84);
            Point b7 = new Point(107,86);
            Point b8 = new Point(105,84);
            Point[] det = { b6, b7, b8 };
            dibujo.DrawCurve(lineart, det);


            #endregion

        }



        private void CB_TorsoLinea_CheckedChanged(object sender, EventArgs e)
        {
            #region pelos pecho
            Point p1 = new Point(92,179);
            Point p2 = new Point(93,193);
            Point p3 = new Point(99,186);

            Point[] mechon1 = {p1,p2,p3 };

            Point p4 = new Point(99, 186);
            Point p5 = new Point(96,198);
            Point p6 = new Point(102,210);
            Point p7 = new Point(107,197);
            Point[] mechon2 ={ p4,p5,p6,p7};

            Point p8 = new Point(107, 197);
            Point p9 = new Point(111,217);
            Point p10 = new Point(113,205);

            Point[] mechon3 = {p8,p9,p10 };

            Point p11 = new Point(110, 215);
            Point p12 = new Point(132,237);

            Point p13 = new Point(118,226);
            Point p14 = new Point(121,238);
            Point p15 = new Point(131, 246);

            Point[] bubi = { p11,p12};
            Point[] lonja = { p13, p14, p15 };

            dibujo.DrawCurve(lineart1, bubi);
            dibujo.DrawCurve(lineart1, lonja);
            dibujo.DrawCurve(lineart1,mechon1);
            dibujo.DrawCurve(lineart1, mechon2);
            dibujo.DrawCurve(lineart1, mechon3);

            #endregion
            #region pelos espalda
            Point w1 = new Point(134,53);
            Point w2 = new Point(160,40);
            Point w3 = new Point(159,47);

            Point[] pelos1 = { w1, w2, w3 };

            Point w4 = new Point(145,57);
            Point w5 = new Point(161,46);
            Point w6 = new Point(179,41);
            Point w7 = new Point(201,45);

            Point[] pelos2 = { w4,w5,w6,w7 };

            Point w8 = new Point(158,61);
            Point w9 = new Point(208,47);
            Point w10 = new Point(250,54);
            Point w11 = new Point(238,29);
            Point w12 = new Point(261,64);
            Point w13 = new Point(283,84);
            Point w14 = new Point(264,81);
            Point w15 = new Point(286,101);
            Point w16 = new Point(264,98);

            Point[] pelos3 = { w8,w9,w10,w11,w12,w13,w14,w15,w16 };

            dibujo.DrawCurve(lineart1,pelos1);
            dibujo.DrawCurve(lineart1, pelos2);
            dibujo.DrawCurve(lineart1, pelos3);

            #endregion
            #region trasero
            Point q1 = new Point(278,101);
            Point q2 = new Point(300,132);
            Point q3 = new Point(312,157);
            Point q4 = new Point(319,207);

            Point[] espalda = { q1, q2, q3, q4 };

            dibujo.DrawCurve(lineart1,espalda);

            Point q5 = new Point(319,201);
            Point q6 = new Point(335,236);
            Point q7 = new Point(333,268);
            Point q8 = new Point(322,295);
            Point q9 = new Point(303,314);

            Point[] trasero = { q5, q6, q7, q8, q9 };
            dibujo.DrawCurve(lineart1, trasero);
            #endregion
            #region Colita
            Point c1 = new Point(337,259);
            Point c2 = new Point(356,255);
            Point c3 = new Point(371,265);
            Point c4 = new Point(378,281);
            Point c5 = new Point(372,306);
            Point c6 = new Point(358,317);
            Point c7 = new Point(342,322);
            Point c8 = new Point(325,314);
            Point c9 = new Point(321,300);

            Point[] colita = { c1,c2,c3,c4,c5,c6,c7,c8,c9};
            dibujo.DrawCurve(lineart1,colita);

            Point c10 = new Point(330, 281);
            Point c11 = new Point(340,283);
            Point c12 = new Point(355,306);
            Point c13 = new Point(351,319);

            Point[] raya = { c10, c11, c12, c13 };
            dibujo.DrawCurve(lineart1, raya);

            #endregion
            #region Pancita
            Point y1 = new Point(117,235);
            Point y2 = new Point(113,259);
            Point y3 = new Point(117,287);
            Point y4 = new Point(125,305);
            Point y5 = new Point(131,317);
            Point y6 = new Point(147,329);
            Point y7 = new Point(168,342);
            Point y8 = new Point(199,350);
            Point[] pancita = { y1,y2,y3,y4,y5,y6,y7,y8};
            dibujo.DrawCurve(lineart1,pancita);

            Point y9 = new Point(152,331);
            Point y10 = new Point(166,331);
            Point y11 = new Point(185,328);
            Point[] detalle = { y9, y10, y11 };
            dibujo.DrawCurve(lineart, detalle);

            #endregion
            dibujo.DrawLine(lineart, 146, 138, 159, 154);
        }

        private void CB_BrazoIzq_CheckedChanged(object sender, EventArgs e)
        {
            #region Brazo izquierdo
            Point p1 = new Point(224, 85);
            Point p2 = new Point(161, 154);
            Point p3 = new Point(163, 242);


            Point[] brazoEnf = { p1, p2, p3 };

            Point p4 = new Point(166, 238);
            Point p5 = new Point(171, 298);
            Point p6 = new Point(200, 343);

            Point[] anteBrazo = { p4, p5, p6 };

            Point p7 = new Point(263, 124);
            Point p8 = new Point(262, 182);
            Point p9 = new Point(241, 276);
            Point p10 = new Point(245, 302);

            Point[] brazoAtras = { p7, p8, p9, p10 };

            dibujo.DrawCurve(lineart1, brazoEnf);
            dibujo.DrawCurve(lineart1, anteBrazo);
            dibujo.DrawCurve(lineart1, brazoAtras);
            #endregion
            #region Brazo derecho
            Point n1 = new Point(67, 186);
            Point n2 = new Point(72, 236);

            Point[] brazo1 = { n1, n2 };

            Point n3 = new Point(74, 229);
            Point n4 = new Point(74, 262);
            Point n5 = new Point(80, 287);
            Point n6 = new Point(89, 306);
            Point n7 = new Point(99, 318);

            Point[] brazo2 = {n3, n4,n5, n6, n7,};

            dibujo.DrawCurve(lineart1,brazo1);
            dibujo.DrawCurve(lineart1, brazo2);
            #endregion
            #region Mano
            Point m1 = new Point(200,343);
            Point m2 = new Point(208,364);
            Point m3 = new Point(225,372);
            Point m4 = new Point(243, 365);

            Point []dedo1 = { m1,m2,m3,m4};

            Point m5 = new Point(230,350);
            Point m6 = new Point(238,361);
            Point m7 = new Point(253,362);
            Point m8 = new Point(261,360);
            Point m9 = new Point(266, 343);

            Point[] dedo2 = { m5,m6,m7,m8,m9};

            Point m10 = new Point(249,336);
            Point m11 = new Point(259, 343);
            Point m12 = new Point(274, 341);
            Point m13 = new Point(284, 328);
            Point m14 = new Point(284, 317);
            Point m15 = new Point(273,309);
            Point m16 = new Point(265,313);
            Point m17 = new Point(264,318);
            Point m18 = new Point(258, 305);
            Point m19 = new Point(245,296);

            Point[] dedo3 = { m10, m11 , m12 , m13 , m14 , m15 , m16 , m17 , m18 , m19};

            dibujo.DrawCurve(lineart1, dedo1);
            dibujo.DrawCurve(lineart1, dedo2);
            dibujo.DrawCurve(lineart1, dedo3);

            #endregion


            dibujo.DrawLine(lineart,263,157,271,145);
        }

        private void CB_Piernas_CheckedChanged(object sender, EventArgs e)
        {
            #region Pierna derecha

            Point p1 = new Point(115, 287);
            Point p2 = new Point(98,329);
            Point p3 = new Point(99,369);
            Point p4 = new Point(110,387);
            Point p5 = new Point(129,400);

            Point[] rodilla = {p1,p2,p3,p4,p5 };
            dibujo.DrawCurve(lineart1,rodilla);
            dibujo.DrawLine(lineart1, 177,348,172,370);
            Point p6 = new Point(175,364);
            Point p7 = new Point(178,372);
            Point p8 = new Point(177,380);
            Point[] detallin = { p6, p7, p8 };

            dibujo.DrawCurve(lineart, detallin);
            Point q1 = new Point(179,372);
            Point q2 = new Point(199,410);
            Point q3 = new Point(202,424);
            Point q4 = new Point(193,434);
            Point q5 = new Point(177,435);
            Point[] pieDer = { q1,q2,q3,q4,q5};
            dibujo.DrawCurve(lineart1, pieDer);

            Point r1 = new Point(131,409);
            Point r2 = new Point(124,407);
            Point r3 = new Point(114,432);
            Point r4 = new Point(116,436);
            Point r5 = new Point(129,437);

            Point[] dedo1 = {r1,r2,r3,r4,r5 };
            dibujo.DrawCurve(lineart1, dedo1);

            Point r6 = new Point(149,414);
            Point r7 = new Point(136,410);
            Point r8 = new Point(128,423);
            Point r9 = new Point(133,438);
            Point r10 = new Point(149,438);

            Point[] dedo2 = { r6, r7, r8, r9, r10 };
            dibujo.DrawCurve(lineart1, dedo2);

            Point r11 = new Point(172,416);
            Point r12 = new Point(158,411);
            Point r13 = new Point(150,422);
            Point r14 = new Point(152,432);
            Point r15 = new Point(157,437);
            Point r16 = new Point(164,439);
            Point r17 = new Point(178,431);

            Point[] dedo3 = {r11,r12,r13,r14,r15,r16,r17 };
            dibujo.DrawCurve(lineart1, dedo3);
            #endregion
            #region pierna izquierda
            Point a1 = new Point(307,269);
            Point a2 = new Point(304,308);
            Point a3 = new Point(295,340);
            Point a4 = new Point(275,372);
            Point a5 = new Point(274,377);
            Point[] muslo = { a1, a2, a3, a4, a5 };
            dibujo.DrawCurve(lineart1, muslo);

            Point a6 = new Point(280,364);
            Point a7 = new Point(283,374);
            Point a8 = new Point(277,383);

            Point[] doblez = { a6, a7, a8 };
            dibujo.DrawCurve(lineart1, doblez);

            Point a9 = new Point(282,378);
            Point a10 = new Point(299, 411);
            Point a11 = new Point(296, 425);
            Point a12 = new Point(269,441);

            Point[] pieizq = { a9, a10, a11, a12 };
            dibujo.DrawCurve(lineart1, pieizq);

            #endregion
            #region Dedos
            Point d1 = new Point(223,412);
            Point d2 = new Point(210,409);
            Point d3 = new Point(204,416);
            Point d4 = new Point(202,438);
            Point d5 = new Point(209,443);
            Point d6 = new Point(215,442);
            Point[] dedoo1 = { d1, d2, d3, d4, d5, d6 };

            Point d7 = new Point(237,418);
            Point d8 = new Point(225,413);
            Point d9 = new Point(215,425);
            Point d10 = new Point(220,443);
            Point d11 = new Point(240,444);
            Point[] dedoo2 = { d7,d8,d9,d10,d11};

            Point d12 = new Point(263,424);
            Point d13 = new Point(249,416);
            Point d14 = new Point(239,432);
            Point d15 = new Point(243,445);
            Point d16 = new Point(253,448);
            Point d17 = new Point(269,437);
            Point[] dedoo3 = { d12, d13, d14, d15, d16, d17 };

            dibujo.DrawCurve(lineart1, dedoo1);
            dibujo.DrawCurve(lineart1, dedoo2);
            dibujo.DrawCurve(lineart1, dedoo3);
            #endregion
            Point h1 = new Point(206,365);
            Point h2 = new Point(210,382);
            Point h3 = new Point(216,391);
            Point h4 = new Point(226,398);
            Point[] rodillaD = { h1, h2, h3, h4 }; 

            dibujo.DrawLine(lineart1, 229, 402, 223, 411);
            dibujo.DrawCurve(lineart1, rodillaD);

        }
    }
}
