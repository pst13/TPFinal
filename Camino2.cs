using System;                                                               
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormLaberinto
{
    /// <summary>
    /// Summary description for Maze.
    /// </summary>
    public class Maze
    {
        public static int kDimension = 20;
        public Cell[,] Cells ;
        Stack CellStack = new Stack();
        int VisitedCells = 1;
        int TotalCells = kDimension * kDimension;
        Cell CurrentCell = null;
        Random random,random2;
        public static Cell inicio;
        public static Cell fin;

        
        public Stack caminoRecorrido = new Stack();     
//        public Cell[] caminoRecorrid;
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
            random = new Random();
            int aleatorio;
            Pen lapiz=Pens.Red;
            Pen lapiz2=new Pen(Color.DarkSeaGreen,5);
            
            aleatorio = this.random.Next(0, kDimension-1);
            inicio = Cells[0, aleatorio];
            Cells[0, aleatorio].entrada=true ;
            //inicio.entrada=true;
            //coleccionPuntos[0]= esquina superior izq
                g.DrawRectangle(lapiz, Cells[0, aleatorio].coleccionPuntos[0].X, Cells[0, aleatorio].coleccionPuntos[0].Y, 10, 10);
                aleatorio = this.random.Next(0, kDimension - 1);

                fin = Cells[kDimension-1, aleatorio];
				Cells[fin.Row, fin.Column].salida=true ;
                //fin.salida=true;
            //coleccionPuntos[2]= esquina superior derecha
               // g.DrawRectangle(lapiz2, Cells[kDimension-1, aleatorio].coleccionPuntos[2].X, Cells[kDimension-1, aleatorio].coleccionPuntos[2].Y, 10, 10);
               g.DrawRectangle(lapiz2, Cells[fin.Row, fin.Column].coleccionPuntos[2].X, Cells[fin.Row, fin.Column].coleccionPuntos[2].Y, 10, 10);
       
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
        	inicioC = inicio.Row;
        	inicioF = inicio.Column;
        	finalF = fin.Column;
        	finalC = fin.Row;
        	
        	random2 = new Random();
        	int aleatorio;
        	int direc=0;
        	bool var=true;

        caminoRecorrid2.Add(Cells[inicioC,inicioF]);	

while( !Cells[inicioC,inicioF].salida  ){

direccion=Cells[inicioC,inicioF].queCamino(Cells[inicioC,inicioF]);


if(var){
aleatorio = this.random2.Next(0, 4);
}else{
	aleatorio=direc;
}








switch (aleatorio) {
                		case 0:
		if(Cells[inicioC,inicioF].Walls[0]==0 ){// && Cells[inicioC,inicioF].numeroVisitas<3){//if (direccion == 0) {//if(Cells[inicioC,inicioF].Walls[0]==0){
								inicioF = inicioF - 1;
								Cells[inicioC,inicioF].visitada=true;
								Cells[inicioC,inicioF].numeroVisitas++;
								var=false;
								direc=0;
								}else
			var=true;
		break;
	case 1:
		if(Cells[inicioC,inicioF].Walls[1]==0){// && Cells[inicioC,inicioF].numeroVisitas<3){//if (direccion == 1) {//if(Cells[inicioC,inicioF].Walls[1]==0){
inicioC = inicioC - 1;
Cells[inicioC,inicioF].visitada=true;
Cells[inicioC,inicioF].numeroVisitas++;
var=false;
direc=1;
}else
			var=true;
		
		break;
		
	case 2:
		if(Cells[inicioC,inicioF].Walls[2]==0 ){//&& Cells[inicioC,inicioF].numeroVisitas<3){// if (direccion == 2) {//if(Cells[inicioC,inicioF].Walls[2]==0){
inicioF = inicioF + 1;
Cells[inicioC,inicioF].visitada=true;
Cells[inicioC,inicioF].numeroVisitas++;
var=false;
direc=2;
}else
			var=true;
		
		break;
		
	case 3:
		if(Cells[inicioC,inicioF].Walls[3]==0 ){//&& Cells[inicioC,inicioF].numeroVisitas<3){//if (direccion == 3) {//if(Cells[inicioC,inicioF].Walls[3]==0){
inicioC= inicioC + 1;
Cells[inicioC,inicioF].visitada=true;
Cells[inicioC,inicioF].numeroVisitas++;
var=false;
direc=3;
}else
			var=true;
		
		break;

}

caminoRecorrid2.Add(Cells[inicioC,inicioF]);


            }


        	
        }
        



        
    }
}
