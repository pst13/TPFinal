using System;                                                               
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace FormLaberinto
{
    /// <summary>
    /// Summary description for Maze.
    /// </summary>
    public class Maze
    {
        public static int kDimension = 10;
        public Cell[,] Cells ;
        Stack CellStack = new Stack();
        int VisitedCells = 1;
        int TotalCells = kDimension * kDimension;
        Cell CurrentCell = null;
        Random random,random2;
        public static Cell inicio;
        public static Cell fin;
        public Cell[] Array;
                            
        public ArrayList caminoRecorrid2 = new ArrayList();
        
        public Maze()
        {
            //
            // TODO: Add constructor logic here
            //
            Initialize();
        }

        private ArrayList GetNeighborsWithWalls(Cell aCell)
        {
            ArrayList Neighbors = new ArrayList();
            //otro arraylist con los vecinos

            for (int countRow = -1; countRow <= 1; countRow++)
                for (int countCol = -1; countCol <= 1; countCol++)
                {
                    if ((aCell.Row + countRow < kDimension) &&
                         (aCell.Column + countCol < kDimension) &&
                         (aCell.Row + countRow >= 0) &&
                         (aCell.Column + countCol >= 0) &&
                         ((countCol == 0) || (countRow == 0)) &&
                         (countRow != countCol)
                        )
                    {
                        if (Cells[aCell.Row + countRow, aCell.Column + countCol].HasAllWalls())
                        {
                            Neighbors.Add(Cells[aCell.Row + countRow, aCell.Column + countCol]);
                            //agrega todos los vecinos que tienen todas las paredes
                        }
                    }
                }

            return Neighbors;
        }

        public void Initialize()
        {
            Cells = new Cell[kDimension, kDimension];
            TotalCells = kDimension * kDimension;
            //inicializo las celdas con su propiedades row y column
            for (int i = 0; i < kDimension; i++)
                for (int j = 0; j < kDimension; j++)
                {
                    Cells[i, j] = new Cell();
                    Cells[i, j].Row = i;
                    Cells[i, j].Column = j;
                }

            CurrentCell = Cells[0, 0];
            VisitedCells = 1;
            //limpia la pila de celdas por visitar
            CellStack.Clear();
        }

        public void Generate()
        {
            while (VisitedCells < TotalCells)
            {
                // devuelve todos los vecinos de la celda actual dentro de los limites
                
                ArrayList AdjacentCells = GetNeighborsWithWalls(CurrentCell);
                // test if a cell like this exists
                if (AdjacentCells.Count > 0)
                {
                    //  elige uno de ellos, y derribar la pared entre el ramdom y la celda actual
                    int randomCell = Cell.TheRandom.Next(0, AdjacentCells.Count);
                    Cell theCell = ((Cell)AdjacentCells[randomCell]);
                    CurrentCell.KnockDownWall(theCell);//derriba la pared
                    CellStack.Push(CurrentCell); // push the current cell onto the stack
                    CurrentCell = theCell; // make the random neighbor the new current cell
                    VisitedCells++;
                }
                else
                {
                    // No cells with walls intact, pop current cell from stack
                    CurrentCell = (Cell)CellStack.Pop();
                }

            }
        }
        public void recorrer(Cell comienzo,Cell fin) {

	
	Cell celda=inicio;
            
            while ( celda!= fin)
            {
                // get a list of the neighboring cells with all walls intact
                ArrayList AdjacentCells = GetNeighborsWithWalls(CurrentCell);
                // test if a cell like this exists
                if (AdjacentCells.Count > 0)
                {
                    // yes, choose one of them, and knock down the wall between it and the current cell
                    int randomCell = Cell.TheRandom.Next(0, AdjacentCells.Count);
                    Cell theCell = ((Cell)AdjacentCells[randomCell]);
                    CurrentCell.KnockDownWall(theCell);
                    CellStack.Push(CurrentCell); // push the current cell onto the stack
                    CurrentCell = theCell; // make the random neighbor the new current cell
                    VisitedCells++;
                }
                else
                {
                    // No cells with walls intact, pop current cell from stack
                    CurrentCell = (Cell)CellStack.Pop();
                }

            }
        
        
        }
        public void encontrarInicioFin(Graphics g)
        {
            int tamañoCelda = Cell.kCellSize - 1;
            random = new Random();
            int aleatorio;
            Pen lapiz=Pens.Red;
            
            aleatorio = this.random.Next(0, kDimension-1);
            inicio = Cells[0, aleatorio];
             Cells[0, aleatorio].entrada=true ;
            //coleccionPuntos[0]= esquina superior izq
                g.DrawRectangle(lapiz, Cells[0, aleatorio].coleccionPuntos[0].X, Cells[0, aleatorio].coleccionPuntos[0].Y, tamañoCelda, tamañoCelda);
                aleatorio = this.random.Next(0, kDimension-1);

                
                fin = Cells[kDimension-1, aleatorio];
                Cells[fin.Row, fin.Column].salida=true ;
            //coleccionPuntos[2]= esquina superior derecha
                g.DrawRectangle(lapiz, Cells[kDimension-1, aleatorio].coleccionPuntos[2].X, Cells[kDimension-1, aleatorio].coleccionPuntos[2].Y, tamañoCelda, tamañoCelda);
        }

        public void Draw(Graphics g)
        {
            //construye las celdas segun su posicion
            for (int i = 0; i < kDimension; i++)
                for (int j = 0; j < kDimension; j++)
                {
                    Cells[i, j].Draw(g);
                }
        }
        
        
                public void buscoSalida()
                {

                	int direccion;
                	int inicioF,inicioC;
                	int finalF, finalC;
                	inicioC = inicio.Row;	//Utilizo una variavle de referencia como columna inicio que luego se actualiza a la actual
                	inicioF = inicio.Column;//Utilizo una variavle de referencia como fila inicio que luego se actualiza a la actual
                	finalF = fin.Column;//Utilizo una variavle de referencia como fila final que permanece igual
                	finalC = fin.Row;//Utilizo una variavle de referencia como columna final que permanece igual
                	

                	while(inicioF!=finalF   ){
                		
//                		direccion=Cells[inicioC,inicioF].queCamino(Cells[inicioC,inicioF]);

                		random2 = new Random();

                		int direccion = this.random2.Next(0, 4);
                		switch (direccion) {//La variable aleatoria decide la posible direccion
                			case 0://Direccion Norte
                				if(Cells[inicioC,inicioF].Walls[0]==0 ){	//Pregunto si la pared norte no existe							// && Cells[inicioC,inicioF].numeroVisitas<3){//if (direccion == 0) {//if(Cells[inicioC,inicioF].Walls[0]==0){
                					inicioF = inicioF - 1;			//Resto uno al actual para cambiar de fila
                					Cells[inicioC,inicioF].visitada=true;
                					
                				}
                				break;
                			case 1://Direccion Oeste
                				if(Cells[inicioC,inicioF].Walls[1]==0){		//Pregunto si la pared oeste no existe								// && Cells[inicioC,inicioF].numeroVisitas<3){//if (direccion == 1) {//if(Cells[inicioC,inicioF].Walls[1]==0){
                					inicioC = inicioC - 1;			//Resto uno al actual para cambiar de columna
                					Cells[inicioC,inicioF].visitada=true;
                					
                				}
                				
                				break;
                				
                			case 2://Direccion Sur
                				if(Cells[inicioC,inicioF].Walls[2]==0 ){	//Pregunto si la pared sur no existe								//&& Cells[inicioC,inicioF].numeroVisitas<3){// if (direccion == 2) {//if(Cells[inicioC,inicioF].Walls[2]==0){
                					inicioF = inicioF + 1;			//Sumo uno al actual para cambiar de fila
                					Cells[inicioC,inicioF].visitada=true;
                					
                				}
                				
                				break;
                				
                			case 3://Direccion Este
                				if(Cells[inicioC,inicioF].Walls[3]==0 ){		//Pregunto si la pared este no existe							//&& Cells[inicioC,inicioF].numeroVisitas<3){//if (direccion == 3) {//if(Cells[inicioC,inicioF].Walls[3]==0){
                					inicioC= inicioC + 1;				//Sumo uno al actual para cambiar de columna
                					Cells[inicioC,inicioF].visitada=true;
                					
                				}
                				
                				break;
                		}

                		//caminoRecorrid2.Add(">>"+inicioF+", "+inicioC+"<<"); Aca guardaria la celda vicitada 
//Esquema Matriz CELL
//	00	10	20...
//	01	11	21...
//	02	12	22...
//	.	.	.
//	.	.	.

                		
                	}


                	
                }
                

    }
}
