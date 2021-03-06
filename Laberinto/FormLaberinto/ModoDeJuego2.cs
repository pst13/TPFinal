﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLaberinto
{
    public partial class ModoDeJuego2 : Form
    {
        int tamañoCeldaD = Cell.kCellSize - 5;
        Graphics g1,g2;
        Tiempo tiempo1,tiempo2;
        public bool generado;
        private Cell celdaMovil;
        private Maze TheMaze;
        public ModoDeJuego2()
        {
            //creo el laberinto
            TheMaze = new Maze();
            //es falso cuando recien inicia el form
            generado = false;
            InitializeComponent();
        }

        private void ModoDeJuego2_Load(object sender, EventArgs e)
        {

        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            Maze.kDimension = 10;

            TheMaze.Initialize();
            //TheMaze.Generate();
            g1 = pictureBox1.CreateGraphics();
            g2 = pictureBox2.CreateGraphics();
            g1.FillRectangle(Brushes.White, ClientRectangle);
            g2.FillRectangle(Brushes.White, ClientRectangle); 
            //dimensiones del laberinto ya resuelto
            TheMaze.Generate();
            TheMaze.Draw(g1);
            TheMaze.Draw(g2);
           
            //encuentra el punto de inicio y fin de forma aleatoria
            TheMaze.encontrarInicioFin(g1);
            TheMaze.encontrarInicioFin(g2);
            celdaMovil = Maze.inicio;

            //si el laberinto esta generado va a hacer true
            generado = true;

            //genera tiempo
            generarTiempo();
            timer1.Enabled = true;
            timer2.Enabled = true;
           
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Pen lapiz;
          
           
          
            if (generado == true)
            {

                lapiz = Pens.Green;
                switch (keyData)
                {

                    case Keys.Up:
                        if (celdaMovil.Walls[0] == 0)
                        {
                            actualizarDibujo();
                            celdaMovil.coleccionPuntos[0].Y= TheMaze.Cells[celdaMovil.Row, celdaMovil.Column].coleccionPuntos[0].Y-=20;//resta cuando se dirige hacia arriba
                            celdaMovil = TheMaze.Cells[celdaMovil.Row, celdaMovil.Column - 1];//le asigno la posicion actual a la celdaMovil
                            g1.FillRectangle(Brushes.Gold, celdaMovil.coleccionPuntos[0].X + 2.5f, celdaMovil.coleccionPuntos[0].Y + 2.5f, tamañoCeldaD, tamañoCeldaD);

                        }
                        break;
                    case Keys.Down:
                        if (celdaMovil.Walls[2] == 0)
                        {
                            actualizarDibujo();
                            celdaMovil.coleccionPuntos[0].Y = TheMaze.Cells[celdaMovil.Row, celdaMovil.Column].coleccionPuntos[0].Y += 20;
                           //Suma Y cuando se dirige hacia abajo
                            celdaMovil = TheMaze.Cells[celdaMovil.Row, celdaMovil.Column + 1];//le asigno la posicion actual a la celdaMovil

                            g1.FillRectangle(Brushes.Gold, celdaMovil.coleccionPuntos[0].X + 2.5f, celdaMovil.coleccionPuntos[0].Y + 2.5f, tamañoCeldaD, tamañoCeldaD);
                        }
                        break;
                    case Keys.Left:
                        if (celdaMovil.Walls[1] == 0)
                        {
                            actualizarDibujo();
                            celdaMovil.coleccionPuntos[0].X = TheMaze.Cells[celdaMovil.Row, celdaMovil.Column].coleccionPuntos[0].X -= 20;
                            //TheMaze.Cells[celdaMovil.Row, celdaMovil.Column].coleccionPuntos[0].X -= 20;
                            celdaMovil = TheMaze.Cells[celdaMovil.Row - 1, celdaMovil.Column];//le asigno la posicion actual a la celdaMovil

                            g1.FillRectangle(Brushes.Gold, celdaMovil.coleccionPuntos[0].X + 2.5f, celdaMovil.coleccionPuntos[0].Y + 2.5f, tamañoCeldaD, tamañoCeldaD);
                        }
                        break;
                    case Keys.Right:
                        if (celdaMovil.Walls[3] == 0)
                        {
                            actualizarDibujo();
                            celdaMovil.coleccionPuntos[0].X = TheMaze.Cells[celdaMovil.Row, celdaMovil.Column].coleccionPuntos[0].X += 20;
                            //TheMaze.Cells[celdaMovil.Row, celdaMovil.Column].coleccionPuntos[0].X += 20;
                            celdaMovil = TheMaze.Cells[celdaMovil.Row + 1, celdaMovil.Column];//le asigno la posicion actual a la celdaMovil

                            g1.FillRectangle(Brushes.Gold, celdaMovil.coleccionPuntos[0].X + 2.5f, celdaMovil.coleccionPuntos[0].Y + 2.5f, tamañoCeldaD, tamañoCeldaD);
                        }
                        break;

                    default:
                        return base.ProcessCmdKey(ref msg, keyData);
                      
                }
              
                if (Maze.fin.Column  == celdaMovil.Column && Maze.fin.Row == celdaMovil.Row)
                {
                    lblTiempo1.Enabled = false;
                    MessageBox.Show("Haz ganado \n");
                   
                    this.Close();
                }
              
                return true;
               
            }
            return false;
        }
        public void generarTiempo()
        {
            lblTiempo1.Enabled = true;
            tiempo1 = new Tiempo(00, 00, 00);
            lblTiempo2.Enabled = true;
            tiempo2 = new Tiempo(00, 00, 00);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblTiempo1.Enabled)
            {

                tiempo1.Seg++;
                if (tiempo1.Seg == 60)
                {
                    tiempo1.Min++;
                    tiempo1.Seg = 00;
                }
                if (tiempo1.Min == 60)
                {
                    tiempo1.Hora++;
                    tiempo1.Min = 00;

                }
                lblTiempo1.Text = tiempo1.ToString();
                    
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (lblTiempo2.Enabled)
            {

                tiempo2.Seg++;
                if (tiempo2.Seg == 60)
                {
                    tiempo2.Min++;
                    tiempo2.Seg = 00;
                }
                if (tiempo2.Min == 60)
                {
                    tiempo2.Hora++;
                    tiempo2.Min = 00;

                }
                lblTiempo2.Text = tiempo2.ToString();
                //padleft inserta un caracter a la izquierda hasta alcanzar el total osea 2
            }
        }

        public string compararTiempo() {
            int tiempo;
            TimeSpan intervalo1= new TimeSpan(tiempo1.Hora, tiempo1.Min, tiempo1.Seg);
            TimeSpan intervalo2= new TimeSpan(tiempo2.Hora, tiempo2.Min, tiempo2.Seg);
            tiempo=TimeSpan.Compare(intervalo1,intervalo2);
            //si son iguales
            if (tiempo==0)
            {
                return "Hay un empate";
            }
            else if (tiempo > 0)
            {
                return "ha ganado el player1 : tiempo ";
            }
            else 
            {
                return "ha ganado el player2";
            }
        }


        public void actualizarDibujo() {
            int tamaño=20;
            Pen lapiz = Pens.Red;
            g1.Clear(Color.White);
            TheMaze.Draw(g1);
            g1.DrawRectangle(lapiz, Maze.inicio.coleccionPuntos[0].X, Maze.inicio.coleccionPuntos[0].Y, tamaño, tamaño);
            g1.DrawRectangle(lapiz, Maze.fin.coleccionPuntos[0].X, Maze.fin.coleccionPuntos[0].Y, tamaño, tamaño);
        }

       
        
    }
}
