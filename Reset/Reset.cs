

public void ConversandoConAgente(){

Point comienzo;
Point fin;
Point actual;
Point[] puntos;
	Agente ag = new Agente(comienzo);

	while(actual != fin){

	actual = ag.moveAgent();
	}

}

//Metodo que llama al metodo celdas adyacentes y convierte el arreglo de celdas en un arreglo de puntos.
//public Point[] GetPuntos(Point p){
//	int x = p.Point.x;
//	int y = p.Point.y;

public Point[] GetPuntos(Cell cell){

    Point[] puntos;
    int[] argCell;

	argCell = GetNeighborssWithWall(cell);
	
	for(int i=0; i < argCell.Length; i++){
		puntos[i] = argCell[i].point;
	}
	return puntos;
}